namespace Casino_DataBase.UI
{
    partial class RelatedTablesForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label фото_игрокаLabel;
            System.Windows.Forms.Label общая_сумма_ставокLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatedTablesForm));
            this.casinoDataSet = new Casino_DataBase.CasinoDataSet();
            this.tableAdapterManager = new Casino_DataBase.CasinoDataSetTableAdapters.TableAdapterManager();
            this.играTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.ИграTableAdapter();
            this.играBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.играDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.игрокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статусCheckBox = new System.Windows.Forms.CheckBox();
            this.фото_игрокаTextBox = new System.Windows.Forms.TextBox();
            this.totalBetsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ставкаTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.СтавкаTableAdapter();
            this.данные_о_текущей_игреBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.данные_о_текущей_игреTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.Данные_о_текущей_игреTableAdapter();
            this.данные_о_текущей_игреDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.игрокBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.игрокBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.игрокTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.ИгрокTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            фото_игрокаLabel = new System.Windows.Forms.Label();
            общая_сумма_ставокLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.играBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.играDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).BeginInit();
            this.игрокBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(16, 12);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(16, 38);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(16, 64);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(16, 90);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(16, 117);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 8;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(16, 144);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(44, 13);
            статусLabel.TabIndex = 10;
            статусLabel.Text = "Статус:";
            // 
            // фото_игрокаLabel
            // 
            фото_игрокаLabel.AutoSize = true;
            фото_игрокаLabel.Location = new System.Drawing.Point(16, 172);
            фото_игрокаLabel.Name = "фото_игрокаLabel";
            фото_игрокаLabel.Size = new System.Drawing.Size(76, 13);
            фото_игрокаLabel.TabIndex = 12;
            фото_игрокаLabel.Text = "Фото игрока:";
            // 
            // общая_сумма_ставокLabel
            // 
            общая_сумма_ставокLabel.AutoSize = true;
            общая_сумма_ставокLabel.Location = new System.Drawing.Point(16, 198);
            общая_сумма_ставокLabel.Name = "общая_сумма_ставокLabel";
            общая_сумма_ставокLabel.Size = new System.Drawing.Size(119, 13);
            общая_сумма_ставокLabel.TabIndex = 14;
            общая_сумма_ставокLabel.Text = "Общая сумма ставок:";
            // 
            // casinoDataSet
            // 
            this.casinoDataSet.DataSetName = "CasinoDataSet";
            this.casinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Casino_DataBase.CasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыплатаTableAdapter = null;
            this.tableAdapterManager.Данные_о_текущей_игреTableAdapter = null;
            this.tableAdapterManager.ИграTableAdapter = this.играTableAdapter;
            this.tableAdapterManager.ИгрокTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.СтавкаTableAdapter = null;
            // 
            // играTableAdapter
            // 
            this.играTableAdapter.ClearBeforeFill = true;
            // 
            // играBindingSource
            // 
            this.играBindingSource.DataMember = "Игра";
            this.играBindingSource.DataSource = this.casinoDataSet;
            // 
            // играDataGridView
            // 
            this.играDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.играDataGridView.AutoGenerateColumns = false;
            this.играDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.играDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.играDataGridView.DataSource = this.играBindingSource;
            this.играDataGridView.Location = new System.Drawing.Point(0, 0);
            this.играDataGridView.Name = "играDataGridView";
            this.играDataGridView.Size = new System.Drawing.Size(408, 246);
            this.играDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_игры";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_игры";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Правила";
            this.dataGridViewTextBoxColumn3.HeaderText = "Правила";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 267);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация об игроке";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox);
            this.panel1.Controls.Add(фамилияLabel);
            this.panel1.Controls.Add(this.фамилияTextBox);
            this.panel1.Controls.Add(имяLabel);
            this.panel1.Controls.Add(this.имяTextBox);
            this.panel1.Controls.Add(отчествоLabel);
            this.panel1.Controls.Add(this.отчествоTextBox);
            this.panel1.Controls.Add(дата_рожденияLabel);
            this.panel1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.panel1.Controls.Add(статусLabel);
            this.panel1.Controls.Add(this.статусCheckBox);
            this.panel1.Controls.Add(фото_игрокаLabel);
            this.panel1.Controls.Add(this.фото_игрокаTextBox);
            this.panel1.Controls.Add(общая_сумма_ставокLabel);
            this.panel1.Controls.Add(this.totalBetsTextBox);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 248);
            this.panel1.TabIndex = 18;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(141, 9);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // игрокBindingSource
            // 
            this.игрокBindingSource.DataMember = "Игрок";
            this.игрокBindingSource.DataSource = this.casinoDataSet;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(141, 35);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 20);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(141, 61);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 20);
            this.имяTextBox.TabIndex = 5;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(141, 87);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 20);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.игрокBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(141, 113);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 9;
            // 
            // статусCheckBox
            // 
            this.статусCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.игрокBindingSource, "Статус", true));
            this.статусCheckBox.Location = new System.Drawing.Point(141, 139);
            this.статусCheckBox.Name = "статусCheckBox";
            this.статусCheckBox.Size = new System.Drawing.Size(200, 24);
            this.статусCheckBox.TabIndex = 11;
            this.статусCheckBox.Text = "checkBox1";
            this.статусCheckBox.UseVisualStyleBackColor = true;
            // 
            // фото_игрокаTextBox
            // 
            this.фото_игрокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Фото_игрока", true));
            this.фото_игрокаTextBox.Location = new System.Drawing.Point(141, 169);
            this.фото_игрокаTextBox.Name = "фото_игрокаTextBox";
            this.фото_игрокаTextBox.Size = new System.Drawing.Size(200, 20);
            this.фото_игрокаTextBox.TabIndex = 13;
            // 
            // totalBetsTextBox
            // 
            this.totalBetsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Общая_сумма_ставок", true));
            this.totalBetsTextBox.Location = new System.Drawing.Point(141, 195);
            this.totalBetsTextBox.Name = "totalBetsTextBox";
            this.totalBetsTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalBetsTextBox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(396, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 267);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Связанные игры";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.играDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 248);
            this.panel2.TabIndex = 18;
            // 
            // ставкаTableAdapter
            // 
            this.ставкаTableAdapter.ClearBeforeFill = true;
            // 
            // данные_о_текущей_игреBindingSource
            // 
            this.данные_о_текущей_игреBindingSource.DataMember = "Данные_о_текущей_игре";
            this.данные_о_текущей_игреBindingSource.DataSource = this.casinoDataSet;
            // 
            // данные_о_текущей_игреTableAdapter
            // 
            this.данные_о_текущей_игреTableAdapter.ClearBeforeFill = true;
            // 
            // данные_о_текущей_игреDataGridView
            // 
            this.данные_о_текущей_игреDataGridView.AutoGenerateColumns = false;
            this.данные_о_текущей_игреDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.данные_о_текущей_игреDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.данные_о_текущей_игреDataGridView.DataSource = this.данные_о_текущей_игреBindingSource;
            this.данные_о_текущей_игреDataGridView.Enabled = false;
            this.данные_о_текущей_игреDataGridView.Location = new System.Drawing.Point(892, 69);
            this.данные_о_текущей_игреDataGridView.Name = "данные_о_текущей_игреDataGridView";
            this.данные_о_текущей_игреDataGridView.Size = new System.Drawing.Size(300, 220);
            this.данные_о_текущей_игреDataGridView.TabIndex = 17;
            this.данные_о_текущей_игреDataGridView.Visible = false;
            this.данные_о_текущей_игреDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.данные_о_текущей_игреDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ID_данных";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID_данных";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Дата_время";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата_время";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ID_игры";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID_игры";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Результат_игры";
            this.dataGridViewTextBoxColumn13.HeaderText = "Результат_игры";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ставкаDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(29, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 232);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ставки игрока";
            // 
            // ставкаDataGridView
            // 
            this.ставкаDataGridView.AutoGenerateColumns = false;
            this.ставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ставкаDataGridView.DataSource = this.ставкаBindingSource;
            this.ставкаDataGridView.Location = new System.Drawing.Point(15, 19);
            this.ставкаDataGridView.Name = "ставкаDataGridView";
            this.ставкаDataGridView.Size = new System.Drawing.Size(643, 207);
            this.ставкаDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_ставки";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_ставки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Сумма";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата_время";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата_время";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_игрока";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID_игрока";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_сотрудника";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_сотрудника";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_данных";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID_данных";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ставкаBindingSource
            // 
            this.ставкаBindingSource.DataMember = "Ставка";
            this.ставкаBindingSource.DataSource = this.casinoDataSet;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // игрокBindingNavigatorSaveItem
            // 
            this.игрокBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.игрокBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("игрокBindingNavigatorSaveItem.Image")));
            this.игрокBindingNavigatorSaveItem.Name = "игрокBindingNavigatorSaveItem";
            this.игрокBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.игрокBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.игрокBindingNavigatorSaveItem.Click += new System.EventHandler(this.игрокBindingNavigatorSaveItem_Click);
            // 
            // игрокBindingNavigator
            // 
            this.игрокBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.игрокBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.игрокBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.игрокBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.игрокBindingNavigatorSaveItem});
            this.игрокBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.игрокBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.игрокBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.игрокBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.игрокBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.игрокBindingNavigator.Name = "игрокBindingNavigator";
            this.игрокBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.игрокBindingNavigator.Size = new System.Drawing.Size(1033, 25);
            this.игрокBindingNavigator.TabIndex = 0;
            this.игрокBindingNavigator.Text = "bindingNavigator1";
            // 
            // игрокTableAdapter
            // 
            this.игрокTableAdapter.ClearBeforeFill = true;
            // 
            // RelatedTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.данные_о_текущей_игреDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.игрокBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatedTablesForm";
            this.Text = "Связанные таблицы";
            this.Load += new System.EventHandler(this.RelatedTablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.играBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.играDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).EndInit();
            this.игрокBindingNavigator.ResumeLayout(false);
            this.игрокBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CasinoDataSet casinoDataSet;
        private CasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CasinoDataSetTableAdapters.ИграTableAdapter играTableAdapter;
        private System.Windows.Forms.BindingSource играBindingSource;
        private System.Windows.Forms.DataGridView играDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CasinoDataSetTableAdapters.СтавкаTableAdapter ставкаTableAdapter;
        private System.Windows.Forms.BindingSource данные_о_текущей_игреBindingSource;
        private CasinoDataSetTableAdapters.Данные_о_текущей_игреTableAdapter данные_о_текущей_игреTableAdapter;
        private System.Windows.Forms.DataGridView данные_о_текущей_игреDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ставкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource ставкаBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton игрокBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator игрокBindingNavigator;
        private System.Windows.Forms.BindingSource игрокBindingSource;
        private CasinoDataSetTableAdapters.ИгрокTableAdapter игрокTableAdapter;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.CheckBox статусCheckBox;
        private System.Windows.Forms.TextBox фото_игрокаTextBox;
        private System.Windows.Forms.TextBox totalBetsTextBox;
    }
}