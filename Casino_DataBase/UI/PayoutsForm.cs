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
    public partial class PayoutsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable payoutsTable;
        private BindingSource bindingSource;

        public PayoutsForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                payoutsTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID_выплаты AS ID, Дата_время, ID_ставки, Способ_выплаты, Сумма FROM Выплата", connection);
                adapter.Fill(payoutsTable);

                DataTable stakesTable = new DataTable();
                SqlDataAdapter stakesAdapter = new SqlDataAdapter("SELECT ID_ставки, ID_игрока FROM Ставка", connection);
                stakesAdapter.Fill(stakesTable);

                DataTable playersTable = new DataTable();
                SqlDataAdapter playersAdapter = new SqlDataAdapter("SELECT ID, Фамилия, Имя, Отчество FROM Игрок", connection);
                playersAdapter.Fill(playersTable);

                DataColumn fullNameColumn = new DataColumn("ФИО", typeof(string));
                payoutsTable.Columns.Add(fullNameColumn);

                foreach (DataRow row in payoutsTable.Rows)
                {
                    int betId = (int)row["ID_ставки"];
                    DataRow stakeRow = stakesTable.AsEnumerable().FirstOrDefault(s => s.Field<int>("ID_ставки") == betId);
                    if (stakeRow != null)
                    {
                        int playerId = (int)stakeRow["ID_игрока"];
                        DataRow playerRow = playersTable.AsEnumerable().FirstOrDefault(p => p.Field<int>("ID") == playerId);
                        if (playerRow != null)
                        {
                            string surname = playerRow["Фамилия"] != DBNull.Value ? playerRow["Фамилия"].ToString() : "";
                            string name = playerRow["Имя"] != DBNull.Value ? playerRow["Имя"].ToString() : "";
                            string patronymic = playerRow["Отчество"] != DBNull.Value ? playerRow["Отчество"].ToString() : "";
                            row["ФИО"] = $"{surname} {name} {patronymic}".Trim();
                        }
                        else
                        {
                            row["ФИО"] = "Неизвестный игрок";
                        }
                    }
                    else
                    {
                        row["ФИО"] = "Ставка не найдена";
                    }
                }

                bindingSource = new BindingSource(payoutsTable, null);
                payoutsBindingNavigator.BindingSource = bindingSource;

                payoutsDataGridView.AutoGenerateColumns = false;
                payoutsDataGridView.Columns.Clear();
                payoutsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID выплаты",
                });

                payoutsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Дата_время",
                    HeaderText = "Дата и время",
                });

                payoutsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID_ставки",
                    HeaderText = "ID ставки"
                });

                DataGridViewComboBoxColumn paymentMethodColumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "Способ_выплаты",
                    HeaderText = "Способ выплаты",
                    DataSource = new string[] { "Наличные", "Карта", "Электронный кошелёк" },
                    ValueType = typeof(string)
                };
                payoutsDataGridView.Columns.Add(paymentMethodColumn);

                payoutsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Сумма",
                    HeaderText = "Сумма"
                });

                payoutsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ФИО",
                    HeaderText = "ФИО игрока"
                });

                payoutsDataGridView.DataSource = bindingSource;

                betIdTextBox.DataBindings.Add("Text", bindingSource, "ID_ставки", true, DataSourceUpdateMode.OnPropertyChanged, "");
                amountTextBox.DataBindings.Add("Text", bindingSource, "Сумма", true, DataSourceUpdateMode.OnPropertyChanged, "0.00");
                paymentMethodComboBox.DataSource = new string[] { "Наличные", "Карта", "Электронный кошелёк" };
                paymentMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList; 
                paymentMethodComboBox.DataBindings.Add("SelectedItem", bindingSource, "Способ_выплаты", true, DataSourceUpdateMode.OnPropertyChanged);

                bindingSource.CurrentItemChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        string paymentMethod = row["Способ_выплаты"] != DBNull.Value ? row["Способ_оплаты"].ToString() : "Наличные";
                        if (!new string[] { "Наличные", "Карта", "Электронный кошелёк" }.Contains(paymentMethod))
                        {
                            MessageBox.Show("Некорректный способ выплаты! Допустимы: Наличные, Карта, Электронный кошелёк.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row["Способ_выплаты"] = "Наличные";
                            paymentMethodComboBox.SelectedItem = "Наличные";
                        }
                    }
                };

                payoutsDataGridView.DataError += (s, e) =>
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

        private void PayoutsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (payoutsTable != null && adapter != null)
                {
                    payoutsDataGridView.EndEdit();
                    bindingSource.EndEdit();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(payoutsTable);
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
            try
            {
                payoutsDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(payoutsTable);
                payoutsDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(payoutsTable);

                payoutsTable.Clear();
                adapter.Fill(payoutsTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                payoutsDataGridView.DataSource = null;
                payoutsDataGridView.DataSource = bindingSource;
                payoutsDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (payoutsDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = payoutsDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить выплату с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(payoutsTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    payoutsDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    payoutsTable.RejectChanges();
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

        private void refreshToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(payoutsTable);

                payoutsTable.Clear();
                adapter.Fill(payoutsTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                payoutsDataGridView.DataSource = null;
                payoutsDataGridView.DataSource = bindingSource;
                payoutsDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                payoutsDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(payoutsTable);
                payoutsDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
