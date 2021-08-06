using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class TableEditForm : Form
    {
        private DataBase db;
        private string type;
        private bool isIncome;
        private MainWindow mainWindow;

        public TableEditForm(bool isIncome, MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            //dateTimePicker.CustomFormat = "MM.dd.yyyy";
            //dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.isIncome = isIncome;
            if (isIncome == true)
            {
                InputCaption.Text = "Доход";
                type = "Доход";
            }
            else
            {
                InputCaption.Text = "Расход";
                type = "Расход";
            }
            db = new DataBase();
            DataTable dTable = db.ReadDataFromCategoryTable(isIncome);
            foreach(DataRow row in dTable.Rows)
            {
                categoryDropDownList.Items.Add(row.ItemArray[1]);
            }
        }
        private void AddRowButton_click(object sender, EventArgs e)
        {
            if(categoryDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирите \"Категорию\" из списка");
                return;
            }
            long summValue = 0;
            if(!long.TryParse(summTextBox.Text, out summValue))
            {
                MessageBox.Show("Поле \"Сумма\" должно содержать целое число");
                return;
            }
            db.AddRow(type, categoryDropDownList.SelectedItem.ToString(), dateTimePicker.Value.ToShortDateString(), summValue, 
                commentTextBox.Text, isIncome);
            this.Close();
            mainWindow.UpdateDataGrid();
        }

        private void TableEditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddRowButton_click(sender, e);
            }
        }
    }
}
