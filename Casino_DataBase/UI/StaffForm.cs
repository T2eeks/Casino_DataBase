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
    public partial class StaffForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable staffTable;
        private BindingSource bindingSource;

        public StaffForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                staffTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID_сотрудника AS ID, Фамилия, Имя, Отчество, Должность, Серия_паспорта, Номер_паспорта FROM Сотрудник", connection);
                adapter.Fill(staffTable);

                bindingSource = new BindingSource(staffTable, null);
                staffBindingNavigator.BindingSource = bindingSource;

                staffDataGridView.AutoGenerateColumns = false;
                staffDataGridView.Columns.Clear();

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID сотрудника",
                });

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Фамилия",
                    HeaderText = "Фамилия"
                });

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Имя",
                    HeaderText = "Имя"
                });

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Отчество",
                    HeaderText = "Отчество"
                });

                DataGridViewComboBoxColumn positionColumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "Должность",
                    HeaderText = "Должность",
                    DataSource = new string[] { "Крупье", "Администратор", "Охранник" },
                    ValueType = typeof(string)
                };
                staffDataGridView.Columns.Add(positionColumn);

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Серия_паспорта",
                    HeaderText = "Серия паспорта"
                });

                staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Номер_паспорта",
                    HeaderText = "Номер паспорта"
                });

                staffDataGridView.DataSource = bindingSource;

                
                surnameTextBox.DataBindings.Add("Text", bindingSource, "Фамилия", true, DataSourceUpdateMode.OnPropertyChanged, "");
                nameTextBox.DataBindings.Add("Text", bindingSource, "Имя", true, DataSourceUpdateMode.OnPropertyChanged, "");
                patronymicTextBox.DataBindings.Add("Text", bindingSource, "Отчество", true, DataSourceUpdateMode.OnPropertyChanged, "");
                positionComboBox.DataSource = new string[] { "Крупье", "Администратор", "Охранник" };
                positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Только выбор из списка
                positionComboBox.DataBindings.Add("SelectedItem", bindingSource, "Должность", true, DataSourceUpdateMode.OnPropertyChanged);
                passportSeriesTextBox.DataBindings.Add("Text", bindingSource, "Серия_паспорта", true, DataSourceUpdateMode.OnPropertyChanged, "");
                passportNumberTextBox.DataBindings.Add("Text", bindingSource, "Номер_паспорта", true, DataSourceUpdateMode.OnPropertyChanged, "");

                
                bindingSource.CurrentItemChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        string position = row["Должность"] != DBNull.Value ? row["Должность"].ToString() : "Крупье"; // Проверка на DBNull
                        if (!new string[] { "Крупье", "Администратор", "Охранник" }.Contains(position))
                        {
                            MessageBox.Show("Некорректная должность! Допустимы: Крупье, Администратор, Охранник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row["Должность"] = "Крупье";
                            positionComboBox.SelectedItem = "Крупье";
                        }
                    }
                };

                
                staffDataGridView.DataError += (s, e) =>
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

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (staffTable != null && adapter != null)
                {
                    staffDataGridView.EndEdit();
                    bindingSource.EndEdit();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(staffTable);
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
            
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = staffDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить сотрудника с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(staffTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    staffDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    staffTable.RejectChanges();
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
                adapter.Update(staffTable);

                staffTable.Clear();
                adapter.Fill(staffTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                staffDataGridView.DataSource = null;
                staffDataGridView.DataSource = bindingSource;
                staffDataGridView.Refresh();

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
                staffDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(staffTable);
                staffDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
