
namespace HomeAccounting
{
    partial class FilterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.applyCommonFilter = new System.Windows.Forms.Button();
            this.applyFilter = new System.Windows.Forms.Button();
            this.deleteSelectedCategoryButton = new System.Windows.Forms.Button();
            this.categoryDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summLabel2 = new System.Windows.Forms.Label();
            this.maxSummTextBox = new System.Windows.Forms.TextBox();
            this.summLabel = new System.Windows.Forms.Label();
            this.minSummTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryToFilter = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categotyComboBox = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.caption = new System.Windows.Forms.Label();
            this.fillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(12, 141);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(233, 23);
            this.dateTo.TabIndex = 12;
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFrom.Location = new System.Drawing.Point(12, 82);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(233, 23);
            this.dateFrom.TabIndex = 11;
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.applyCommonFilter);
            this.fillPanel.Controls.Add(this.applyFilter);
            this.fillPanel.Controls.Add(this.deleteSelectedCategoryButton);
            this.fillPanel.Controls.Add(this.categoryDataGrid);
            this.fillPanel.Controls.Add(this.summLabel2);
            this.fillPanel.Controls.Add(this.maxSummTextBox);
            this.fillPanel.Controls.Add(this.summLabel);
            this.fillPanel.Controls.Add(this.minSummTextBox);
            this.fillPanel.Controls.Add(this.addCategoryToFilter);
            this.fillPanel.Controls.Add(this.categoryComboBox);
            this.fillPanel.Controls.Add(this.categotyComboBox);
            this.fillPanel.Controls.Add(this.dateTo);
            this.fillPanel.Controls.Add(this.typeLabel);
            this.fillPanel.Controls.Add(this.typeComboBox);
            this.fillPanel.Controls.Add(this.dateToLabel);
            this.fillPanel.Controls.Add(this.dateLabel1);
            this.fillPanel.Controls.Add(this.dateFrom);
            this.fillPanel.Controls.Add(this.caption);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(868, 520);
            this.fillPanel.TabIndex = 13;
            // 
            // applyCommonFilter
            // 
            this.applyCommonFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyCommonFilter.Location = new System.Drawing.Point(252, 449);
            this.applyCommonFilter.Name = "applyCommonFilter";
            this.applyCommonFilter.Size = new System.Drawing.Size(192, 40);
            this.applyCommonFilter.TabIndex = 25;
            this.applyCommonFilter.Text = "Сбросить фильтр";
            this.applyCommonFilter.UseVisualStyleBackColor = true;
            this.applyCommonFilter.Click += new System.EventHandler(this.applyCommonFilter_Click);
            // 
            // applyFilter
            // 
            this.applyFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyFilter.Location = new System.Drawing.Point(12, 449);
            this.applyFilter.Name = "applyFilter";
            this.applyFilter.Size = new System.Drawing.Size(176, 40);
            this.applyFilter.TabIndex = 24;
            this.applyFilter.Text = "Применить фильтр";
            this.applyFilter.UseVisualStyleBackColor = true;
            this.applyFilter.Click += new System.EventHandler(this.applyFilter_Click);
            // 
            // deleteSelectedCategoryButton
            // 
            this.deleteSelectedCategoryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedCategoryButton.Location = new System.Drawing.Point(501, 449);
            this.deleteSelectedCategoryButton.Name = "deleteSelectedCategoryButton";
            this.deleteSelectedCategoryButton.Size = new System.Drawing.Size(323, 40);
            this.deleteSelectedCategoryButton.TabIndex = 23;
            this.deleteSelectedCategoryButton.Text = "Убрать выбранную категорию";
            this.deleteSelectedCategoryButton.UseVisualStyleBackColor = true;
            this.deleteSelectedCategoryButton.Click += new System.EventHandler(this.deleteSelectedCategoryButton_Click);
            // 
            // categoryDataGrid
            // 
            this.categoryDataGrid.AllowUserToAddRows = false;
            this.categoryDataGrid.AllowUserToDeleteRows = false;
            this.categoryDataGrid.AllowUserToResizeColumns = false;
            this.categoryDataGrid.AllowUserToResizeRows = false;
            this.categoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.categoryCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataGrid.Location = new System.Drawing.Point(501, 58);
            this.categoryDataGrid.MultiSelect = false;
            this.categoryDataGrid.Name = "categoryDataGrid";
            this.categoryDataGrid.ReadOnly = true;
            this.categoryDataGrid.RowHeadersVisible = false;
            this.categoryDataGrid.RowTemplate.Height = 25;
            this.categoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGrid.Size = new System.Drawing.Size(323, 358);
            this.categoryDataGrid.TabIndex = 22;
            this.categoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGrid_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // categoryCol
            // 
            this.categoryCol.HeaderText = "Список категорий";
            this.categoryCol.MinimumWidth = 320;
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.ReadOnly = true;
            this.categoryCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // summLabel2
            // 
            this.summLabel2.AutoSize = true;
            this.summLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summLabel2.Location = new System.Drawing.Point(252, 334);
            this.summLabel2.Name = "summLabel2";
            this.summLabel2.Size = new System.Drawing.Size(182, 21);
            this.summLabel2.TabIndex = 21;
            this.summLabel2.Text = "Максимальная сумма";
            // 
            // maxSummTextBox
            // 
            this.maxSummTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxSummTextBox.Location = new System.Drawing.Point(252, 370);
            this.maxSummTextBox.Name = "maxSummTextBox";
            this.maxSummTextBox.Size = new System.Drawing.Size(192, 33);
            this.maxSummTextBox.TabIndex = 20;
            // 
            // summLabel
            // 
            this.summLabel.AutoSize = true;
            this.summLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summLabel.Location = new System.Drawing.Point(12, 334);
            this.summLabel.Name = "summLabel";
            this.summLabel.Size = new System.Drawing.Size(176, 21);
            this.summLabel.TabIndex = 19;
            this.summLabel.Text = "Минимальная сумма";
            // 
            // minSummTextBox
            // 
            this.minSummTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minSummTextBox.Location = new System.Drawing.Point(12, 370);
            this.minSummTextBox.Name = "minSummTextBox";
            this.minSummTextBox.Size = new System.Drawing.Size(176, 33);
            this.minSummTextBox.TabIndex = 18;
            // 
            // addCategoryToFilter
            // 
            this.addCategoryToFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryToFilter.Location = new System.Drawing.Point(286, 289);
            this.addCategoryToFilter.Name = "addCategoryToFilter";
            this.addCategoryToFilter.Size = new System.Drawing.Size(133, 29);
            this.addCategoryToFilter.TabIndex = 17;
            this.addCategoryToFilter.Text = "Добавить";
            this.addCategoryToFilter.UseVisualStyleBackColor = true;
            this.addCategoryToFilter.Click += new System.EventHandler(this.AddCategoryToFilterButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "все категории"});
            this.categoryComboBox.Location = new System.Drawing.Point(12, 290);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(233, 29);
            this.categoryComboBox.TabIndex = 16;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categotyComboBox
            // 
            this.categotyComboBox.AutoSize = true;
            this.categotyComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categotyComboBox.Location = new System.Drawing.Point(12, 253);
            this.categotyComboBox.Name = "categotyComboBox";
            this.categotyComboBox.Size = new System.Drawing.Size(432, 21);
            this.categotyComboBox.TabIndex = 15;
            this.categotyComboBox.Text = "Добавьте категории, которые требуются отобразить";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.Location = new System.Drawing.Point(12, 177);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(466, 21);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Выбирите тип записей, которые необходимо отобразить";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "все типы",
            "Доход",
            "Расход"});
            this.typeComboBox.Location = new System.Drawing.Point(12, 210);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(233, 29);
            this.typeComboBox.TabIndex = 13;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateToLabel.Location = new System.Drawing.Point(12, 117);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(450, 21);
            this.dateToLabel.TabIndex = 12;
            this.dateToLabel.Text = "Задайте дату, до которой требуется отобразить записи";
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel1.Location = new System.Drawing.Point(12, 58);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(439, 21);
            this.dateLabel1.TabIndex = 1;
            this.dateLabel1.Text = "Задайте дату, с которой требуется отобразить записи\r\n";
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caption.Location = new System.Drawing.Point(252, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(358, 27);
            this.caption.TabIndex = 0;
            this.caption.Text = "Расширенные настройки фильтра";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(868, 520);
            this.Controls.Add(this.fillPanel);
            this.Name = "FilterForm";
            this.Text = "Фильтр";
            this.fillPanel.ResumeLayout(false);
            this.fillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Label summLabel2;
        private System.Windows.Forms.TextBox maxSummTextBox;
        private System.Windows.Forms.Label summLabel;
        private System.Windows.Forms.TextBox minSummTextBox;
        private System.Windows.Forms.Button addCategoryToFilter;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categotyComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Button deleteSelectedCategoryButton;
        private System.Windows.Forms.DataGridView categoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.Button applyFilter;
        private System.Windows.Forms.Button applyCommonFilter;
    }
}