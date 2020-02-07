namespace StudentsDB
{
    partial class Form5
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
            System.Windows.Forms.Label кодСтудентаLabel;
            System.Windows.Forms.Label датаЭкзамена1Label;
            System.Windows.Forms.Label кодПредмета1Label;
            System.Windows.Forms.Label оценка1Label;
            System.Windows.Forms.Label датаЭкзамена2Label;
            System.Windows.Forms.Label кодПредмета2Label;
            System.Windows.Forms.Label оценка2Label;
            System.Windows.Forms.Label датаЭкзамена3Label;
            System.Windows.Forms.Label кодПредмета3Label;
            System.Windows.Forms.Label оценка3Label;
            System.Windows.Forms.Label среднийБаллLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.zakharovDataSet = new StudentsDB.zakharovDataSet();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new StudentsDB.zakharovDataSetTableAdapters.ОценкиTableAdapter();
            this.tableAdapterManager = new StudentsDB.zakharovDataSetTableAdapters.TableAdapterManager();
            this.оценкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.оценкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодСтудентаTextBox = new System.Windows.Forms.TextBox();
            this.датаЭкзамена1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодПредмета1TextBox = new System.Windows.Forms.TextBox();
            this.оценка1TextBox = new System.Windows.Forms.TextBox();
            this.датаЭкзамена2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодПредмета2TextBox = new System.Windows.Forms.TextBox();
            this.оценка2TextBox = new System.Windows.Forms.TextBox();
            this.датаЭкзамена3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодПредмета3TextBox = new System.Windows.Forms.TextBox();
            this.оценка3TextBox = new System.Windows.Forms.TextBox();
            this.среднийБаллTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            кодСтудентаLabel = new System.Windows.Forms.Label();
            датаЭкзамена1Label = new System.Windows.Forms.Label();
            кодПредмета1Label = new System.Windows.Forms.Label();
            оценка1Label = new System.Windows.Forms.Label();
            датаЭкзамена2Label = new System.Windows.Forms.Label();
            кодПредмета2Label = new System.Windows.Forms.Label();
            оценка2Label = new System.Windows.Forms.Label();
            датаЭкзамена3Label = new System.Windows.Forms.Label();
            кодПредмета3Label = new System.Windows.Forms.Label();
            оценка3Label = new System.Windows.Forms.Label();
            среднийБаллLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zakharovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).BeginInit();
            this.оценкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодСтудентаLabel
            // 
            кодСтудентаLabel.AutoSize = true;
            кодСтудентаLabel.Location = new System.Drawing.Point(93, 107);
            кодСтудентаLabel.Name = "кодСтудентаLabel";
            кодСтудентаLabel.Size = new System.Drawing.Size(78, 13);
            кодСтудентаLabel.TabIndex = 4;
            кодСтудентаLabel.Text = "Код Студента:";
            // 
            // датаЭкзамена1Label
            // 
            датаЭкзамена1Label.AutoSize = true;
            датаЭкзамена1Label.Location = new System.Drawing.Point(38, 137);
            датаЭкзамена1Label.Name = "датаЭкзамена1Label";
            датаЭкзамена1Label.Size = new System.Drawing.Size(133, 13);
            датаЭкзамена1Label.TabIndex = 5;
            датаЭкзамена1Label.Text = "Дата первого экзамена:";
            // 
            // кодПредмета1Label
            // 
            кодПредмета1Label.AutoSize = true;
            кодПредмета1Label.Location = new System.Drawing.Point(46, 163);
            кодПредмета1Label.Name = "кодПредмета1Label";
            кодПредмета1Label.Size = new System.Drawing.Size(125, 13);
            кодПредмета1Label.TabIndex = 6;
            кодПредмета1Label.Text = "Код первого предмета:";
            // 
            // оценка1Label
            // 
            оценка1Label.AutoSize = true;
            оценка1Label.Location = new System.Drawing.Point(5, 190);
            оценка1Label.Name = "оценка1Label";
            оценка1Label.Size = new System.Drawing.Size(166, 13);
            оценка1Label.TabIndex = 8;
            оценка1Label.Text = "Оценка по первому экзаменту:";
            // 
            // датаЭкзамена2Label
            // 
            датаЭкзамена2Label.AutoSize = true;
            датаЭкзамена2Label.Location = new System.Drawing.Point(38, 214);
            датаЭкзамена2Label.Name = "датаЭкзамена2Label";
            датаЭкзамена2Label.Size = new System.Drawing.Size(132, 13);
            датаЭкзамена2Label.TabIndex = 10;
            датаЭкзамена2Label.Text = "Дата второго экзамена:";
            // 
            // кодПредмета2Label
            // 
            кодПредмета2Label.AutoSize = true;
            кодПредмета2Label.Location = new System.Drawing.Point(46, 239);
            кодПредмета2Label.Name = "кодПредмета2Label";
            кодПредмета2Label.Size = new System.Drawing.Size(124, 13);
            кодПредмета2Label.TabIndex = 12;
            кодПредмета2Label.Text = "Код второго предмета:";
            // 
            // оценка2Label
            // 
            оценка2Label.AutoSize = true;
            оценка2Label.Location = new System.Drawing.Point(7, 265);
            оценка2Label.Name = "оценка2Label";
            оценка2Label.Size = new System.Drawing.Size(165, 13);
            оценка2Label.TabIndex = 14;
            оценка2Label.Text = "Оценка по второму экзаменту:";
            // 
            // датаЭкзамена3Label
            // 
            датаЭкзамена3Label.AutoSize = true;
            датаЭкзамена3Label.Location = new System.Drawing.Point(34, 292);
            датаЭкзамена3Label.Name = "датаЭкзамена3Label";
            датаЭкзамена3Label.Size = new System.Drawing.Size(137, 13);
            датаЭкзамена3Label.TabIndex = 16;
            датаЭкзамена3Label.Text = "Дата третьего экзамена:";
            // 
            // кодПредмета3Label
            // 
            кодПредмета3Label.AutoSize = true;
            кодПредмета3Label.Location = new System.Drawing.Point(42, 317);
            кодПредмета3Label.Name = "кодПредмета3Label";
            кодПредмета3Label.Size = new System.Drawing.Size(129, 13);
            кодПредмета3Label.TabIndex = 18;
            кодПредмета3Label.Text = "Код третьего предмета:";
            // 
            // оценка3Label
            // 
            оценка3Label.AutoSize = true;
            оценка3Label.Location = new System.Drawing.Point(1, 343);
            оценка3Label.Name = "оценка3Label";
            оценка3Label.Size = new System.Drawing.Size(170, 13);
            оценка3Label.TabIndex = 20;
            оценка3Label.Text = "Оценка по третьему экзаменту:";
            // 
            // среднийБаллLabel
            // 
            среднийБаллLabel.AutoSize = true;
            среднийБаллLabel.Location = new System.Drawing.Point(92, 370);
            среднийБаллLabel.Name = "среднийБаллLabel";
            среднийБаллLabel.Size = new System.Drawing.Size(78, 13);
            среднийБаллLabel.TabIndex = 22;
            среднийБаллLabel.Text = "Средний Балл";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Оценки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zakharovDataSet
            // 
            this.zakharovDataSet.DataSetName = "zakharovDataSet";
            this.zakharovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.zakharovDataSet;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = StudentsDB.zakharovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = this.оценкиTableAdapter;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = null;
            // 
            // оценкиBindingNavigator
            // 
            this.оценкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оценкиBindingNavigator.BindingSource = this.оценкиBindingSource;
            this.оценкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оценкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оценкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.оценкиBindingNavigatorSaveItem});
            this.оценкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оценкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оценкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оценкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оценкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оценкиBindingNavigator.Name = "оценкиBindingNavigator";
            this.оценкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оценкиBindingNavigator.Size = new System.Drawing.Size(444, 25);
            this.оценкиBindingNavigator.TabIndex = 4;
            this.оценкиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // оценкиBindingNavigatorSaveItem
            // 
            this.оценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оценкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оценкиBindingNavigatorSaveItem.Image")));
            this.оценкиBindingNavigatorSaveItem.Name = "оценкиBindingNavigatorSaveItem";
            this.оценкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.оценкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оценкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.оценкиBindingNavigatorSaveItem_Click);
            // 
            // кодСтудентаTextBox
            // 
            this.кодСтудентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "КодСтудента", true));
            this.кодСтудентаTextBox.Location = new System.Drawing.Point(177, 104);
            this.кодСтудентаTextBox.Name = "кодСтудентаTextBox";
            this.кодСтудентаTextBox.Size = new System.Drawing.Size(125, 20);
            this.кодСтудентаTextBox.TabIndex = 5;
            // 
            // датаЭкзамена1DateTimePicker
            // 
            this.датаЭкзамена1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "ДатаЭкзамена1", true));
            this.датаЭкзамена1DateTimePicker.Location = new System.Drawing.Point(177, 135);
            this.датаЭкзамена1DateTimePicker.Name = "датаЭкзамена1DateTimePicker";
            this.датаЭкзамена1DateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.датаЭкзамена1DateTimePicker.TabIndex = 6;
            // 
            // кодПредмета1TextBox
            // 
            this.кодПредмета1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "КодПредмета1", true));
            this.кодПредмета1TextBox.Location = new System.Drawing.Point(177, 160);
            this.кодПредмета1TextBox.Name = "кодПредмета1TextBox";
            this.кодПредмета1TextBox.Size = new System.Drawing.Size(123, 20);
            this.кодПредмета1TextBox.TabIndex = 7;
            // 
            // оценка1TextBox
            // 
            this.оценка1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка1", true));
            this.оценка1TextBox.Location = new System.Drawing.Point(177, 186);
            this.оценка1TextBox.Name = "оценка1TextBox";
            this.оценка1TextBox.Size = new System.Drawing.Size(123, 20);
            this.оценка1TextBox.TabIndex = 9;
            // 
            // датаЭкзамена2DateTimePicker
            // 
            this.датаЭкзамена2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "ДатаЭкзамена2", true));
            this.датаЭкзамена2DateTimePicker.Location = new System.Drawing.Point(178, 210);
            this.датаЭкзамена2DateTimePicker.Name = "датаЭкзамена2DateTimePicker";
            this.датаЭкзамена2DateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.датаЭкзамена2DateTimePicker.TabIndex = 11;
            // 
            // кодПредмета2TextBox
            // 
            this.кодПредмета2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "КодПредмета2", true));
            this.кодПредмета2TextBox.Location = new System.Drawing.Point(178, 235);
            this.кодПредмета2TextBox.Name = "кодПредмета2TextBox";
            this.кодПредмета2TextBox.Size = new System.Drawing.Size(123, 20);
            this.кодПредмета2TextBox.TabIndex = 13;
            // 
            // оценка2TextBox
            // 
            this.оценка2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка2", true));
            this.оценка2TextBox.Location = new System.Drawing.Point(178, 261);
            this.оценка2TextBox.Name = "оценка2TextBox";
            this.оценка2TextBox.Size = new System.Drawing.Size(123, 20);
            this.оценка2TextBox.TabIndex = 15;
            // 
            // датаЭкзамена3DateTimePicker
            // 
            this.датаЭкзамена3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оценкиBindingSource, "ДатаЭкзамена3", true));
            this.датаЭкзамена3DateTimePicker.Location = new System.Drawing.Point(177, 289);
            this.датаЭкзамена3DateTimePicker.Name = "датаЭкзамена3DateTimePicker";
            this.датаЭкзамена3DateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.датаЭкзамена3DateTimePicker.TabIndex = 17;
            // 
            // кодПредмета3TextBox
            // 
            this.кодПредмета3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "КодПредмета3", true));
            this.кодПредмета3TextBox.Location = new System.Drawing.Point(177, 314);
            this.кодПредмета3TextBox.Name = "кодПредмета3TextBox";
            this.кодПредмета3TextBox.Size = new System.Drawing.Size(123, 20);
            this.кодПредмета3TextBox.TabIndex = 19;
            // 
            // оценка3TextBox
            // 
            this.оценка3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "Оценка3", true));
            this.оценка3TextBox.Location = new System.Drawing.Point(177, 341);
            this.оценка3TextBox.Name = "оценка3TextBox";
            this.оценка3TextBox.Size = new System.Drawing.Size(123, 20);
            this.оценка3TextBox.TabIndex = 21;
            // 
            // среднийБаллTextBox
            // 
            this.среднийБаллTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оценкиBindingSource, "СреднийБалл", true));
            this.среднийБаллTextBox.Location = new System.Drawing.Point(177, 367);
            this.среднийБаллTextBox.Name = "среднийБаллTextBox";
            this.среднийБаллTextBox.Size = new System.Drawing.Size(125, 20);
            this.среднийБаллTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(среднийБаллLabel);
            this.Controls.Add(this.среднийБаллTextBox);
            this.Controls.Add(оценка3Label);
            this.Controls.Add(this.оценка3TextBox);
            this.Controls.Add(кодПредмета3Label);
            this.Controls.Add(this.кодПредмета3TextBox);
            this.Controls.Add(датаЭкзамена3Label);
            this.Controls.Add(this.датаЭкзамена3DateTimePicker);
            this.Controls.Add(оценка2Label);
            this.Controls.Add(this.оценка2TextBox);
            this.Controls.Add(кодПредмета2Label);
            this.Controls.Add(this.кодПредмета2TextBox);
            this.Controls.Add(датаЭкзамена2Label);
            this.Controls.Add(this.датаЭкзамена2DateTimePicker);
            this.Controls.Add(оценка1Label);
            this.Controls.Add(this.оценка1TextBox);
            this.Controls.Add(кодПредмета1Label);
            this.Controls.Add(this.кодПредмета1TextBox);
            this.Controls.Add(датаЭкзамена1Label);
            this.Controls.Add(this.датаЭкзамена1DateTimePicker);
            this.Controls.Add(кодСтудентаLabel);
            this.Controls.Add(this.кодСтудентаTextBox);
            this.Controls.Add(this.оценкиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Таблица оценки";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakharovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingNavigator)).EndInit();
            this.оценкиBindingNavigator.ResumeLayout(false);
            this.оценкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private zakharovDataSet zakharovDataSet;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private zakharovDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private zakharovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оценкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton оценкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодСтудентаTextBox;
        private System.Windows.Forms.DateTimePicker датаЭкзамена1DateTimePicker;
        private System.Windows.Forms.TextBox кодПредмета1TextBox;
        private System.Windows.Forms.TextBox оценка1TextBox;
        private System.Windows.Forms.DateTimePicker датаЭкзамена2DateTimePicker;
        private System.Windows.Forms.TextBox кодПредмета2TextBox;
        private System.Windows.Forms.TextBox оценка2TextBox;
        private System.Windows.Forms.DateTimePicker датаЭкзамена3DateTimePicker;
        private System.Windows.Forms.TextBox кодПредмета3TextBox;
        private System.Windows.Forms.TextBox оценка3TextBox;
        private System.Windows.Forms.TextBox среднийБаллTextBox;
        private System.Windows.Forms.Button button1;
    }
}