
namespace HomeAccounting
{
    partial class RowEditForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.categoryDropDownList = new System.Windows.Forms.ComboBox();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.editRowButton = new System.Windows.Forms.Button();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.summTextBox = new System.Windows.Forms.TextBox();
            this.summaLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.InputCaption = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.categoryDropDownList);
            this.MainPanel.Controls.Add(this.deleteRowButton);
            this.MainPanel.Controls.Add(this.totalTextBox);
            this.MainPanel.Controls.Add(this.totalLabel);
            this.MainPanel.Controls.Add(this.editRowButton);
            this.MainPanel.Controls.Add(this.commentLabel);
            this.MainPanel.Controls.Add(this.commentTextBox);
            this.MainPanel.Controls.Add(this.summTextBox);
            this.MainPanel.Controls.Add(this.summaLabel);
            this.MainPanel.Controls.Add(this.dateTimePicker);
            this.MainPanel.Controls.Add(this.dataLabel);
            this.MainPanel.Controls.Add(this.InputCaption);
            this.MainPanel.Controls.Add(this.categoryLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(640, 478);
            this.MainPanel.TabIndex = 4;
            // 
            // categoryDropDownList
            // 
            this.categoryDropDownList.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryDropDownList.FormattingEnabled = true;
            this.categoryDropDownList.Location = new System.Drawing.Point(261, 48);
            this.categoryDropDownList.Name = "categoryDropDownList";
            this.categoryDropDownList.Size = new System.Drawing.Size(367, 31);
            this.categoryDropDownList.Sorted = true;
            this.categoryDropDownList.TabIndex = 14;
            this.categoryDropDownList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowEditForm_KeyPress);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteRowButton.Location = new System.Drawing.Point(29, 409);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(198, 42);
            this.deleteRowButton.TabIndex = 13;
            this.deleteRowButton.Text = "Удалить запись";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTextBox.Location = new System.Drawing.Point(261, 157);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(367, 33);
            this.totalTextBox.TabIndex = 12;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(57, 164);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 21);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Итого";
            // 
            // editRowButton
            // 
            this.editRowButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editRowButton.Location = new System.Drawing.Point(29, 339);
            this.editRowButton.Name = "editRowButton";
            this.editRowButton.Size = new System.Drawing.Size(198, 42);
            this.editRowButton.TabIndex = 10;
            this.editRowButton.Text = "Сохранить изменения";
            this.editRowButton.UseVisualStyleBackColor = true;
            this.editRowButton.Click += new System.EventHandler(this.editRowButton_Click);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentLabel.Location = new System.Drawing.Point(57, 292);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(120, 21);
            this.commentLabel.TabIndex = 9;
            this.commentLabel.Text = "Комментарий";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentTextBox.Location = new System.Drawing.Point(261, 285);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(367, 181);
            this.commentTextBox.TabIndex = 8;
            this.commentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowEditForm_KeyPress);
            // 
            // summTextBox
            // 
            this.summTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summTextBox.Location = new System.Drawing.Point(261, 98);
            this.summTextBox.Name = "summTextBox";
            this.summTextBox.Size = new System.Drawing.Size(367, 33);
            this.summTextBox.TabIndex = 7;
            this.summTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowEditForm_KeyPress);
            // 
            // summaLabel
            // 
            this.summaLabel.AutoSize = true;
            this.summaLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaLabel.Location = new System.Drawing.Point(57, 105);
            this.summaLabel.Name = "summaLabel";
            this.summaLabel.Size = new System.Drawing.Size(64, 21);
            this.summaLabel.TabIndex = 6;
            this.summaLabel.Text = "Сумма";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(261, 219);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(367, 23);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowEditForm_KeyPress);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataLabel.Location = new System.Drawing.Point(57, 221);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(47, 21);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "Дата";
            // 
            // InputCaption
            // 
            this.InputCaption.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCaption.Location = new System.Drawing.Point(12, 0);
            this.InputCaption.Name = "InputCaption";
            this.InputCaption.Size = new System.Drawing.Size(616, 38);
            this.InputCaption.TabIndex = 0;
            this.InputCaption.Text = "Доход";
            this.InputCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(57, 53);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(94, 21);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Категория";
            // 
            // RowEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 478);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RowEditForm";
            this.Text = "Изменение записи";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowEditForm_KeyPress);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button editRowButton;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox summTextBox;
        private System.Windows.Forms.Label summaLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label InputCaption;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.ComboBox categoryDropDownList;
    }
}