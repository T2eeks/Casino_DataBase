using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casino_DataBase.DataAccess;

namespace Casino_DataBase
{
    public partial class BetsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable betsTable;
        private BindingSource bindingSource;

        public BetsForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                betsTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID_ставки AS ID, Сумма, Дата_время, ID_игрока, ID_сотрудника, ID_данных FROM Ставка", connection);
                adapter.Fill(betsTable);

                bindingSource = new BindingSource(betsTable, null);
                betsBindingNavigator.BindingSource = bindingSource;

                betsDataGridView.AutoGenerateColumns = false;
                betsDataGridView.Columns.Clear();

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID ставки",
                });

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Сумма",
                    HeaderText = "Сумма"
                });

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Дата_время",
                    HeaderText = "Дата и время",
                });

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID_игрока",
                    HeaderText = "ID игрока"
                });

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID_сотрудника",
                    HeaderText = "ID сотрудника"
                });

                betsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID_данных",
                    HeaderText = "ID данных"
                });

                betsDataGridView.DataSource = bindingSource;

                amountTextBox.DataBindings.Add("Text", bindingSource, "Сумма", true, DataSourceUpdateMode.OnPropertyChanged, "0.00");
                playerIdTextBox.DataBindings.Add("Text", bindingSource, "ID_игрока", true, DataSourceUpdateMode.OnPropertyChanged, "0");
                staffIdTextBox.DataBindings.Add("Text", bindingSource, "ID_сотрудника", true, DataSourceUpdateMode.OnPropertyChanged, "0");
                dataIdTextBox.DataBindings.Add("Text", bindingSource, "ID_данных", true, DataSourceUpdateMode.OnPropertyChanged, "0");

                bindingSource.CurrentItemChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        int playerId = Convert.ToInt32(row["ID_игрока"]);
                        int staffId = Convert.ToInt32(row["ID_сотрудника"]);
                        int dataId = Convert.ToInt32(row["ID_данных"]);

                        if (playerId <= 0 || staffId <= 0 || dataId <= 0)
                        {
                            MessageBox.Show("ID игрока, сотрудника и данных должны быть положительными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row["ID_игрока"] = 1; 
                            row["ID_сотрудника"] = 1;
                            row["ID_данных"] = 1;
                        }
                    }
                };

                betsDataGridView.DataError += (s, e) =>
                {
                    MessageBox.Show($"Ошибка в DataGridView: {e.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (betsTable != null && adapter != null)
                {
                    betsDataGridView.EndEdit();
                    bindingSource.EndEdit();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(betsTable);
                    MessageBox.Show("Изменения сохранены при закрытии!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(betsTable);

                betsTable.Clear();
                adapter.Fill(betsTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                betsDataGridView.DataSource = null;
                betsDataGridView.DataSource = bindingSource;
                betsDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (betsDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = betsDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить ставку с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(betsTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    betsDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    betsTable.RejectChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(betsTable);

                betsTable.Clear();
                adapter.Fill(betsTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                betsDataGridView.DataSource = null;
                betsDataGridView.DataSource = bindingSource;
                betsDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                betsDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(betsTable);
                betsDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
