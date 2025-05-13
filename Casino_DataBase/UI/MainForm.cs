using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casino_DataBase.UI;

namespace Casino_DataBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

            if (!e.Cancel)
            {
                Properties.Settings.Default.FormLocation = this.Location;
                Properties.Settings.Default.FormSize = this.Size;
                Properties.Settings.Default.Save();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КСУП, Рогозин Артем Константинович, Группа:573-3, 2025", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void игрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
        }

        private void игрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForm gamesForm = new GameForm();
            gamesForm.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void выплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayoutsForm payoutsForm = new PayoutsForm();
            payoutsForm.ShowDialog();
        }

        private void exitContextMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reloadContextMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обновление данных...", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitContextMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void reloadContextMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Обновление данных...", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Location = Properties.Settings.Default.FormLocation;
            this.Size = Properties.Settings.Default.FormSize;

            statusLabel.Text = "Подключено к базе Casino";
        }

        private void ставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetsForm betsForm = new BetsForm();
            betsForm.Show();
        }
        private void currentGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameDataForm gameDataForm = new GameDataForm();
            gameDataForm.Show();
        }
    }
}
