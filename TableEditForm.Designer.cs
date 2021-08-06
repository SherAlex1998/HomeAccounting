
namespace HomeAccounting
{
    partial class TableEditForm
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
            this.InputCaption = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.categoryDropDownList = new System.Windows.Forms.ComboBox();
            this.addRowButton = new System.Windows.Forms.Button();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.summTextBox = new System.Windows.Forms.TextBox();
            this.summaLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.categoryDropDownList);
            this.MainPanel.Controls.Add(this.addRowButton);
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
            this.MainPanel.TabIndex = 3;
            // 
            // categoryDropDownList
            // 
            this.categoryDropDownList.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryDropDownList.FormattingEnabled = true;
            this.categoryDropDownList.Location = new System.Drawing.Point(261, 46);
            this.categoryDropDownList.Name = "categoryDropDownList";
            this.categoryDropDownList.Size = new System.Drawing.Size(367, 31);
            this.categoryDropDownList.Sorted = true;
            this.categoryDropDownList.TabIndex = 11;
            this.categoryDropDownList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableEditForm_KeyPress);
            // 
            // addRowButton
            // 
            this.addRowButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRowButton.Location = new System.Drawing.Point(57, 392);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(155, 42);
            this.addRowButton.TabIndex = 10;
            this.addRowButton.Text = "Создать запись";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.AddRowButton_click);
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
            this.commentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableEditForm_KeyPress);
            // 
            // summTextBox
            // 
            this.summTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summTextBox.Location = new System.Drawing.Point(261, 131);
            this.summTextBox.Name = "summTextBox";
            this.summTextBox.Size = new System.Drawing.Size(367, 33);
            this.summTextBox.TabIndex = 7;
            this.summTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableEditForm_KeyPress);
            // 
            // summaLabel
            // 
            this.summaLabel.AutoSize = true;
            this.summaLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaLabel.Location = new System.Drawing.Point(57, 138);
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
            this.dateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableEditForm_KeyPress);
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
            // TableEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 478);
            this.Controls.Add(this.MainPanel);
            this.Name = "TableEditForm";
            this.ShowInTaskbar = false;
            this.Text = "Новая запись";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableEditForm_KeyPress);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InputCaption;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox summTextBox;
        private System.Windows.Forms.Label summaLabel;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.ComboBox categoryDropDownList;
    }
}