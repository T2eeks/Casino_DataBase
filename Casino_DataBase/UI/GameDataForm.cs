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

namespace Casino_DataBase.UI
{
    public partial class GameDataForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable gameDataTable;
        private BindingSource bindingSource;

        public GameDataForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                gameDataTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID_данных AS ID, Дата_время, ID_игры, Результат_игры FROM Данные_о_текущей_игре", connection);
                adapter.Fill(gameDataTable);

                bindingSource = new BindingSource(gameDataTable, null);
                gameDataBindingNavigator.BindingSource = bindingSource;

                gameDataDataGridView.AutoGenerateColumns = false;
                gameDataDataGridView.Columns.Clear();

                gameDataDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID данных",
                });

                gameDataDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Дата_время",
                    HeaderText = "Дата и время",
                });

                gameDataDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID_игры",
                    HeaderText = "ID игры"
                });

                DataGridViewComboBoxColumn resultColumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "Результат_игры",
                    HeaderText = "Результат игры",
                    DataSource = new string[] { "Победа", "Поражение", "Ничья" },
                    ValueType = typeof(string)
                };
                gameDataDataGridView.Columns.Add(resultColumn);

                gameDataDataGridView.DataSource = bindingSource;

                gameIdTextBox.DataBindings.Add("Text", bindingSource, "ID_игры", true, DataSourceUpdateMode.OnPropertyChanged, "0");
                resultComboBox.DataSource = new string[] { "Победа", "Поражение", "Ничья" };
                resultComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                resultComboBox.DataBindings.Add("SelectedItem", bindingSource, "Результат_игры", true, DataSourceUpdateMode.OnPropertyChanged);

                bindingSource.CurrentItemChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        string result = row["Результат_игры"] != DBNull.Value ? row["Результат_игры"].ToString() : "Ничья"; // Проверка на DBNull
                        if (!new string[] { "Победа", "Поражение", "Ничья" }.Contains(result))
                        {
                            MessageBox.Show("Некорректный результат игры! Допустимы: Победа, Поражение, Ничья.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row["Результат_игры"] = "Ничья"; // Установка значения по умолчанию
                        }
                    }
                };

               
                gameDataDataGridView.DataError += (s, e) =>
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

        private void GameDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (gameDataTable != null && adapter != null)
                {
                    gameDataDataGridView.EndEdit();
                    bindingSource.EndEdit();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(gameDataTable);
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


        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (gameDataDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = gameDataDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить данные с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(gameDataTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    gameDataDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gameDataTable.RejectChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(gameDataTable);

                gameDataTable.Clear();
                adapter.Fill(gameDataTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                gameDataDataGridView.DataSource = null;
                gameDataDataGridView.DataSource = bindingSource;
                gameDataDataGridView.Refresh();

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
                gameDataDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(gameDataTable);
                gameDataDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void gameIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
