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
    public partial class RowEditForm : Form
    {
        long id;
        string type;
        string category;
        string date;
        long oldSumm;
        long oldTotal;
        string comment;

        private DataBase db;

        private MainWindow mainWindow;
        private bool isIncome;

        public RowEditForm(string type, string category, string date, long summ, long total, string comment, long id,
            MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            if (type == "Доход")
                isIncome = true;
            else
                isIncome = false;
            db = new DataBase();
            DataTable dTable = db.ReadDataFromCategoryTable(isIncome);
            foreach (DataRow row in dTable.Rows)
            {
                categoryDropDownList.Items.Add(row.ItemArray[1]);
            }

            InputCaption.Text = type;
            //categoryTextBox.Text = category;
            try
            {
                categoryDropDownList.SelectedIndex = categoryDropDownList.Items.IndexOf(category);
                categoryDropDownList.SelectedItem = categoryDropDownList.Items[categoryDropDownList.SelectedIndex];
            }
            catch(SystemException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + " Скорее всего что то не так с категориями");
            }
            //DateTime myDate = DateTime.ParseExact("data", "yyyy.MM.dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime myDate = DateTime.Parse(date);
            dateTimePicker.Value = myDate;
            //summTextBox.Text = summ;
            //totalTextBox.Text = total;
            summTextBox.Text = NumParser.NormilizeNumberToString(summ);
            totalTextBox.Text = NumParser.NormilizeNumberToString(total);
            commentTextBox.Text = comment;

            this.id = id;
            this.type = type;
            this.category = category;
            this.date = date;
            this.oldSumm = summ;
            this.oldTotal = total;
            this.comment = comment;
        }

        private void editRowButton_Click(object sender, EventArgs e)
        {
            long newTotal = 0;
            long newSumm = 0;
            if (!NumParser.TryParseFromNormalStringToLong(summTextBox.Text, out newSumm))
            {
                MessageBox.Show("Поле сумма должно содержать целое число!");
                return;
            }
            if(type == "Доход")
            {
                newTotal = oldTotal + newSumm - oldSumm;
            }    
            else
            {
                newTotal = oldTotal - newSumm + oldSumm;
            }
            db.UpdateRowInDataBase(categoryDropDownList.SelectedItem.ToString(), dateTimePicker.Value.ToShortDateString(),
                newSumm, newTotal, commentTextBox.Text, id);
            this.Close();
            mainWindow.UpdateDataGrid();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            db.DeleteRowInDataBase(id);
            this.Close();
            mainWindow.UpdateDataGrid();
        }

        private void RowEditForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                editRowButton_Click(sender, e);
            }
        }
    }
}
