using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
                string connectionString = "Data Source=127.0.0.1,1434;Initial Catalog=Casino;Integrated Security=True;Encrypt=False";
                connection = new SqlConnection(connectionString);
                connection.Open();

                playersTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Игрок", connection);
                adapter.Fill(playersTable);

                bindingSource = new BindingSource(playersTable, null);
                playersDataGridView.DataSource = bindingSource;
                playersBindingNavigator.BindingSource = bindingSource;

                // Привязки текстовых полей
                nameTextBox.DataBindings.Add("Text", bindingSource, "Имя", true, DataSourceUpdateMode.OnPropertyChanged, "");
                surnameTextBox.DataBindings.Add("Text", bindingSource, "Фамилия", true, DataSourceUpdateMode.OnPropertyChanged, "");
                patronymicTextBox.DataBindings.Add("Text", bindingSource, "Отчество", true, DataSourceUpdateMode.OnPropertyChanged, "");
                birthDateTextBox.DataBindings.Add("Text", bindingSource, "Дата_рождения", true, DataSourceUpdateMode.OnPropertyChanged, "");

                // Настройка ComboBox
                statusComboBox.Items.AddRange(new string[] { "Vip", "Classic" });
                statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                // Привязка ComboBox к столбцу Статус
                statusComboBox.DataBindings.Add("SelectedIndex", bindingSource, "Статус", true, DataSourceUpdateMode.OnPropertyChanged);
                statusComboBox.SelectedIndexChanged += (s, e) =>
                {
                    if (bindingSource.Current != null && statusComboBox.SelectedIndex >= 0)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;
                        row["Статус"] = (statusComboBox.SelectedIndex == 0); // Vip = true
                    }
                };

                // Преобразуем булевый статус в таблице в текст
                playersDataGridView.CellFormatting += (s, e) =>
                {
                    if (playersDataGridView.Columns[e.ColumnIndex].Name == "Статус" && e.Value != null && e.Value != DBNull.Value)
                    {
                        try
                        {
                            bool isVip = false;
                            if (e.Value is bool b)
                                isVip = b;
                            else if (e.Value is int i)
                                isVip = (i != 0);
                            else if (e.Value is string sValue)
                                isVip = sValue.Equals("Vip", StringComparison.OrdinalIgnoreCase) || sValue == "1" || sValue.ToLower() == "true";

                            e.Value = isVip ? "Vip" : "Classic";
                            e.FormattingApplied = true;
                        }
                        catch
                        {
                            e.Value = "Ошибка";
                            e.FormattingApplied = true;
                        }
                    }
                };

                // Обработка смены строки и загрузка фото
                playersDataGridView.SelectionChanged += (s, e) =>
                {
                    if (playersDataGridView.SelectedRows.Count > 0)
                    {
                        int selectedIndex = playersDataGridView.SelectedRows[0].Index;
                        bindingSource.Position = selectedIndex;
                    }

                    if (bindingSource.Current != null)
                    {
                        DataRowView row = (DataRowView)bindingSource.Current;

                        // Фото
                        if (row["Фото_игрока"] != DBNull.Value && !string.IsNullOrEmpty(row["Фото_игрока"].ToString()))
                        {
                            string photoPath = row["Фото_игрока"].ToString();
                            if (File.Exists(photoPath))
                                playerPictureBox.Image = Image.FromFile(photoPath);
                            else
                            {
                                playerPictureBox.Image = null;
                                MessageBox.Show($"Файл {photoPath} не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            playerPictureBox.Image = null;
                        }
                    }
                };

                // Обработка ошибок в таблице
                playersDataGridView.DataError += (s, e) =>
                {
                    MessageBox.Show("Ошибка отображения данных в таблице.\n" + e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.ThrowException = false;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (playersTable != null && adapter != null)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(playersTable);
                    MessageBox.Show("Изменения сохранены при закрытии!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void playersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(playersTable);
                playersDataGridView.Refresh(); 
                MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем текущую позицию
                int currentPosition = bindingSource.Position;

                // Сохраняем изменения в базе
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(playersTable);

                // Обновляем данные
                playersTable.Clear();
                adapter.Fill(playersTable);

                // Восстанавливаем позицию
                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                // Принудительно обновляем DataGridView
                playersDataGridView.DataSource = null; // Сбрасываем источник данных
                playersDataGridView.DataSource = bindingSource; // Заново привязываем
                playersDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.AddNew();
                playerPictureBox.Image = null; // Очищаем PictureBox для новой записи
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (playersDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = playersDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;
                bindingSource.RemoveCurrent();
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
                        // Если добавлен столбец PhotoPath: row["PhotoPath"] = photoPath;

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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
