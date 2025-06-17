using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using Casino_DataBase.DataAccess;
using System.Collections.Generic;


namespace Casino_DataBase
{
    public partial class PlayersForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable playersTable;
        private BindingSource bindingSource;

        public PlayersForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                playersTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID, Фамилия, Имя, Отчество, Дата_рождения, Статус, Фото_игрока FROM Игрок", connection);
                adapter.Fill(playersTable);

                DataColumn ageColumn = new DataColumn("Возраст", typeof(int));
                playersTable.Columns.Add(ageColumn);


                foreach (DataRow row in playersTable.Rows)
                {
                    if (row["Дата_рождения"] != DBNull.Value)
                    {
                        DateTime birthDate = (DateTime)row["Дата_рождения"];
                        int age = DateTime.Now.Year - birthDate.Year;
                        if (birthDate.Date > DateTime.Now.AddYears(-age)) age--;
                        row["Возраст"] = age;
                    }
                    else
                    {
                        row["Возраст"] = 0; 
                    }
                }

                bindingSource = new BindingSource(playersTable, null);
                playersBindingNavigator.BindingSource = bindingSource;

                playersDataGridView.AutoGenerateColumns = false; 
                playersDataGridView.Columns.Clear();

                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID",
                });

                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Фамилия",
                    HeaderText = "Фамилия"
                });

                
                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Имя",
                    HeaderText = "Имя"
                });

                
                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Отчество",
                    HeaderText = "Отчество"
                });

                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Дата_рождения",
                    HeaderText = "Дата рождения"
                });

                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Возраст",
                    HeaderText = "Возраст"
                });

                var statusItems = new List<object>
                {
                new { Display = "Vip", Value = true },
                new { Display = "Classic", Value = false }
                };
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "Статус",
                    HeaderText = "Статус",
                    Name = "dataGridViewComboBoxColumnStatus",
                    DataSource = statusItems,
                    DisplayMember = "Display",
                    ValueMember = "Value",
                    ValueType = typeof(bool)
                };
                playersDataGridView.Columns.Add(statusColumn);

                playersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Фото_игрока",
                    HeaderText = "Фото игрока",
                });

                playersDataGridView.DataSource = bindingSource;

                nameTextBox.DataBindings.Add("Text", bindingSource, "Имя", true, DataSourceUpdateMode.OnPropertyChanged, "");
                surnameTextBox.DataBindings.Add("Text", bindingSource, "Фамилия", true, DataSourceUpdateMode.OnPropertyChanged, "");
                patronymicTextBox.DataBindings.Add("Text", bindingSource, "Отчество", true, DataSourceUpdateMode.OnPropertyChanged, "");
                birthDateTextBox.DataBindings.Add("Text", bindingSource, "Дата_рождения", true, DataSourceUpdateMode.OnPropertyChanged, "");

                statusComboBox.Items.AddRange(new string[] { "Vip", "Classic" });
                statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                statusComboBox.SelectedIndexChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        row["Статус"] = statusComboBox.SelectedItem.ToString() == "Vip";
                    }
                };

                playersDataGridView.SelectionChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        bool isVip = row["Статус"] != DBNull.Value ? (bool)row["Статус"] : false; 
                        statusComboBox.SelectedItem = isVip ? "Vip" : "Classic";

                        string photoPath = row["Фото_игрока"]?.ToString();
                        if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                        {
                            playerPictureBox.Image = Image.FromFile(photoPath);
                        }
                        else
                        {
                            playerPictureBox.Image = null;
                        }
                    }
                };

                bindingSource.CurrentItemChanged += (s, e) =>
                {
                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        bool status = row["Статус"] != DBNull.Value ? (bool)row["Статус"] : false; 
                                                                                                   
                    }
                };

                playersDataGridView.DataError += (s, e) =>
                {
                    MessageBox.Show($"Ошибка в DataGridView: {e.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (playersTable != null && adapter != null)
                {
                    playersDataGridView.EndEdit();
                    bindingSource.EndEdit();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    e.Cancel = MessageBox.Show("Несохраненные данные могут быть утеряны, Вы действительно хотите выйты?", "Закрытие окна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка закрытия: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                playersDataGridView.EndEdit();
                bindingSource.EndEdit();

                DateTime currentDate = DateTime.Now;
                int minYear = currentDate.Year - 18;
                DataRowView currentRow = (DataRowView)bindingSource.Current;
                if (currentRow["Дата_рождения"] != DBNull.Value)
                {
                    DateTime birthDate = (DateTime)currentRow["Дата_рождения"];
                    if (birthDate.Year > minYear)
                    {
                        MessageBox.Show($"Ошибка: Игрок должен быть старше 18 лет (мин. год рождения: {minYear}).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(playersTable);
                playersDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Ошибка: Игрок с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show($"Ошибка: Неверные данные ({ex.Message}). Проверьте поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int currentPosition = bindingSource.Position;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(playersTable);

                playersTable.Clear();
                adapter.Fill(playersTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                playersDataGridView.DataSource = null;
                playersDataGridView.DataSource = bindingSource;
                playersDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (playersDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = playersDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить игрока с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(playersTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    playersDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    playersTable.RejectChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string photoPath = openFileDialog.FileName;
                        playerPictureBox.Image = Image.FromFile(photoPath);

                        DataRowView row = (DataRowView)bindingSource.Current;
                        row["Фото_игрока"] = photoPath;

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(playersTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки фото: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void playersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = playersDataGridView.Rows[e.RowIndex];
                var statusCell = row.Cells["dataGridViewComboBoxColumnStatus"].Value;

                if (statusCell == null || statusCell == DBNull.Value)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; 
                }
                else
                {
                    bool isVip = (bool)statusCell;
                    if (isVip) 
                    {
                        row.DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                    else 
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
            }
        }
    }
    
}