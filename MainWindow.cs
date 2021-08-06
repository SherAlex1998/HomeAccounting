using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HomeAccounting
{
    public struct filterCheckFactors
    {
        public string Type;
        public List<string> categories;
        public DateTime dateFrom;
        public DateTime dateTo;
        public bool isSummMatters;
        public long minSumm;
        public long maxSumm;
    }

    public partial class MainWindow : Form
    {
        DataBase db;
        private int selectedPeriodIndex = 0;

        private Image greenFilter;
        private Image normalFilter;

        private bool isAdvancedFilter;

        private filterCheckFactors filter;
        
        public MainWindow()
        {
            InitializeComponent();
            db = new DataBase();
            db.Create();
            periodComboBox.SelectedIndex = selectedPeriodIndex;
            periodComboBox.SelectedItem = periodComboBox.Items[selectedPeriodIndex];
            dateFrom.Value = dateFrom.MinDate;
            dateTo.Value = dateTo.MaxDate;
            UpdateDataGrid();
            greenFilter = Properties.Resources.FiltrIconGreen;
            normalFilter = Properties.Resources.FiltrIcon;
            isAdvancedFilter = false;
        }

        public void ApplyAdvancedFilter(filterCheckFactors filter)
        {
            selectedPeriodIndex = -1;
            filterIcon.Image = greenFilter;
            isAdvancedFilter = true;
            dateFrom.Enabled = false;
            dateTo.Enabled = false;
            periodComboBox.Enabled = false;
            this.filter = filter;
            UpdateDataGrid();
        }

        public void ApplyCommonFilter()
        {
            selectedPeriodIndex = 0;
            filterIcon.Image = normalFilter;
            isAdvancedFilter = false;
            if(periodComboBox.SelectedIndex > 0)
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
            }
            periodComboBox.Enabled = true;
        }

        private bool FilterAllow(object[] itemArray, bool advanced)
        {
            if (!advanced)
            {
                DateTime dateFromRow = DateTime.Parse((string)itemArray[3]);
                if (dateFromRow >= dateFrom.Value & dateFromRow <= dateTo.Value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (filter.Type != "all")
                {
                    if ((string)itemArray[1] != filter.Type)
                        return false;
                }
                if (!filter.categories.Contains((string)itemArray[2]))
                    return false;
                DateTime dateFromRow = DateTime.Parse((string)itemArray[3]);
                if (!(dateFromRow >= filter.dateFrom & dateFromRow <= filter.dateTo))
                {
                    return false;
                }
                if(filter.isSummMatters)
                {
                    if (!((long)itemArray[4] >= filter.minSumm & (long)itemArray[4] <= filter.maxSumm))
                        return false;
                }
            }
            return true;
        }

        public void UpdateDataGrid()
        {
            DataTable dTable = db.GetTable();
            if(selectedPeriodIndex == 0)
            {
                MainTable.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    MainTable.Rows.Add(dTable.Rows[i].ItemArray);
                }
                foreach (DataGridViewRow row in MainTable.Rows)
                {
                    row.Cells[4].Value = NumParser.NormilizeNumberToString((long)row.Cells[4].Value);
                    row.Cells[5].Value = NumParser.NormilizeNumberToString((long)row.Cells[5].Value);
                }
            }
            else
            {
                MainTable.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    if(FilterAllow(dTable.Rows[i].ItemArray, isAdvancedFilter))
                        MainTable.Rows.Add(dTable.Rows[i].ItemArray);
                }
                foreach (DataGridViewRow row in MainTable.Rows)
                {
                    row.Cells[4].Value = NumParser.NormilizeNumberToString((long)row.Cells[4].Value);
                    row.Cells[5].Value = NumParser.NormilizeNumberToString((long)row.Cells[5].Value);
                }
            }
        }

        private void MouseEnterStandartEffect(object sender)
        {
            (sender as Control).BackColor = SystemColors.ControlDark;
        }

        private void MouseLeaveStandartEffect(object sender)
        {
            (sender as Control).BackColor = SystemColors.Control;
        }

        private void MouseUpStandartEffect(object sender)
        {
            (sender as Control).BackColor = SystemColors.Control;
        }

        private void MouseDownStandartEffect(object sender)
        {
            (sender as Control).BackColor = SystemColors.ControlDarkDark;
        }

        private void MouseEnterPanelStandartEffect(object sender)
        {

            foreach (Control element in (sender as Panel).Controls)
            {
                (sender as Control).BackColor = SystemColors.ControlDark;
            }
        }

        private void MouseLeavePanelStandartEffect(object sender)
        {
            foreach (Control element in (sender as Panel).Controls)
            {
                (sender as Control).BackColor = SystemColors.Control;
            }
        }

        private void MouseUpPanelStandartEffect(object sender)
        {
            foreach (Control element in (sender as Panel).Controls)
            {
                (sender as Control).BackColor = SystemColors.Control;
            }
        }

        private void MouseDownPanelStandartEffect(object sender)
        {
            foreach (Control element in (sender as Panel).Controls)
            {
                (sender as Control).BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void TopMenuAboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void TopMenuAboutUsButton_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownStandartEffect(sender);
        }

        private void TopMenuAboutUsButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterStandartEffect(sender);
        }

        private void TopMenuAboutUsButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveStandartEffect(sender);
        }

        private void TopMenuAboutUsButton_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUpStandartEffect(sender);
        }

        private void InCome_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(Control element in InComePanel.Controls)
            {
                //element.BackColor = SystemColors.ControlDarkDark;
                element.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void InCome_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control element in InComePanel.Controls)
            {
                //element.BackColor = SystemColors.ControlDark;
                element.BackColor = SystemColors.InactiveCaption;
            }
        }

        private void InCome_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control element in InComePanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void InCome_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control element in InComePanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void InCome_Click(object sender, EventArgs e)
        {
            TableEditForm tablelEditForm = new TableEditForm(true, this);
            tablelEditForm.Show();
            db.ReadData(MainTable);
        }

        private void OutCome_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control element in OutComePanel.Controls)
            {
                element.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void OutCome_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control element in OutComePanel.Controls)
            {
                element.BackColor = SystemColors.InactiveCaption;
            }
        }

        private void OutCome_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control element in OutComePanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void OutCome_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control element in OutComePanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void OutComePanel_Click(object sender, EventArgs e)
        {
            TableEditForm tablelEditForm = new TableEditForm(false, this);
            tablelEditForm.Show();
            db.ReadData(MainTable);
        }

        private void IncomePictogram_Click(object sender, EventArgs e)
        {
            TableEditForm tablelEditForm = new TableEditForm(true, this);
            tablelEditForm.Show();
            db.ReadData(MainTable);
        }

        private void CategoryPanel_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control element in categoryPanel.Controls)
            {
                //element.BackColor = SystemColors.ControlDark;
                element.BackColor = SystemColors.InactiveCaption;
            }
        }

        private void CategoryPanel_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control element in categoryPanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void CategoryPanel_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control element in categoryPanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void CategoryPanel_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control element in categoryPanel.Controls)
            {
                element.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void FilterPanel_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control element in filtrPanel.Controls)
            {
                //element.BackColor = SystemColors.ControlDark;
                element.BackColor = SystemColors.InactiveCaption;
            }
        }

        private void FilterPanel_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control element in filtrPanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void FilterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control element in filtrPanel.Controls)
            {
                element.BackColor = SystemColors.Control;
            }
        }

        private void FilterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control element in filtrPanel.Controls)
            {
                element.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void FilterPanel_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(this);
            filterForm.Show();
            db.ReadData(MainTable);
        }

        private void CategoryPanel_Click(object sender, EventArgs e)
        {
            CategoryEditForm categoryEditForm = new CategoryEditForm();
            categoryEditForm.Show();
        }

        private void ImportPanel_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if(openFileDialog.CheckFileExists & openFileDialog.CheckPathExists)
            {
                if (openFileDialog.FileName.Length > 0)
                {
                    System.IO.File.Delete(Constants.dataBaseFileName);
                    System.IO.File.Copy(openFileDialog.FileName, Constants.dataBaseFileName);
                }
            }
        }

        private void MainTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex == -1)
            {
                return;
            }    
            long id = (long)MainTable.Rows[rowIndex].Cells[0].Value;
            DataTable dTable = db.GetTable();
            string type = (string)dTable.Rows[rowIndex].ItemArray[1];
            string category = (string)dTable.Rows[rowIndex].ItemArray[2];
            string data = (string)dTable.Rows[rowIndex].ItemArray[3];
            long summ = (long)dTable.Rows[rowIndex].ItemArray[4];
            long total = (long)dTable.Rows[rowIndex].ItemArray[5];
            string comment = (string)dTable.Rows[rowIndex].ItemArray[6];
            RowEditForm rowEditForm = new RowEditForm(type, category, data, summ, total, comment, id, this);
            rowEditForm.Show();
        }

        private void DataGridContextMenu_Opening(object sender, CancelEventArgs e)
        {
            Point point = MainTable.PointToClient(DataGridContextMenu.Bounds.Location);
            DataGridView.HitTestInfo info = MainTable.HitTest(point.X, point.Y);

            // Отменяем показ контекстного меню, если клик был не на ячейке
            if (info.RowIndex == -1 || info.ColumnIndex == -1)
            {
                e.Cancel = true;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Point point = MainTable.PointToClient(DataGridContextMenu.Bounds.Location);
            DataGridView.HitTestInfo info = MainTable.HitTest(point.X, point.Y);

            int rowIndex = MainTable[info.ColumnIndex, info.RowIndex].RowIndex;
            long id = (long)MainTable.Rows[rowIndex].Cells[0].Value;
            DataTable dTable = db.GetTable();
            string type = (string)dTable.Rows[rowIndex].ItemArray[1];
            string category = (string)dTable.Rows[rowIndex].ItemArray[2];
            string data = (string)dTable.Rows[rowIndex].ItemArray[3];
            long summ = (long)dTable.Rows[rowIndex].ItemArray[4];
            long total = (long)dTable.Rows[rowIndex].ItemArray[5];
            string comment = (string)dTable.Rows[rowIndex].ItemArray[6];
            RowEditForm rowEditForm = new RowEditForm(type, category, data, summ, total, comment, id, this);
            rowEditForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Point point = MainTable.PointToClient(DataGridContextMenu.Bounds.Location);
            DataGridView.HitTestInfo info = MainTable.HitTest(point.X, point.Y);

            int rowIndex = MainTable[info.ColumnIndex, info.RowIndex].RowIndex;
            long id = (long)MainTable.Rows[rowIndex].Cells[0].Value;
            db.DeleteRowInDataBase(id);
            UpdateDataGrid();
        }

        private void MainTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            MainTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.ActiveCaption;
        }

        private void MainTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            MainTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Menu;
        }

        private void periodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPeriodIndex = periodComboBox.SelectedIndex;
            dateFrom.Enabled = false;
            dateTo.Enabled = false;
            switch (selectedPeriodIndex)
            {
                case 1:
                    dateTo.Value = DateTime.Now;
                    dateFrom.Value = dateTo.Value.AddDays(-DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                    break;
                case 2:
                    dateTo.Value = DateTime.Now;
                    dateFrom.Value = dateTo.Value.AddDays(-DateTime.DaysInMonth(DateTime.Now.Year,
                        DateTime.Now.Month) - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1));
                    break;
                case 3:
                    dateTo.Value = DateTime.Now;
                    dateFrom.Value = dateTo.Value.AddDays(-DateTime.DaysInMonth(DateTime.Now.Year,
                        DateTime.Now.Month) - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1)
                        - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 2));
                    break;
                case 4:
                    dateTo.Value = DateTime.Now;
                    dateFrom.Value = dateTo.Value.AddDays(-DateTime.DaysInMonth(DateTime.Now.Year,
                        DateTime.Now.Month) - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1)
                        - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 2)
                        - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 3)
                        - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 4)
                        - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 5)
                        );
                    break;
                case 5:
                    dateTo.Value = DateTime.Now;
                    dateFrom.Value = dateTo.Value.AddYears(-1);
                    break;
                case 6:
                    dateFrom.Enabled = true;
                    dateTo.Enabled = true;
                    break;
            }
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
