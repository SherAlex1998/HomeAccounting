
namespace HomeAccounting
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.TopMenuAboutUsButton = new System.Windows.Forms.Label();
            this.OutcomePictogram = new System.Windows.Forms.PictureBox();
            this.IncomePictogram = new System.Windows.Forms.PictureBox();
            this.MiddleMenuPanel = new System.Windows.Forms.Panel();
            this.importPanel = new System.Windows.Forms.Panel();
            this.importIcon = new System.Windows.Forms.PictureBox();
            this.importLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.filtrPanel = new System.Windows.Forms.Panel();
            this.filterIcon = new System.Windows.Forms.PictureBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.categoryIcon = new System.Windows.Forms.PictureBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.InComePanel = new System.Windows.Forms.Panel();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.OutComePanel = new System.Windows.Forms.Panel();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Change = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPanel = new System.Windows.Forms.Panel();
            this.exportIcon = new System.Windows.Forms.PictureBox();
            this.exportLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutcomePictogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePictogram)).BeginInit();
            this.MiddleMenuPanel.SuspendLayout();
            this.importPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importIcon)).BeginInit();
            this.filtrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterIcon)).BeginInit();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIcon)).BeginInit();
            this.InComePanel.SuspendLayout();
            this.OutComePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.DataGridContextMenu.SuspendLayout();
            this.exportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopMenu.Controls.Add(this.HelpLabel);
            this.TopMenu.Controls.Add(this.TopMenuAboutUsButton);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1225, 23);
            this.TopMenu.TabIndex = 0;
            // 
            // TopMenuAboutUsButton
            // 
            this.TopMenuAboutUsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopMenuAboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TopMenuAboutUsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopMenuAboutUsButton.Location = new System.Drawing.Point(0, 0);
            this.TopMenuAboutUsButton.Name = "TopMenuAboutUsButton";
            this.TopMenuAboutUsButton.Size = new System.Drawing.Size(98, 23);
            this.TopMenuAboutUsButton.TabIndex = 0;
            this.TopMenuAboutUsButton.Text = "О программе";
            this.TopMenuAboutUsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMenuAboutUsButton.Click += new System.EventHandler(this.TopMenuAboutUsButton_Click);
            this.TopMenuAboutUsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuAboutUsButton_MouseDown);
            this.TopMenuAboutUsButton.MouseEnter += new System.EventHandler(this.TopMenuAboutUsButton_MouseEnter);
            this.TopMenuAboutUsButton.MouseLeave += new System.EventHandler(this.TopMenuAboutUsButton_MouseLeave);
            this.TopMenuAboutUsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopMenuAboutUsButton_MouseUp);
            // 
            // OutcomePictogram
            // 
            this.OutcomePictogram.Image = ((System.Drawing.Image)(resources.GetObject("OutcomePictogram.Image")));
            this.OutcomePictogram.Location = new System.Drawing.Point(0, 35);
            this.OutcomePictogram.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.OutcomePictogram.Name = "OutcomePictogram";
            this.OutcomePictogram.Size = new System.Drawing.Size(70, 70);
            this.OutcomePictogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutcomePictogram.TabIndex = 1;
            this.OutcomePictogram.TabStop = false;
            this.OutcomePictogram.Click += new System.EventHandler(this.OutComePanel_Click);
            this.OutcomePictogram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OutCome_MouseDown);
            this.OutcomePictogram.MouseEnter += new System.EventHandler(this.OutCome_MouseEnter);
            this.OutcomePictogram.MouseLeave += new System.EventHandler(this.OutCome_MouseLeave);
            this.OutcomePictogram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OutCome_MouseUp);
            // 
            // IncomePictogram
            // 
            this.IncomePictogram.Image = ((System.Drawing.Image)(resources.GetObject("IncomePictogram.Image")));
            this.IncomePictogram.Location = new System.Drawing.Point(0, 38);
            this.IncomePictogram.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.IncomePictogram.Name = "IncomePictogram";
            this.IncomePictogram.Size = new System.Drawing.Size(70, 70);
            this.IncomePictogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IncomePictogram.TabIndex = 2;
            this.IncomePictogram.TabStop = false;
            this.IncomePictogram.Click += new System.EventHandler(this.IncomePictogram_Click);
            this.IncomePictogram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InCome_MouseDown);
            this.IncomePictogram.MouseEnter += new System.EventHandler(this.InCome_MouseEnter);
            this.IncomePictogram.MouseLeave += new System.EventHandler(this.InCome_MouseLeave);
            this.IncomePictogram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InCome_MouseUp);
            // 
            // MiddleMenuPanel
            // 
            this.MiddleMenuPanel.Controls.Add(this.importPanel);
            this.MiddleMenuPanel.Controls.Add(this.periodLabel);
            this.MiddleMenuPanel.Controls.Add(this.dateTo);
            this.MiddleMenuPanel.Controls.Add(this.dateFrom);
            this.MiddleMenuPanel.Controls.Add(this.periodComboBox);
            this.MiddleMenuPanel.Controls.Add(this.filtrPanel);
            this.MiddleMenuPanel.Controls.Add(this.categoryPanel);
            this.MiddleMenuPanel.Controls.Add(this.InComePanel);
            this.MiddleMenuPanel.Controls.Add(this.OutComePanel);
            this.MiddleMenuPanel.Location = new System.Drawing.Point(0, 29);
            this.MiddleMenuPanel.Name = "MiddleMenuPanel";
            this.MiddleMenuPanel.Size = new System.Drawing.Size(1225, 115);
            this.MiddleMenuPanel.TabIndex = 3;
            // 
            // importPanel
            // 
            this.importPanel.Controls.Add(this.importIcon);
            this.importPanel.Controls.Add(this.importLabel);
            this.importPanel.Enabled = false;
            this.importPanel.Location = new System.Drawing.Point(368, 0);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(72, 115);
            this.importPanel.TabIndex = 12;
            this.importPanel.Visible = false;
            // 
            // importIcon
            // 
            this.importIcon.Enabled = false;
            this.importIcon.Image = ((System.Drawing.Image)(resources.GetObject("importIcon.Image")));
            this.importIcon.Location = new System.Drawing.Point(0, 38);
            this.importIcon.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.importIcon.Name = "importIcon";
            this.importIcon.Size = new System.Drawing.Size(69, 70);
            this.importIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.importIcon.TabIndex = 2;
            this.importIcon.TabStop = false;
            this.importIcon.Visible = false;
            this.importIcon.Click += new System.EventHandler(this.ImportPanel_Click);
            // 
            // importLabel
            // 
            this.importLabel.Enabled = false;
            this.importLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importLabel.Location = new System.Drawing.Point(0, 7);
            this.importLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(69, 31);
            this.importLabel.TabIndex = 4;
            this.importLabel.Text = "Импорт";
            this.importLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importLabel.Visible = false;
            this.importLabel.Click += new System.EventHandler(this.ImportPanel_Click);
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.periodLabel.Location = new System.Drawing.Point(772, 13);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(202, 25);
            this.periodLabel.TabIndex = 11;
            this.periodLabel.Text = "Отобразить записи за";
            // 
            // dateTo
            // 
            this.dateTo.Enabled = false;
            this.dateTo.Location = new System.Drawing.Point(980, 85);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(233, 23);
            this.dateTo.TabIndex = 10;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFrom.Enabled = false;
            this.dateFrom.Location = new System.Drawing.Point(980, 56);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(233, 23);
            this.dateFrom.TabIndex = 9;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // periodComboBox
            // 
            this.periodComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.periodComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "всё время",
            "один месяц",
            "два месяца",
            "три месяца",
            "пол года",
            "год",
            "свои установки"});
            this.periodComboBox.Location = new System.Drawing.Point(980, 10);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(233, 33);
            this.periodComboBox.TabIndex = 8;
            this.periodComboBox.SelectedIndexChanged += new System.EventHandler(this.periodComboBox_SelectedIndexChanged);
            // 
            // filtrPanel
            // 
            this.filtrPanel.Controls.Add(this.filterIcon);
            this.filtrPanel.Controls.Add(this.filterLabel);
            this.filtrPanel.Location = new System.Drawing.Point(290, 3);
            this.filtrPanel.Name = "filtrPanel";
            this.filtrPanel.Size = new System.Drawing.Size(72, 115);
            this.filtrPanel.TabIndex = 7;
            // 
            // filterIcon
            // 
            this.filterIcon.Image = ((System.Drawing.Image)(resources.GetObject("filterIcon.Image")));
            this.filterIcon.Location = new System.Drawing.Point(0, 38);
            this.filterIcon.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.filterIcon.Name = "filterIcon";
            this.filterIcon.Size = new System.Drawing.Size(69, 70);
            this.filterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterIcon.TabIndex = 2;
            this.filterIcon.TabStop = false;
            this.filterIcon.Click += new System.EventHandler(this.FilterPanel_Click);
            this.filterIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilterPanel_MouseDown);
            this.filterIcon.MouseEnter += new System.EventHandler(this.FilterPanel_MouseEnter);
            this.filterIcon.MouseLeave += new System.EventHandler(this.FilterPanel_MouseLeave);
            this.filterIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilterPanel_MouseUp);
            // 
            // filterLabel
            // 
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.Location = new System.Drawing.Point(0, 7);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(69, 31);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Фильтр";
            this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterLabel.Click += new System.EventHandler(this.FilterPanel_Click);
            this.filterLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilterPanel_MouseDown);
            this.filterLabel.MouseEnter += new System.EventHandler(this.FilterPanel_MouseEnter);
            this.filterLabel.MouseLeave += new System.EventHandler(this.FilterPanel_MouseLeave);
            this.filterLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilterPanel_MouseUp);
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.categoryIcon);
            this.categoryPanel.Controls.Add(this.categoryLabel);
            this.categoryPanel.Location = new System.Drawing.Point(185, 3);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(99, 115);
            this.categoryPanel.TabIndex = 6;
            // 
            // categoryIcon
            // 
            this.categoryIcon.Image = ((System.Drawing.Image)(resources.GetObject("categoryIcon.Image")));
            this.categoryIcon.Location = new System.Drawing.Point(0, 38);
            this.categoryIcon.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.categoryIcon.Name = "categoryIcon";
            this.categoryIcon.Size = new System.Drawing.Size(95, 70);
            this.categoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryIcon.TabIndex = 2;
            this.categoryIcon.TabStop = false;
            this.categoryIcon.Click += new System.EventHandler(this.CategoryPanel_Click);
            this.categoryIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CategoryPanel_MouseDown);
            this.categoryIcon.MouseEnter += new System.EventHandler(this.CategoryPanel_MouseEnter);
            this.categoryIcon.MouseLeave += new System.EventHandler(this.CategoryPanel_MouseLeave);
            this.categoryIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CategoryPanel_MouseUp);
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(0, 7);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(95, 31);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Категории";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryLabel.Click += new System.EventHandler(this.CategoryPanel_Click);
            this.categoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CategoryPanel_MouseDown);
            this.categoryLabel.MouseEnter += new System.EventHandler(this.CategoryPanel_MouseEnter);
            this.categoryLabel.MouseLeave += new System.EventHandler(this.CategoryPanel_MouseLeave);
            this.categoryLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CategoryPanel_MouseUp);
            // 
            // InComePanel
            // 
            this.InComePanel.Controls.Add(this.IncomePictogram);
            this.InComePanel.Controls.Add(this.IncomeLabel);
            this.InComePanel.Location = new System.Drawing.Point(99, 0);
            this.InComePanel.Name = "InComePanel";
            this.InComePanel.Size = new System.Drawing.Size(80, 115);
            this.InComePanel.TabIndex = 5;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeLabel.Location = new System.Drawing.Point(0, 7);
            this.IncomeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(70, 31);
            this.IncomeLabel.TabIndex = 4;
            this.IncomeLabel.Text = "Доходы";
            this.IncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IncomeLabel.Click += new System.EventHandler(this.IncomePictogram_Click);
            this.IncomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InCome_MouseDown);
            this.IncomeLabel.MouseEnter += new System.EventHandler(this.InCome_MouseEnter);
            this.IncomeLabel.MouseLeave += new System.EventHandler(this.InCome_MouseLeave);
            this.IncomeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InCome_MouseUp);
            // 
            // OutComePanel
            // 
            this.OutComePanel.Controls.Add(this.OutcomePictogram);
            this.OutComePanel.Controls.Add(this.OutcomeLabel);
            this.OutComePanel.Location = new System.Drawing.Point(11, 3);
            this.OutComePanel.Name = "OutComePanel";
            this.OutComePanel.Size = new System.Drawing.Size(80, 115);
            this.OutComePanel.TabIndex = 4;
            this.OutComePanel.Click += new System.EventHandler(this.OutComePanel_Click);
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutcomeLabel.Location = new System.Drawing.Point(0, 4);
            this.OutcomeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(70, 31);
            this.OutcomeLabel.TabIndex = 3;
            this.OutcomeLabel.Text = "Расходы";
            this.OutcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutcomeLabel.Click += new System.EventHandler(this.OutComePanel_Click);
            this.OutcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OutCome_MouseDown);
            this.OutcomeLabel.MouseEnter += new System.EventHandler(this.OutCome_MouseEnter);
            this.OutcomeLabel.MouseLeave += new System.EventHandler(this.OutCome_MouseLeave);
            this.OutcomeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OutCome_MouseUp);
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            this.MainTable.AllowUserToResizeColumns = false;
            this.MainTable.AllowUserToResizeRows = false;
            this.MainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.category,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.MainTable.ContextMenuStrip = this.DataGridContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainTable.Location = new System.Drawing.Point(0, 150);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowHeadersVisible = false;
            this.MainTable.RowTemplate.Height = 25;
            this.MainTable.Size = new System.Drawing.Size(1225, 440);
            this.MainTable.TabIndex = 4;
            this.MainTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellDoubleClick);
            this.MainTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellMouseEnter);
            this.MainTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellMouseLeave);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "ТИП";
            this.type.MaxInputLength = 6;
            this.type.MinimumWidth = 100;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // category
            // 
            this.category.HeaderText = "КАТЕГОРИЯ";
            this.category.MaxInputLength = 50;
            this.category.MinimumWidth = 230;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ДАТА";
            this.Column3.MaxInputLength = 10;
            this.Column3.MinimumWidth = 130;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "СУММА";
            this.Column4.MinimumWidth = 220;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ИТОГО";
            this.Column5.MinimumWidth = 220;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "КОММЕНТАРИЙ";
            this.Column6.MinimumWidth = 315;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataGridContextMenu
            // 
            this.DataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Change,
            this.Delete});
            this.DataGridContextMenu.Name = "DataGridContextMenu";
            this.DataGridContextMenu.Size = new System.Drawing.Size(129, 48);
            this.DataGridContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DataGridContextMenu_Opening);
            // 
            // Change
            // 
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(128, 22);
            this.Change.Text = "Изменить";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(128, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // exportPanel
            // 
            this.exportPanel.Controls.Add(this.exportIcon);
            this.exportPanel.Controls.Add(this.exportLabel);
            this.exportPanel.Enabled = false;
            this.exportPanel.Location = new System.Drawing.Point(446, 32);
            this.exportPanel.Name = "exportPanel";
            this.exportPanel.Size = new System.Drawing.Size(72, 108);
            this.exportPanel.TabIndex = 13;
            this.exportPanel.Visible = false;
            // 
            // exportIcon
            // 
            this.exportIcon.Enabled = false;
            this.exportIcon.Image = ((System.Drawing.Image)(resources.GetObject("exportIcon.Image")));
            this.exportIcon.Location = new System.Drawing.Point(0, 35);
            this.exportIcon.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.exportIcon.Name = "exportIcon";
            this.exportIcon.Size = new System.Drawing.Size(69, 70);
            this.exportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exportIcon.TabIndex = 2;
            this.exportIcon.TabStop = false;
            this.exportIcon.Visible = false;
            // 
            // exportLabel
            // 
            this.exportLabel.Enabled = false;
            this.exportLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportLabel.Location = new System.Drawing.Point(0, 4);
            this.exportLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(69, 31);
            this.exportLabel.TabIndex = 4;
            this.exportLabel.Text = "Экспорт";
            this.exportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportLabel.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "dbo";
            this.openFileDialog.Title = "Выбирите файл базы данных";
            // 
            // HelpLabel
            // 
            this.HelpLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HelpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HelpLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpLabel.Location = new System.Drawing.Point(99, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(98, 23);
            this.HelpLabel.TabIndex = 1;
            this.HelpLabel.Text = "Помощь";
            this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            this.HelpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenuAboutUsButton_MouseDown);
            this.HelpLabel.MouseEnter += new System.EventHandler(this.TopMenuAboutUsButton_MouseEnter);
            this.HelpLabel.MouseLeave += new System.EventHandler(this.TopMenuAboutUsButton_MouseLeave);
            this.HelpLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopMenuAboutUsButton_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1225, 602);
            this.Controls.Add(this.exportPanel);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.MiddleMenuPanel);
            this.Controls.Add(this.TopMenu);
            this.Name = "MainWindow";
            this.Text = "Домашняя бухгалтерия";
            this.TopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutcomePictogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePictogram)).EndInit();
            this.MiddleMenuPanel.ResumeLayout(false);
            this.MiddleMenuPanel.PerformLayout();
            this.importPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importIcon)).EndInit();
            this.filtrPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterIcon)).EndInit();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryIcon)).EndInit();
            this.InComePanel.ResumeLayout(false);
            this.OutComePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.DataGridContextMenu.ResumeLayout(false);
            this.exportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Label TopMenuAboutUsButton;
        private System.Windows.Forms.PictureBox OutcomePictogram;
        private System.Windows.Forms.PictureBox IncomePictogram;
        private System.Windows.Forms.Panel MiddleMenuPanel;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.Panel OutComePanel;
        private System.Windows.Forms.Panel InComePanel;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.ContextMenuStrip DataGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Change;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.PictureBox categoryIcon;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel filtrPanel;
        private System.Windows.Forms.PictureBox filterIcon;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.PictureBox importIcon;
        private System.Windows.Forms.Label importLabel;
        private System.Windows.Forms.Panel exportPanel;
        private System.Windows.Forms.PictureBox exportIcon;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label HelpLabel;
    }
}

