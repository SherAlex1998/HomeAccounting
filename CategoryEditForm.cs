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
    public partial class CategoryEditForm : Form
    {
        private DataBase db;
        private long currentID;
        private int currentRowIndex;
        private bool isIncome;
        public CategoryEditForm()
        {
            InitializeComponent();
            db = new DataBase();
            categoruTypeComboBox.SelectedIndex = 0;
            UpdateCategoryDataGridView();
            if (categoryDataGrid.Rows.Count > 0)
            {
                editCategoryTextBox.Text = (string)categoryDataGrid.Rows[0].Cells[1].Value;
                currentRowIndex = 0;
                currentID = (long)categoryDataGrid.Rows[currentRowIndex].Cells[0].Value;
            }
            else
            {
                currentID = -1;
                currentRowIndex = -1;
            }
            if ((string)categoruTypeComboBox.SelectedItem == "Доход")
                isIncome = true;
            else
                isIncome = false;
        }

        private void CategoryTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            categoryDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
        }

        private void CategoryTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            categoryDataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Menu;
        }

        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            if (newCategoryTexBox.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести новое название категории!");
                return;
            }
            db.AddNewCategory(newCategoryTexBox.Text, isIncome);
            currentRowIndex = 0;
            UpdateCategoryDataGridView();
            currentID = (long)categoryDataGrid.Rows[0].Cells[0].Value;
        }

        private void UpdateCategoryDataGridView()
        {
            DataTable dTable = db.ReadDataFromCategoryTable(isIncome);
            categoryDataGrid.Rows.Clear();
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                categoryDataGrid.Rows.Add(dTable.Rows[i].ItemArray);
            }
            if (categoryDataGrid.Rows.Count > 0)
                categoryDataGrid.Rows[currentRowIndex].Selected = true;
            else
            {
                currentID = -1;
                currentRowIndex = -1;
            }
        }

        private void categoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            editCategoryTextBox.Text = (string)categoryDataGrid.Rows[e.RowIndex].Cells[1].Value;
            currentID = (long)categoryDataGrid.Rows[e.RowIndex].Cells[0].Value;
            currentRowIndex = e.RowIndex;
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            if (editCategoryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести новое название категории!");
            }
            if(currentID == -1)
            {
                MessageBox.Show("Сначала необходимо добавить категории, а потом изменять их!");
            }
            if (editCategoryTextBox.Text.Length == 0 || currentID == -1) return;
            db.UpdateCategory(editCategoryTextBox.Text, currentID);
            UpdateCategoryDataGridView();
        }

        private void editCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                editCategoryButton_Click(sender, e);
            }
        }

        private void newCategoryTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddNewCategoryButton_Click(sender, e);
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (currentID == -1)
            {
                MessageBox.Show("Необходимо сначала добавить категорию, прежде чем удалять её!");
                return;
            }
            db.DeleteCategory(currentID);
            currentRowIndex = 0;
            currentID = (long)categoryDataGrid.Rows[0].Cells[0].Value;
            currentRowIndex = 0;
            UpdateCategoryDataGridView();
        }

        private void categoruTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)categoruTypeComboBox.SelectedItem == "Доход")
                isIncome = true;
            else
                isIncome = false;
            UpdateCategoryDataGridView();
        }
    }
}
