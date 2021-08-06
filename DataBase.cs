using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace HomeAccounting
{
    public class DataBase
    {

        private string dbFileName;

        private SQLiteConnection connection;
        private SQLiteCommand command;

        public DataBase()
        {
            dbFileName = "mainDataBase.dbo";
            command = new SQLiteCommand();
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void Connect()
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Отсутствует файл базы данных. Перезагрузите программу.");

            try
            {
                connection = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                connection.Open();
                command.Connection = connection;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public void AddRow(string type, string category, string data, long summ, string comment, bool isIncome)
        {
            Connect();
            if (GetConnection().State != ConnectionState.Open)
            {
                MessageBox.Show("Нет соединения с базой данных");
                return;
            }
            try
            {
                DataTable dTable = new DataTable();
                String sqlQuery;
                sqlQuery = "SELECT * FROM Таблица WHERE id = (SELECT MAX(id) FROM Таблица)";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                long total = 0;
                if(dTable.Rows.Count != 0)
                {
                    if (isIncome)
                    {
                        total = dTable.Rows[0].Field<long>("Итого") + summ;
                    }
                    else
                    {
                        total = dTable.Rows[0].Field<long>("Итого") - summ;
                    }
                }
                else
                {
                    total += summ;
                }
                string commandText = String.Format("INSERT INTO Таблица " +
                    "('Тип', 'Категория', 'Дата', 'Сумма', 'Итого', 'Комментарий') " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", type, category, data, summ, total, comment);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public void Create()
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }
            try
            {
                connection = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                command = new SQLiteCommand();
                connection.Open();
                command.Connection = connection;

                command.CommandText =
                    "CREATE TABLE IF NOT EXISTS Таблица (id INTEGER PRIMARY KEY AUTOINCREMENT, Тип TEXT, Категория" +
                    " TEXT, Дата TEXT, Сумма INTEGER, Итого INTEGER, Комментарий TEXT)";
                command.ExecuteNonQuery();

                command.CommandText =
                    "CREATE TABLE IF NOT EXISTS Категории (id INTEGER PRIMARY KEY AUTOINCREMENT, Название TEXT UNIQUE, " +
                    "Тип TEXT)";
                command.ExecuteNonQuery();
                List<string> categoryListIncome = new List<string>();
                categoryListIncome.Add("Заработная плата");
                categoryListIncome.Add("Иные доходы");
                List<string> categoryListOutcome = new List<string>();
                categoryListOutcome.Add("Продукты питания");
                categoryListOutcome.Add("Транспорт");
                categoryListOutcome.Add("Мобильная связь");
                categoryListOutcome.Add("Интернет");
                categoryListOutcome.Add("Развлечения");
                categoryListOutcome.Add("Другое");
                foreach(string categoryName in categoryListIncome)
                {
                    string commandText = String.Format("INSERT OR IGNORE INTO Категории (Название, Тип) " +
                    "VALUES('{0}', '{1}')",
                    categoryName, "Доход");
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                }
                foreach (string categoryName in categoryListOutcome)
                {
                    string commandText = String.Format("INSERT OR IGNORE INTO Категории (Название, Тип) " +
                    "VALUES('{0}', '{1}')",
                    categoryName, "Расход");
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public DataTable GetTable()
        {
            DataTable dTable = new DataTable();
            String sqlQuery;
            Connect();
            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет соединения с базой");
                return null;
            }
            try
            {
                sqlQuery = "SELECT * FROM Таблица";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
            return dTable;
        }

        public void ReadData(DataGridView ViewTable)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;
            Connect();
            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет соединения с базой");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Таблица";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                //dTable.Columns.RemoveAt(0);

                /*
                if (dTable.Columns.Count > 0)
                {
                    ViewTable.Columns.Clear();

                    for (int i = 1; i < dTable.Columns.Count; i++)
                        ViewTable.Columns.Add(dTable.Columns[i].ColumnName, dTable.Columns[i].ColumnName);
                }
                */
                //if (dTable.Rows.Count > 0)
                //{
                ViewTable.Rows.Clear();
                //DataGridViewRow currentRow = new DataGridViewRow();

                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    ViewTable.Rows.Add(dTable.Rows[i].ItemArray);
                }
                foreach (DataGridViewRow row in ViewTable.Rows)
                {
                    row.Cells[4].Value = NumParser.NormilizeNumberToString((long)row.Cells[4].Value);
                    row.Cells[5].Value = NumParser.NormilizeNumberToString((long)row.Cells[5].Value);
                }
                //}
                /*else
                {
                    MessageBox.Show("База данных пуста");
                }*/
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public void UpdateRowInDataBase(string category, string date, long summ, long total, string comment, long ID)
        {
            Connect();
            String sqlQuery;
            try
            {
                string commandText = String.Format("UPDATE Таблица " +
                    "SET Категория = '{0}', Дата = '{1}', Сумма = '{2}', Итого = '{3}', Комментарий = '{4}' " +
                    "WHERE id = '{5}'", category, date, summ, total, comment, ID);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public void DeleteRowInDataBase(long ID)
        {
            Connect();
            try
            {
                string commandText = String.Format("DELETE FROM Таблица " +
                    "WHERE id = '{0}'", ID);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public void AddNewCategory(string name, bool isIncome)
        {
            Connect();
            try
            {
                string type = "";
                if (isIncome)
                    type = "Доход";
                else
                    type = "Расход";
                string commandText = String.Format("INSERT OR IGNORE INTO Категории (Название, Тип) VALUES('{0}', '{1}')", 
                    name, type);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public DataTable ReadDataFromCategoryTable(bool isIncome)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;
            Connect();
            try
            {
                string type;
                if (isIncome)
                    type = "Доход";
                else
                    type = "Расход";
                sqlQuery = String.Format("SELECT * FROM Категории WHERE Тип = '{0}'", type);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
            return dTable;
        }

        public DataTable ReadAllDataFromCategoryTable()
        {
            DataTable dTable = new DataTable();
            String sqlQuery;
            Connect();
            try
            {
                sqlQuery = String.Format("SELECT * FROM Категории");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            return dTable;
        }

        public void UpdateCategory(string name, long id)
        {
            Connect();
            try
            {
                string commandText = String.Format("UPDATE Категории SET Название = '{0}' WHERE id = {1}", 
                    name, id);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public void DeleteCategory(long id)
        {
            Connect();
            try
            {
                string commandText = String.Format("DELETE FROM Категории " +
                    "WHERE id = '{0}'", id);
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
        }

        public DataTable GetCategory(string name)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;
            Connect();
            try
            {
                sqlQuery = String.Format("SELECT * FROM Категории WHERE Название = '{0}'", name);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Disconnect();
            return dTable;
        }
    }
}
