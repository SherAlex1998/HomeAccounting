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
    public partial class FilterForm : Form
    {
        private DataBase db = new DataBase();
        private bool isIncome;
        private bool isAllTypeAllow;

        private long currentID;
        private int currentRowIndex;

        private string currentCategory;

        private MainWindow mainWindow;

        public FilterForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            typeComboBox.SelectedIndex = 0;
            typeComboBox.SelectedItem = typeComboBox.Items[typeComboBox.SelectedIndex];
            isAllTypeAllow = true;
            categoryComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedItem = categoryComboBox.Items[0];
            UpdateCategoryData();
        }

        private void UpdateCategoryData()
        {
            categoryDataGrid.Rows.Clear();
            categoryComboBox.Items.Clear();
            DataTable dTable;
            if (isAllTypeAllow)
            {
                dTable = db.ReadAllDataFromCategoryTable();
            }
            else
            {
                dTable = db.ReadDataFromCategoryTable(isIncome);
            }
            categoryComboBox.Items.Add(Constants.allCategoryText);
            foreach (DataRow row in dTable.Rows)
            {
                categoryComboBox.Items.Add(row.ItemArray[1]);
            }
            foreach (DataRow row in dTable.Rows)
            {
                categoryDataGrid.Rows.Add(row.ItemArray);
            }
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

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryDataGrid.Rows.Clear();
            if (typeComboBox.SelectedIndex == 0)
            {
                isAllTypeAllow = true;
                UpdateCategoryData();
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                isAllTypeAllow = false;
                isIncome = true;
                UpdateCategoryData();
            }
            if (typeComboBox.SelectedIndex == 2)
            {
                isAllTypeAllow = false;
                isIncome = false;
                UpdateCategoryData();
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != 0)
                currentCategory = (string)categoryComboBox.SelectedItem;
        }

        private void AddCategoryToFilterButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in categoryDataGrid.Rows)
                {
                    if (row.Cells[1].Value == (string)currentCategory)
                        return;
                }

                DataTable dTable = db.GetCategory(currentCategory);
                categoryDataGrid.Rows.Add(dTable.Rows[0].ItemArray);

            }
        }

        private void deleteSelectedCategoryButton_Click(object sender, EventArgs e)
        {
            if (currentID == -1)
            {
                MessageBox.Show(Constants.categoryDeleteErrorText);
                return;
            }
            categoryDataGrid.Rows.RemoveAt(currentRowIndex);
            currentRowIndex = 0;
            currentID = (long)categoryDataGrid.Rows[0].Cells[0].Value;
            currentRowIndex = 0;
        }

        private void categoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            currentID = (long)categoryDataGrid.Rows[e.RowIndex].Cells[0].Value;
            currentRowIndex = e.RowIndex;
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            filterCheckFactors filter = new filterCheckFactors();
            if(typeComboBox.SelectedIndex == 0)
            {
                filter.Type = Constants.typeAll;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                filter.Type = Constants.income;
            }
            if (typeComboBox.SelectedIndex == 2)
            {
                filter.Type = Constants.outcome;
            }
            filter.categories = new List<string>();
            foreach (DataGridViewRow row in categoryDataGrid.Rows)
            {
                filter.categories.Add((string)row.Cells[1].Value);
            }
            filter.dateTo = dateTo.Value;
            filter.dateFrom = dateFrom.Value;
            if (minSummTextBox.TextLength == 0)
            {
                filter.isSummMatters = false;
            }
            else
            {
                filter.isSummMatters = true;
                if (!long.TryParse(minSummTextBox.Text, out filter.minSumm))
                {
                    MessageBox.Show(Constants.minSumTextError);
                    return;
                }
                if (!long.TryParse(minSummTextBox.Text, out filter.maxSumm))
                {
                    MessageBox.Show(Constants.maxSumTextError);
                    return;
                }
                if(filter.minSumm > filter.maxSumm)
                {
                    MessageBox.Show(Constants.filterSummLogicError);
                    return;
                }
            }
            this.Close();
            mainWindow.ApplyAdvancedFilter(filter);
            
        }

        private void applyCommonFilter_Click(object sender, EventArgs e)
        { 
            this.Close();
            mainWindow.ApplyCommonFilter();
        }
    }
}
