using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Casino_DataBase.DataAccess;
using System.IO;


namespace Casino_DataBase.UI
{

    public partial class Lab4 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable playersTable;
        private BindingSource bindingSource;
        private string photoPath; // Для хранения пути к файлу изображения

        public Lab4()
        {
            InitializeComponent();
            connection = DatabaseConnection.GetInstance();

            try
            {
                // Инициализация таблицы для вкладки DML
                playersTable = new DataTable();
                adapter = new SqlDataAdapter("SELECT ID, Фамилия, Имя, Отчество, Дата_рождения, Статус, Фото_игрока FROM Игрок", connection);
                adapter.Fill(playersTable);

                bindingSource = new BindingSource(playersTable, null);
                dataGridViewDML.DataSource = bindingSource;

                // Настройка DataGridView для вкладки DML
                dataGridViewDML.AutoGenerateColumns = false;
                dataGridViewDML.Columns.Clear();
                dataGridViewDML.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" });
                dataGridViewDML.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Фамилия", HeaderText = "Фамилия" });
                dataGridViewDML.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Имя", HeaderText = "Имя" });
                dataGridViewDML.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Отчество", HeaderText = "Отчество" });
                dataGridViewDML.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Дата_рождения", HeaderText = "Дата рождения" });
                dataGridViewDML.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Статус", HeaderText = "VIP" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable FillDataGridView(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выборки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        private void groupBoxSelect_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlSQL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSelect_Click(object sender, EventArgs e)
        {

        }

        private void TabPageSubquery_Click(object sender, EventArgs e)
        {

        }

        private void tabPageDML_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonOneTable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWithConditions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMultipleTables_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonParametric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFullSelect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAggregate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelParam_Click(object sender, EventArgs e)
        {

        }

        private void buttonExecuteSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExecuteSelect_Click(object sender, EventArgs e)
        {
            string sqlSelect = "";
            SqlParameter[] parameters = null;

            if (radioButtonParametric.Checked || radioButtonWithConditions.Checked)
            {
                if (!int.TryParse(textBoxParam.Text, out int playerId) || playerId <= 0)
                {
                    MessageBox.Show("ID игрока должен быть положительным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                parameters = new[] { new SqlParameter("@Id", playerId) };
            }

            if (radioButtonOneTable.Checked)
            {
                sqlSelect = "SELECT ID, Фамилия, Имя, Отчество, Дата_рождения, Статус FROM Игрок";
            }
            else if (radioButtonWithConditions.Checked)
            {
                sqlSelect = "SELECT ID, Фамилия, Имя, Отчество, Дата_рождения, Статус FROM Игрок WHERE ID = @Id AND DATEDIFF(YEAR, Дата_рождения, GETDATE()) >= 18";
            }
            else if (radioButtonMultipleTables.Checked)
            {
                sqlSelect = "SELECT Игрок.ID, Игрок.Фамилия, Игрок.Имя, Ставка.Сумма, Ставка.Дата_время " +
                            "FROM Игрок INNER JOIN Ставка ON Игрок.ID = Ставка.ID_игрока";
            }
            else if (radioButtonAggregate.Checked)
            {
                sqlSelect = "SELECT Игрок.ID, Игрок.Фамилия, Игрок.Имя, COUNT(Ставка.ID_ставки) AS Количество_ставок, " +
                            "AVG(Ставка.Сумма) AS Средняя_ставка " +
                            "FROM Игрок LEFT JOIN Ставка ON Игрок.ID = Ставка.ID_игрока " +
                            "GROUP BY Игрок.ID, Игрок.Фамилия, Игрок.Имя";
            }
            else if (radioButtonFullSelect.Checked)
            {
                sqlSelect = "SELECT Игрок.ID, Игрок.Фамилия + ' ' + Игрок.Имя + ' ' + Игрок.Отчество AS ФИО, " +
                            "COUNT(Ставка.ID_ставки) AS Количество_ставок " +
                            "FROM Игрок LEFT JOIN Ставка ON Игрок.ID = Ставка.ID_игрока " +
                            "WHERE Игрок.Статус = 1 " +
                            "GROUP BY Игрок.ID, Игрок.Фамилия, Игрок.Имя, Игрок.Отчество " +
                            "HAVING COUNT(Ставка.ID_ставки) > 0 " +
                            "ORDER BY Количество_ставок DESC";
            }
            else if (radioButtonParametric.Checked)
            {
                sqlSelect = "SELECT ID, Фамилия, Имя, Отчество, Дата_рождения, Статус FROM Игрок WHERE ID = @Id";
            }
            else
            {
                MessageBox.Show("Выберите тип запроса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewSelect.DataSource = FillDataGridView(sqlSelect, parameters);
            if (dataGridViewSelect.RowCount == 0)
                MessageBox.Show("Нет данных!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Укажите ID выплаты!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxNumber.Text, out int payoutId) || payoutId <= 0)
            {
                MessageBox.Show("ID выплаты должен быть положительным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlSelect = "";
            SqlParameter[] parameters = new[] { new SqlParameter("@PayoutId", payoutId) };

            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = @"SELECT Игрок.ID, Игрок.Фамилия, Игрок.Имя, Игрок.Отчество
                              FROM Игрок
                              WHERE EXISTS (
                                  SELECT 1 FROM Выплата
                                  INNER JOIN Ставка ON Выплата.ID_ставки = Ставка.ID_ставки
                                  WHERE Ставка.ID_игрока = Игрок.ID
                                  AND Выплата.ID_выплаты = @PayoutId
                              )";
            }
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"SELECT Игрок.ID, Игрок.Фамилия, Игрок.Имя, Игрок.Отчество
                              FROM Игрок
                              WHERE Игрок.ID IN (
                                  SELECT Ставка.ID_игрока
                                  FROM Выплата
                                  INNER JOIN Ставка ON Выплата.ID_ставки = Ставка.ID_ставки
                                  WHERE Выплата.ID_выплаты = @PayoutId
                              )";
            }
            else
            {
                MessageBox.Show("Выберите тип подзапроса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewSubquery.DataSource = FillDataGridView(sqlSelect, parameters);
            if (dataGridViewSubquery.RowCount == 0)
                MessageBox.Show("Нет данных!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxId.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID игрока должен быть положительным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string surname = textBoxSurname.Text;
            string name = textBoxId.Text;
            string patronymic = textBoxPatronymic.Text;
            if (!DateTime.TryParse(textBoxDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Дата рождения должна быть в формате дд.мм.гггг!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DateTime.Now.Year - birthDate.Year < 18)
            {
                MessageBox.Show("Игрок должен быть старше 18 лет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isVip = checkBoxVip.Checked;

            if (radioButtonInsert.Checked)
                InsertPlayer(id, surname, name, patronymic, birthDate, isVip);
            else if (radioButtonUpdate.Checked)
                UpdatePlayer(id, surname, name, patronymic, birthDate, isVip);
            else if (radioButtonDelete.Checked)
                DeletePlayer(id);
            else
                MessageBox.Show("Выберите действие!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InsertPlayer(int id, string surname, string name, string patronymic, DateTime birthDate, bool isVip)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Укажите имя игрока!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO Игрок (ID, Фамилия, Имя, Отчество, Дата_рождения, Статус, Фото_игрока)
                                VALUES (@Id, @Surname, @Name, @Patronymic, @BirthDate, @Status, @Photo)";
            try
            {
                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Surname", string.IsNullOrEmpty(surname) ? (object)DBNull.Value : (object)surname);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Patronymic", string.IsNullOrEmpty(patronymic) ? (object)DBNull.Value : (object)patronymic);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@Status", isVip);
                    command.Parameters.AddWithValue("@Photo", string.IsNullOrEmpty(photoPath) ? (object)DBNull.Value : (object)File.ReadAllBytes(photoPath));

                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Игрок добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Ошибка: Игрок с таким ID уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Ошибка добавления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            RefreshDMLGrid();
        }

        private void UpdatePlayer(int id, string surname, string name, string patronymic, DateTime birthDate, bool isVip)
        {
            string sqlUpdate = @"UPDATE Игрок SET Фамилия = @Surname, Имя = @Name, Отчество = @Patronymic, 
                                Дата_рождения = @BirthDate, Статус = @Status, Фото_игрока = @Photo 
                                WHERE ID = @Id";
            try
            {
                using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Surname", string.IsNullOrEmpty(surname) ? (object)DBNull.Value : (object)surname);
                    command.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(name) ? (object)DBNull.Value : (object)name);
                    command.Parameters.AddWithValue("@Patronymic", string.IsNullOrEmpty(patronymic) ? (object)DBNull.Value : (object)patronymic);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@Status", isVip);
                    command.Parameters.AddWithValue("@Photo", string.IsNullOrEmpty(photoPath) ? (object)DBNull.Value : (object)File.ReadAllBytes(photoPath));

                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные игрока обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            RefreshDMLGrid();
        }

        private void DeletePlayer(int id)
        {
            string sqlDelete = "DELETE FROM Игрок WHERE ID = @Id";
            try
            {
                using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Игрок удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Ошибка: Нельзя удалить игрока, так как он связан с другими данными (например, ставками).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            RefreshDMLGrid();
        }

        private void RefreshDMLGrid()
        {
            try
            {
                playersTable.Clear();
                adapter.Fill(playersTable);
                dataGridViewDML.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления таблицы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
