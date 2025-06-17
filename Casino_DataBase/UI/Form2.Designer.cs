namespace Casino_DataBase.UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.casinoDataSet = new Casino_DataBase.CasinoDataSet();
            this.игрокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.игрокTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.ИгрокTableAdapter();
            this.tableAdapterManager = new Casino_DataBase.CasinoDataSetTableAdapters.TableAdapterManager();
            this.данные_о_текущей_игреTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.Данные_о_текущей_игреTableAdapter();
            this.играTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.ИграTableAdapter();
            this.ставкаTableAdapter = new Casino_DataBase.CasinoDataSetTableAdapters.СтавкаTableAdapter();
            this.игрокBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.игрокBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статусCheckBox = new System.Windows.Forms.CheckBox();
            this.фото_игрокаTextBox = new System.Windows.Forms.TextBox();
            this.totalBetsTextBox = new System.Windows.Forms.TextBox();
            this.играBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.играDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данные_о_текущей_игреBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.данные_о_текущей_игреDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            iDLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            фото_игрокаLabel = new System.Windows.Forms.Label();
            общая_сумма_ставокLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).BeginInit();
            this.игрокBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.играBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.играDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(28, 28);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(28, 60);
            фамилияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(28, 92);
            имяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(28, 124);
            отчествоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(28, 158);
            дата_рожденияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(109, 16);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(28, 191);
            статусLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(56, 16);
            статусLabel.TabIndex = 11;
            статусLabel.Text = "Статус:";
            // 
            // фото_игрокаLabel
            // 
            фото_игрокаLabel.AutoSize = true;
            фото_игрокаLabel.Location = new System.Drawing.Point(28, 225);
            фото_игрокаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фото_игрокаLabel.Name = "фото_игрокаLabel";
            фото_игрокаLabel.Size = new System.Drawing.Size(92, 16);
            фото_игрокаLabel.TabIndex = 13;
            фото_игрокаLabel.Text = "Фото игрока:";
            // 
            // общая_сумма_ставокLabel
            // 
            общая_сумма_ставокLabel.AutoSize = true;
            общая_сумма_ставокLabel.Location = new System.Drawing.Point(28, 257);
            общая_сумма_ставокLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            общая_сумма_ставокLabel.Name = "общая_сумма_ставокLabel";
            общая_сумма_ставокLabel.Size = new System.Drawing.Size(144, 16);
            общая_сумма_ставокLabel.TabIndex = 15;
            общая_сумма_ставокLabel.Text = "Общая сумма ставок:";
            // 
            // casinoDataSet
            // 
            this.casinoDataSet.DataSetName = "CasinoDataSet";
            this.casinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // игрокBindingSource
            // 
            this.игрокBindingSource.DataMember = "Игрок";
            this.игрокBindingSource.DataSource = this.casinoDataSet;
            // 
            // игрокTableAdapter
            // 
            this.игрокTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Casino_DataBase.CasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыплатаTableAdapter = null;
            this.tableAdapterManager.Данные_о_текущей_игреTableAdapter = this.данные_о_текущей_игреTableAdapter;
            this.tableAdapterManager.ИграTableAdapter = this.играTableAdapter;
            this.tableAdapterManager.ИгрокTableAdapter = this.игрокTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.СтавкаTableAdapter = this.ставкаTableAdapter;
            // 
            // данные_о_текущей_игреTableAdapter
            // 
            this.данные_о_текущей_игреTableAdapter.ClearBeforeFill = true;
            // 
            // играTableAdapter
            // 
            this.играTableAdapter.ClearBeforeFill = true;
            // 
            // ставкаTableAdapter
            // 
            this.ставкаTableAdapter.ClearBeforeFill = true;
            // 
            // игрокBindingNavigator
            // 
            this.игрокBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.игрокBindingNavigator.BindingSource = this.игрокBindingSource;
            this.игрокBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.игрокBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.игрокBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.игрокBindingNavigator.Size = new System.Drawing.Size(1125, 27);
            this.игрокBindingNavigator.TabIndex = 0;
            this.игрокBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // игрокBindingNavigatorSaveItem
            // 
            this.игрокBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.игрокBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("игрокBindingNavigatorSaveItem.Image")));
            this.игрокBindingNavigatorSaveItem.Name = "игрокBindingNavigatorSaveItem";
            this.игрокBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.игрокBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.игрокBindingNavigatorSaveItem.Click += new System.EventHandler(this.игрокBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(195, 25);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(265, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(195, 57);
            this.фамилияTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(265, 22);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(195, 89);
            this.имяTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(265, 22);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(195, 121);
            this.отчествоTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(265, 22);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.игрокBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(195, 153);
            this.дата_рожденияDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 10;
            // 
            // статусCheckBox
            // 
            this.статусCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.игрокBindingSource, "Статус", true));
            this.статусCheckBox.Location = new System.Drawing.Point(195, 185);
            this.статусCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.статусCheckBox.Name = "статусCheckBox";
            this.статусCheckBox.Size = new System.Drawing.Size(267, 30);
            this.статусCheckBox.TabIndex = 12;
            this.статусCheckBox.Text = "Vip";
            this.статусCheckBox.UseVisualStyleBackColor = true;
            // 
            // фото_игрокаTextBox
            // 
            this.фото_игрокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Фото_игрока", true));
            this.фото_игрокаTextBox.Location = new System.Drawing.Point(195, 222);
            this.фото_игрокаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.фото_игрокаTextBox.Name = "фото_игрокаTextBox";
            this.фото_игрокаTextBox.Size = new System.Drawing.Size(265, 22);
            this.фото_игрокаTextBox.TabIndex = 14;
            // 
            // totalBetsTextBox
            // 
            this.totalBetsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Общая_сумма_ставок", true));
            this.totalBetsTextBox.Location = new System.Drawing.Point(195, 254);
            this.totalBetsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalBetsTextBox.Name = "totalBetsTextBox";
            this.totalBetsTextBox.Size = new System.Drawing.Size(265, 22);
            this.totalBetsTextBox.TabIndex = 16;
            // 
            // играBindingSource
            // 
            this.играBindingSource.DataMember = "Игра";
            this.играBindingSource.DataSource = this.casinoDataSet;
            // 
            // играDataGridView
            // 
            this.играDataGridView.AutoGenerateColumns = false;
            this.играDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.играDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.играDataGridView.DataSource = this.играBindingSource;
            this.играDataGridView.Location = new System.Drawing.Point(8, 26);
            this.играDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.играDataGridView.Name = "играDataGridView";
            this.играDataGridView.RowHeadersWidth = 51;
            this.играDataGridView.Size = new System.Drawing.Size(465, 271);
            this.играDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_игры";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_игры";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Правила";
            this.dataGridViewTextBoxColumn3.HeaderText = "Правила";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // данные_о_текущей_игреBindingSource
            // 
            this.данные_о_текущей_игреBindingSource.DataMember = "Данные_о_текущей_игре";
            this.данные_о_текущей_игреBindingSource.DataSource = this.casinoDataSet;
            // 
            // данные_о_текущей_игреDataGridView
            // 
            this.данные_о_текущей_игреDataGridView.AutoGenerateColumns = false;
            this.данные_о_текущей_игреDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.данные_о_текущей_игреDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.данные_о_текущей_игреDataGridView.DataSource = this.данные_о_текущей_игреBindingSource;
            this.данные_о_текущей_игреDataGridView.Location = new System.Drawing.Point(1150, 53);
            this.данные_о_текущей_игреDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.данные_о_текущей_игреDataGridView.Name = "данные_о_текущей_игреDataGridView";
            this.данные_о_текущей_игреDataGridView.RowHeadersWidth = 51;
            this.данные_о_текущей_игреDataGridView.Size = new System.Drawing.Size(238, 271);
            this.данные_о_текущей_игреDataGridView.TabIndex = 18;
            this.данные_о_текущей_игреDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_данных";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_данных";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_время";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_время";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_игры";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_игры";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Результат_игры";
            this.dataGridViewTextBoxColumn7.HeaderText = "Результат_игры";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // ставкаBindingSource
            // 
            this.ставкаBindingSource.DataMember = "Ставка";
            this.ставкаBindingSource.DataSource = this.casinoDataSet;
            // 
            // ставкаDataGridView
            // 
            this.ставкаDataGridView.AutoGenerateColumns = false;
            this.ставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.ставкаDataGridView.DataSource = this.ставкаBindingSource;
            this.ставкаDataGridView.Location = new System.Drawing.Point(8, 26);
            this.ставкаDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ставкаDataGridView.Name = "ставкаDataGridView";
            this.ставкаDataGridView.RowHeadersWidth = 51;
            this.ставкаDataGridView.Size = new System.Drawing.Size(952, 271);
            this.ставкаDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_ставки";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_ставки";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Сумма";
            this.dataGridViewTextBoxColumn9.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Дата_время";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата_время";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_игрока";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID_игрока";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ID_сотрудника";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID_сотрудника";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ID_данных";
            this.dataGridViewTextBoxColumn13.HeaderText = "ID_данных";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.totalBetsTextBox);
            this.groupBox1.Controls.Add(общая_сумма_ставокLabel);
            this.groupBox1.Controls.Add(this.фото_игрокаTextBox);
            this.groupBox1.Controls.Add(фото_игрокаLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(this.статусCheckBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(статусLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(дата_рожденияLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(this.отчествоTextBox);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Location = new System.Drawing.Point(20, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(479, 299);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация об игроке";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.играDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(507, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(487, 299);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Связанные игры";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.ставкаDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(20, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(973, 304);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ставки игрока";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.данные_о_текущей_игреDataGridView);
            this.Controls.Add(this.игрокBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Связанные таблицы";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).EndInit();
            this.игрокBindingNavigator.ResumeLayout(false);
            this.игрокBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.играBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.играDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_текущей_игреDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CasinoDataSet casinoDataSet;
        private System.Windows.Forms.BindingSource игрокBindingSource;
        private CasinoDataSetTableAdapters.ИгрокTableAdapter игрокTableAdapter;
        private CasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator игрокBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton игрокBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.CheckBox статусCheckBox;
        private System.Windows.Forms.TextBox фото_игрокаTextBox;
        private System.Windows.Forms.TextBox totalBetsTextBox;
        private CasinoDataSetTableAdapters.ИграTableAdapter играTableAdapter;
        private System.Windows.Forms.BindingSource играBindingSource;
        private CasinoDataSetTableAdapters.Данные_о_текущей_игреTableAdapter данные_о_текущей_игреTableAdapter;
        private System.Windows.Forms.DataGridView играDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource данные_о_текущей_игреBindingSource;
        private CasinoDataSetTableAdapters.СтавкаTableAdapter ставкаTableAdapter;
        private System.Windows.Forms.DataGridView данные_о_текущей_игреDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource ставкаBindingSource;
        private System.Windows.Forms.DataGridView ставкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}