namespace Casino_DataBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(780, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игрокиToolStripMenuItem,
            this.игрыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.выплатыToolStripMenuItem,
            this.ставкиToolStripMenuItem,
            this.currentGameToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.выходToolStripMenuItem.Text = "Таблицы";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // игрокиToolStripMenuItem
            // 
            this.игрокиToolStripMenuItem.Name = "игрокиToolStripMenuItem";
            this.игрокиToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.игрокиToolStripMenuItem.Text = "Игроки";
            this.игрокиToolStripMenuItem.Click += new System.EventHandler(this.игрокиToolStripMenuItem_Click);
            // 
            // игрыToolStripMenuItem
            // 
            this.игрыToolStripMenuItem.Name = "игрыToolStripMenuItem";
            this.игрыToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.игрыToolStripMenuItem.Text = "Игры";
            this.игрыToolStripMenuItem.Click += new System.EventHandler(this.игрыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // выплатыToolStripMenuItem
            // 
            this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
            this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.выплатыToolStripMenuItem.Text = "Выплаты";
            this.выплатыToolStripMenuItem.Click += new System.EventHandler(this.выплатыToolStripMenuItem_Click);
            // 
            // ставкиToolStripMenuItem
            // 
            this.ставкиToolStripMenuItem.Name = "ставкиToolStripMenuItem";
            this.ставкиToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.ставкиToolStripMenuItem.Text = "Ставки";
            this.ставкиToolStripMenuItem.Click += new System.EventHandler(this.ставкиToolStripMenuItem_Click);
            // 
            // currentGameToolStripMenuItem
            // 
            this.currentGameToolStripMenuItem.Name = "currentGameToolStripMenuItem";
            this.currentGameToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.currentGameToolStripMenuItem.Text = "Данные о текущих играх";
            this.currentGameToolStripMenuItem.Click += new System.EventHandler(this.currentGameToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(780, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(249, 20);
            this.statusLabel.Text = "Подключено к базе данных Casino";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadContextMenuItem,
            this.addContextMenuItem,
            this.removeContextMenuItem,
            this.exitContextMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(133, 100);
            this.contextMenuStripMain.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // reloadContextMenuItem
            // 
            this.reloadContextMenuItem.Name = "reloadContextMenuItem";
            this.reloadContextMenuItem.Size = new System.Drawing.Size(132, 24);
            this.reloadContextMenuItem.Text = "Reload";
            this.reloadContextMenuItem.Click += new System.EventHandler(this.reloadContextMenuItem_Click_1);
            // 
            // addContextMenuItem
            // 
            this.addContextMenuItem.Name = "addContextMenuItem";
            this.addContextMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addContextMenuItem.Text = "Add";
            // 
            // removeContextMenuItem
            // 
            this.removeContextMenuItem.Name = "removeContextMenuItem";
            this.removeContextMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeContextMenuItem.Text = "Remove";
            // 
            // exitContextMenuItem
            // 
            this.exitContextMenuItem.Name = "exitContextMenuItem";
            this.exitContextMenuItem.Size = new System.Drawing.Size(132, 24);
            this.exitContextMenuItem.Text = "Exit";
            this.exitContextMenuItem.Click += new System.EventHandler(this.exitContextMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Казино:управление ставками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem игрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem reloadContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitContextMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem ставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentGameToolStripMenuItem;
    }
}

