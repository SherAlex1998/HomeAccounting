
namespace HomeAccounting
{
    partial class AboutUs
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
            this.AboutUsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutUsText
            // 
            this.AboutUsText.AutoSize = true;
            this.AboutUsText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutUsText.Location = new System.Drawing.Point(122, 118);
            this.AboutUsText.Name = "AboutUsText";
            this.AboutUsText.Size = new System.Drawing.Size(551, 96);
            this.AboutUsText.TabIndex = 0;
            this.AboutUsText.Text = "Домашняя Бухгалтерия, версия 1.0.1.1\r\nНаписана Александром (SherAlex) Шабановым \r" +
    "\nкак проф. задание для Junior .NET-разработчика\r\n";
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutUsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutUs";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutUsText;
    }
}