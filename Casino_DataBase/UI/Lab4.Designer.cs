namespace Casino_DataBase.UI
{
    partial class Lab4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.buttonExecuteSelect = new System.Windows.Forms.Button();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.textBoxParam = new System.Windows.Forms.TextBox();
            this.labelParam = new System.Windows.Forms.Label();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonParametric = new System.Windows.Forms.RadioButton();
            this.radioButtonFullSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonAggregate = new System.Windows.Forms.RadioButton();
            this.radioButtonMultipleTables = new System.Windows.Forms.RadioButton();
            this.radioButtonWithConditions = new System.Windows.Forms.RadioButton();
            this.radioButtonOneTable = new System.Windows.Forms.RadioButton();
            this.TabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.dataGridViewDML = new System.Windows.Forms.DataGridView();
            this.casinoDataSet = new Casino_DataBase.CasinoDataSet();
            this.casinoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.checkBoxVip = new System.Windows.Forms.CheckBox();
            this.tabControlSQL.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.TabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.TabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            this.tabControlSQL.SelectedIndexChanged += new System.EventHandler(this.tabControlSQL_SelectedIndexChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.buttonExecuteSelect);
            this.tabPageSelect.Controls.Add(this.dataGridViewSelect);
            this.tabPageSelect.Controls.Add(this.textBoxParam);
            this.tabPageSelect.Controls.Add(this.labelParam);
            this.tabPageSelect.Controls.Add(this.groupBoxSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 0;
            this.tabPageSelect.Text = "Запросы на Выборку";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            this.tabPageSelect.Click += new System.EventHandler(this.tabPageSelect_Click);
            // 
            // buttonExecuteSelect
            // 
            this.buttonExecuteSelect.Location = new System.Drawing.Point(228, 48);
            this.buttonExecuteSelect.Name = "buttonExecuteSelect";
            this.buttonExecuteSelect.Size = new System.Drawing.Size(148, 31);
            this.buttonExecuteSelect.TabIndex = 4;
            this.buttonExecuteSelect.Text = "Выполнить запрос";
            this.buttonExecuteSelect.UseVisualStyleBackColor = true;
            this.buttonExecuteSelect.Click += new System.EventHandler(this.buttonExecuteSelect_Click);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(8, 175);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(642, 173);
            this.dataGridViewSelect.TabIndex = 3;
            this.dataGridViewSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelect_CellContentClick);
            // 
            // textBoxParam
            // 
            this.textBoxParam.Location = new System.Drawing.Point(276, 15);
            this.textBoxParam.Name = "textBoxParam";
            this.textBoxParam.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam.TabIndex = 2;
            this.textBoxParam.TextChanged += new System.EventHandler(this.buttonExecuteSelect_TextChanged);
            // 
            // labelParam
            // 
            this.labelParam.AutoSize = true;
            this.labelParam.Location = new System.Drawing.Point(214, 15);
            this.labelParam.Name = "labelParam";
            this.labelParam.Size = new System.Drawing.Size(56, 13);
            this.labelParam.TabIndex = 1;
            this.labelParam.Text = "ID игрока";
            this.labelParam.Click += new System.EventHandler(this.labelParam_Click);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonParametric);
            this.groupBoxSelect.Controls.Add(this.radioButtonFullSelect);
            this.groupBoxSelect.Controls.Add(this.radioButtonAggregate);
            this.groupBoxSelect.Controls.Add(this.radioButtonMultipleTables);
            this.groupBoxSelect.Controls.Add(this.radioButtonWithConditions);
            this.groupBoxSelect.Controls.Add(this.radioButtonOneTable);
            this.groupBoxSelect.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(200, 163);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Выборка данных";
            this.groupBoxSelect.Enter += new System.EventHandler(this.groupBoxSelect_Enter);
            // 
            // radioButtonParametric
            // 
            this.radioButtonParametric.AutoSize = true;
            this.radioButtonParametric.Location = new System.Drawing.Point(6, 134);
            this.radioButtonParametric.Name = "radioButtonParametric";
            this.radioButtonParametric.Size = new System.Drawing.Size(156, 17);
            this.radioButtonParametric.TabIndex = 5;
            this.radioButtonParametric.TabStop = true;
            this.radioButtonParametric.Text = "Параметрический запрос";
            this.radioButtonParametric.UseVisualStyleBackColor = true;
            this.radioButtonParametric.CheckedChanged += new System.EventHandler(this.radioButtonParametric_CheckedChanged);
            // 
            // radioButtonFullSelect
            // 
            this.radioButtonFullSelect.AutoSize = true;
            this.radioButtonFullSelect.Location = new System.Drawing.Point(6, 111);
            this.radioButtonFullSelect.Name = "radioButtonFullSelect";
            this.radioButtonFullSelect.Size = new System.Drawing.Size(109, 17);
            this.radioButtonFullSelect.TabIndex = 4;
            this.radioButtonFullSelect.TabStop = true;
            this.radioButtonFullSelect.Text = "Полный SELECT";
            this.radioButtonFullSelect.UseVisualStyleBackColor = true;
            this.radioButtonFullSelect.CheckedChanged += new System.EventHandler(this.radioButtonFullSelect_CheckedChanged);
            // 
            // radioButtonAggregate
            // 
            this.radioButtonAggregate.AutoSize = true;
            this.radioButtonAggregate.Location = new System.Drawing.Point(6, 88);
            this.radioButtonAggregate.Name = "radioButtonAggregate";
            this.radioButtonAggregate.Size = new System.Drawing.Size(146, 17);
            this.radioButtonAggregate.TabIndex = 3;
            this.radioButtonAggregate.TabStop = true;
            this.radioButtonAggregate.Text = "Агрегирующие функции";
            this.radioButtonAggregate.UseVisualStyleBackColor = true;
            this.radioButtonAggregate.CheckedChanged += new System.EventHandler(this.radioButtonAggregate_CheckedChanged);
            // 
            // radioButtonMultipleTables
            // 
            this.radioButtonMultipleTables.AutoSize = true;
            this.radioButtonMultipleTables.Location = new System.Drawing.Point(6, 65);
            this.radioButtonMultipleTables.Name = "radioButtonMultipleTables";
            this.radioButtonMultipleTables.Size = new System.Drawing.Size(119, 17);
            this.radioButtonMultipleTables.TabIndex = 2;
            this.radioButtonMultipleTables.TabStop = true;
            this.radioButtonMultipleTables.Text = "Несколько таблиц";
            this.radioButtonMultipleTables.UseVisualStyleBackColor = true;
            this.radioButtonMultipleTables.CheckedChanged += new System.EventHandler(this.radioButtonMultipleTables_CheckedChanged);
            // 
            // radioButtonWithConditions
            // 
            this.radioButtonWithConditions.AutoSize = true;
            this.radioButtonWithConditions.Location = new System.Drawing.Point(6, 42);
            this.radioButtonWithConditions.Name = "radioButtonWithConditions";
            this.radioButtonWithConditions.Size = new System.Drawing.Size(90, 17);
            this.radioButtonWithConditions.TabIndex = 1;
            this.radioButtonWithConditions.TabStop = true;
            this.radioButtonWithConditions.Text = "С условиями";
            this.radioButtonWithConditions.UseVisualStyleBackColor = true;
            this.radioButtonWithConditions.CheckedChanged += new System.EventHandler(this.radioButtonWithConditions_CheckedChanged);
            // 
            // radioButtonOneTable
            // 
            this.radioButtonOneTable.AutoSize = true;
            this.radioButtonOneTable.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOneTable.Name = "radioButtonOneTable";
            this.radioButtonOneTable.Size = new System.Drawing.Size(95, 17);
            this.radioButtonOneTable.TabIndex = 0;
            this.radioButtonOneTable.TabStop = true;
            this.radioButtonOneTable.Text = "Одна таблица";
            this.radioButtonOneTable.UseVisualStyleBackColor = true;
            this.radioButtonOneTable.CheckedChanged += new System.EventHandler(this.radioButtonOneTable_CheckedChanged);
            // 
            // TabPageSubquery
            // 
            this.TabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.TabPageSubquery.Controls.Add(this.buttonSubquery);
            this.TabPageSubquery.Controls.Add(this.textBoxNumber);
            this.TabPageSubquery.Controls.Add(this.labelNumber);
            this.TabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.TabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.TabPageSubquery.Name = "TabPageSubquery";
            this.TabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.TabPageSubquery.TabIndex = 1;
            this.TabPageSubquery.Text = "Подзапросы";
            this.TabPageSubquery.UseVisualStyleBackColor = true;
            this.TabPageSubquery.Click += new System.EventHandler(this.TabPageSubquery_Click);
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(8, 113);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(651, 150);
            this.dataGridViewSubquery.TabIndex = 6;
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(242, 48);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(194, 31);
            this.buttonSubquery.TabIndex = 5;
            this.buttonSubquery.Text = "Выполнить запрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(336, 15);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 2;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(239, 15);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "ID выплаты";
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(225, 73);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(6, 42);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonExecuteDML);
            this.tabPageDML.Controls.Add(this.panelPlayer);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Controls.Add(this.dataGridViewDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 2;
            this.tabPageDML.Text = "Изменение данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            this.tabPageDML.Click += new System.EventHandler(this.tabPageDML_Click);
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(8, 266);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(148, 31);
            this.buttonExecuteDML.TabIndex = 7;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.checkBoxVip);
            this.panelPlayer.Controls.Add(this.textBoxName);
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.label3);
            this.panelPlayer.Controls.Add(this.textBoxId);
            this.panelPlayer.Controls.Add(this.label4);
            this.panelPlayer.Controls.Add(this.labelId);
            this.panelPlayer.Controls.Add(this.textBoxDate);
            this.panelPlayer.Controls.Add(this.label5);
            this.panelPlayer.Controls.Add(this.textBoxSurname);
            this.panelPlayer.Controls.Add(this.textBoxPatronymic);
            this.panelPlayer.Controls.Add(this.label6);
            this.panelPlayer.Location = new System.Drawing.Point(8, 112);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(447, 147);
            this.panelPlayer.TabIndex = 6;
            this.panelPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer_Paint);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(96, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(117, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(10, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(56, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID игрока";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.radioButtonDelete);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert);
            this.groupBoxDML.Location = new System.Drawing.Point(8, 6);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDML.TabIndex = 1;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(6, 65);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(106, 17);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить игрока";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(5, 42);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(114, 17);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить игрока";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(6, 19);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(113, 17);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Добавить игрока";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDML
            // 
            this.dataGridViewDML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDML.Location = new System.Drawing.Point(173, 266);
            this.dataGridViewDML.Name = "dataGridViewDML";
            this.dataGridViewDML.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewDML.TabIndex = 0;
            // 
            // casinoDataSet
            // 
            this.casinoDataSet.DataSetName = "CasinoDataSet";
            this.casinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casinoDataSetBindingSource
            // 
            this.casinoDataSetBindingSource.DataSource = this.casinoDataSet;
            this.casinoDataSetBindingSource.Position = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(117, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(323, 17);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(117, 20);
            this.textBoxDate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(219, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата рождения";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(96, 106);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(117, 20);
            this.textBoxPatronymic.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(219, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Статус";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(96, 74);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(117, 20);
            this.textBoxSurname.TabIndex = 11;
            // 
            // checkBoxVip
            // 
            this.checkBoxVip.AutoSize = true;
            this.checkBoxVip.Location = new System.Drawing.Point(323, 54);
            this.checkBoxVip.Name = "checkBoxVip";
            this.checkBoxVip.Size = new System.Drawing.Size(41, 17);
            this.checkBoxVip.TabIndex = 15;
            this.checkBoxVip.Text = "Vip";
            this.checkBoxVip.UseVisualStyleBackColor = true;
            // 
            // Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "Lab4";
            this.Text = "Lab4";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.TabPageSubquery.ResumeLayout(false);
            this.TabPageSubquery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabPage TabPageSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonMultipleTables;
        private System.Windows.Forms.RadioButton radioButtonWithConditions;
        private System.Windows.Forms.RadioButton radioButtonOneTable;
        private System.Windows.Forms.RadioButton radioButtonParametric;
        private System.Windows.Forms.RadioButton radioButtonFullSelect;
        private System.Windows.Forms.RadioButton radioButtonAggregate;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.TextBox textBoxParam;
        private System.Windows.Forms.Label labelParam;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.Button buttonExecuteSelect;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.DataGridView dataGridViewDML;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.BindingSource casinoDataSetBindingSource;
        private CasinoDataSet casinoDataSet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxVip;
    }
}