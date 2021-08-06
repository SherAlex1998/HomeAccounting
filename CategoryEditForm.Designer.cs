
namespace HomeAccounting
{
    partial class CategoryEditForm
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
            this.mainFormFiller = new System.Windows.Forms.Panel();
            this.typeCaption = new System.Windows.Forms.Label();
            this.categoruTypeComboBox = new System.Windows.Forms.ComboBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryTextBox = new System.Windows.Forms.TextBox();
            this.AddNewCategoryButton = new System.Windows.Forms.Button();
            this.newCategoryTexBox = new System.Windows.Forms.TextBox();
            this.categoryDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caption = new System.Windows.Forms.Label();
            this.mainFormFiller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormFiller
            // 
            this.mainFormFiller.Controls.Add(this.typeCaption);
            this.mainFormFiller.Controls.Add(this.categoruTypeComboBox);
            this.mainFormFiller.Controls.Add(this.deleteCategoryButton);
            this.mainFormFiller.Controls.Add(this.text);
            this.mainFormFiller.Controls.Add(this.editCategoryButton);
            this.mainFormFiller.Controls.Add(this.editCategoryTextBox);
            this.mainFormFiller.Controls.Add(this.AddNewCategoryButton);
            this.mainFormFiller.Controls.Add(this.newCategoryTexBox);
            this.mainFormFiller.Controls.Add(this.categoryDataGrid);
            this.mainFormFiller.Controls.Add(this.caption);
            this.mainFormFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormFiller.Location = new System.Drawing.Point(0, 0);
            this.mainFormFiller.Name = "mainFormFiller";
            this.mainFormFiller.Size = new System.Drawing.Size(800, 450);
            this.mainFormFiller.TabIndex = 0;
            // 
            // typeCaption
            // 
            this.typeCaption.AutoSize = true;
            this.typeCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeCaption.Location = new System.Drawing.Point(54, 130);
            this.typeCaption.Name = "typeCaption";
            this.typeCaption.Size = new System.Drawing.Size(214, 21);
            this.typeCaption.TabIndex = 9;
            this.typeCaption.Text = "Выбирите тип категории:";
            // 
            // categoruTypeComboBox
            // 
            this.categoruTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoruTypeComboBox.FormattingEnabled = true;
            this.categoruTypeComboBox.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.categoruTypeComboBox.Location = new System.Drawing.Point(54, 154);
            this.categoruTypeComboBox.Name = "categoruTypeComboBox";
            this.categoruTypeComboBox.Size = new System.Drawing.Size(319, 29);
            this.categoruTypeComboBox.TabIndex = 8;
            this.categoruTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.categoruTypeComboBox_SelectedIndexChanged);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryButton.Location = new System.Drawing.Point(54, 290);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(319, 33);
            this.deleteCategoryButton.TabIndex = 7;
            this.deleteCategoryButton.Text = "Удалить выбранную категорию";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(54, 51);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(349, 42);
            this.text.TabIndex = 6;
            this.text.Text = "Категории из списка будут доступны для \r\nвыбора при добавлении новой записи\r\n";
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCategoryButton.Location = new System.Drawing.Point(54, 251);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(319, 33);
            this.editCategoryButton.TabIndex = 5;
            this.editCategoryButton.Text = "Сохранить изменение названия";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // editCategoryTextBox
            // 
            this.editCategoryTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCategoryTextBox.Location = new System.Drawing.Point(54, 216);
            this.editCategoryTextBox.Name = "editCategoryTextBox";
            this.editCategoryTextBox.Size = new System.Drawing.Size(319, 29);
            this.editCategoryTextBox.TabIndex = 4;
            this.editCategoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editCategoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCategoryTextBox_KeyPress);
            // 
            // AddNewCategoryButton
            // 
            this.AddNewCategoryButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewCategoryButton.Location = new System.Drawing.Point(54, 391);
            this.AddNewCategoryButton.Name = "AddNewCategoryButton";
            this.AddNewCategoryButton.Size = new System.Drawing.Size(319, 33);
            this.AddNewCategoryButton.TabIndex = 3;
            this.AddNewCategoryButton.Text = "Добавить новую категорию";
            this.AddNewCategoryButton.UseVisualStyleBackColor = true;
            this.AddNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // newCategoryTexBox
            // 
            this.newCategoryTexBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCategoryTexBox.Location = new System.Drawing.Point(54, 356);
            this.newCategoryTexBox.Name = "newCategoryTexBox";
            this.newCategoryTexBox.Size = new System.Drawing.Size(319, 29);
            this.newCategoryTexBox.TabIndex = 2;
            this.newCategoryTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newCategoryTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newCategoryTexBox_KeyPress);
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
            this.categoryDataGrid.Location = new System.Drawing.Point(436, 51);
            this.categoryDataGrid.MultiSelect = false;
            this.categoryDataGrid.Name = "categoryDataGrid";
            this.categoryDataGrid.ReadOnly = true;
            this.categoryDataGrid.RowHeadersVisible = false;
            this.categoryDataGrid.RowTemplate.Height = 25;
            this.categoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGrid.Size = new System.Drawing.Size(324, 373);
            this.categoryDataGrid.TabIndex = 1;
            this.categoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGrid_CellClick);
            this.categoryDataGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellMouseEnter);
            this.categoryDataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellMouseLeave);
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
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caption.Location = new System.Drawing.Point(139, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(533, 27);
            this.caption.TabIndex = 0;
            this.caption.Text = "Добавление или редактирование списка категорий";
            // 
            // CategoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFormFiller);
            this.Name = "CategoryEditForm";
            this.Text = "Form1";
            this.mainFormFiller.ResumeLayout(false);
            this.mainFormFiller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormFiller;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.TextBox editCategoryTextBox;
        private System.Windows.Forms.Button AddNewCategoryButton;
        private System.Windows.Forms.TextBox newCategoryTexBox;
        private System.Windows.Forms.DataGridView categoryDataGrid;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Label typeCaption;
        private System.Windows.Forms.ComboBox categoruTypeComboBox;
    }
}