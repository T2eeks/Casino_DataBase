namespace Casino_DataBase
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using Casino_DataBase.DataAccess;

    public partial class GameForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable gamesTable;
        private BindingSource bindingSource;

        public GameForm()
        {
            InitializeComponent();

            try
            {
                connection = DatabaseConnection.GetInstance();

                gamesTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID_игры AS ID, Наименование, Правила FROM Игра", connection);
                adapter.Fill(gamesTable);

                bindingSource = new BindingSource(gamesTable, null);
                gameBindingNavigator.BindingSource = bindingSource;

                gameDataGridView.AutoGenerateColumns = true; 
                gameDataGridView.DataSource = bindingSource;

                gameNameTextBox.DataBindings.Add("Text", bindingSource, "Наименование", true, DataSourceUpdateMode.OnPropertyChanged, "");
                rulesTextBox.DataBindings.Add("Text", bindingSource, "Правила", true, DataSourceUpdateMode.OnPropertyChanged, "");

                gameDataGridView.DataError += (s, e) =>
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

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (gamesTable != null && adapter != null)
                {
                    gameDataGridView.EndEdit();
                    bindingSource.EndEdit();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(gamesTable);
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
                adapter.Update(gamesTable);

                gamesTable.Clear();
                adapter.Fill(gamesTable);

                if (currentPosition >= 0 && currentPosition < bindingSource.Count)
                {
                    bindingSource.Position = currentPosition;
                }

                gameDataGridView.DataSource = null;
                gameDataGridView.DataSource = bindingSource;
                gameDataGridView.Refresh();

                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (gameDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = gameDataGridView.SelectedRows[0].Index;
                bindingSource.Position = selectedIndex;

                try
                {
                    DataRowView row = (DataRowView)bindingSource.Current;
                    int idToDelete = (int)row["ID"];
                    MessageBox.Show($"Попытка удалить игру с ID: {idToDelete}");

                    bindingSource.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(gamesTable);
                    MessageBox.Show($"Удалено строк: {rowsAffected}");

                    gameDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gamesTable.RejectChanges();
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

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                gameDataGridView.EndEdit();
                bindingSource.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int rowsAffected = adapter.Update(gamesTable);
                gameDataGridView.Refresh();
                MessageBox.Show($"Строк обновлено: {rowsAffected}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}