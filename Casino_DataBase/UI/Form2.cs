using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_DataBase.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void играBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.играBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.casinoDataSet);
        }

        private void игрокBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (игрокBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)игрокBindingSource.Current;
                int currentPlayerId = (int)currentRow["ID"];
                ставкаBindingSource.Filter = $"ID_игрока = {currentPlayerId}";

                var stakes = ставкаBindingSource.List
                    .Cast<DataRowView>()
                    .Where(s => (int)s["ID_игрока"] == currentPlayerId)
                    .Select(s => (int)s["ID_данных"])
                    .Distinct()
                    .ToArray();

                if (stakes.Length > 0)
                {
                    var gameDataRows = casinoDataSet.Данные_о_текущей_игре
                        .AsEnumerable()
                        .Where(d => stakes.Contains(d.Field<int>("ID_данных")))
                        .Select(d => d.Field<int>("ID_игры"))
                        .Distinct()
                        .ToArray();

                    if (gameDataRows.Length > 0)
                    {
                        string gameFilter = $"ID_игры IN ({string.Join(",", gameDataRows)})";
                        играBindingSource.Filter = gameFilter;
                    }
                    else
                    {
                        играBindingSource.Filter = "1=0"; 
                    }
                }
                else
                {
                    играBindingSource.Filter = "1=0";
                }

                decimal totalBets = casinoDataSet.Ставка.AsEnumerable()
                    .Where(s => s.Field<int>("ID_игрока") == currentPlayerId)
                    .Sum(s => s.Field<decimal>("Сумма"));
                currentRow["Общая_сумма_ставок"] = totalBets;
            }
            else
            {
                ставкаBindingSource.Filter = "";
                играBindingSource.Filter = "";
            }
        }

        private void игрокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.casinoDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "casinoDataSet.Ставка". При необходимости она может быть перемещена или удалена.
            this.ставкаTableAdapter.Fill(this.casinoDataSet.Ставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "casinoDataSet.Данные_о_текущей_игре". При необходимости она может быть перемещена или удалена.
            this.данные_о_текущей_игреTableAdapter.Fill(this.casinoDataSet.Данные_о_текущей_игре);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "casinoDataSet.Игра". При необходимости она может быть перемещена или удалена.
            this.играTableAdapter.Fill(this.casinoDataSet.Игра);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "casinoDataSet.Игрок". При необходимости она может быть перемещена или удалена.
            this.игрокTableAdapter.Fill(this.casinoDataSet.Игрок);

            totalBetsTextBox.DataBindings.Clear(); // Очищаем предыдущие привязки, чтобы избежать дублирования
            totalBetsTextBox.DataBindings.Add("Text", игрокBindingSource, "Общая_сумма_ставок", true, DataSourceUpdateMode.OnPropertyChanged, "0.00", "F2");

        }
    }
}
