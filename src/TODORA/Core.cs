using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Todora
{
    public class Core
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                conn.Open();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("An error occurred while connecting to the database. If the problem persists, please report the issue on GitHub: github.com/pahasara/todora/issues", "CreateConnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public string SelectData(string selectedType, string selectedDate, bool isDateChanged = false)
        {
            if (!isDateChanged)
            {
                if (selectedType == "")
                {
                    return $"SELECT * FROM TaskList;";
                }
                else
                {
                    return $"SELECT * FROM TaskList WHERE Type = '{selectedType}';";
                }
            }
            else
            {
                string date = selectedDate;
                if (selectedType == "")
                {
                    return $"SELECT * FROM TaskList WHERE Date = '{date}';";
                }
                else
                {
                    return $"SELECT * FROM TaskList WHERE Date = '{date}' AND Type = '{selectedType}';";

                }
            }
        }

        public void InsertData(string date, string task, string type)
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            string values = $"\"{date}\", \"{task}\", \"{type}\"";
            try
            {
                sql_cmd.CommandText = $"INSERT INTO TaskList (Date, Task, Type) VALUES({values});";
                sql_cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Couldn't insert data");
            }
        }

        public string GetTaskToDelete(string selectedItem)
        {
            string fullTask = selectedItem;
            int strPosition = fullTask.IndexOf("  |") + 5;
            fullTask = fullTask.Substring(strPosition);

            try
            {
                strPosition = fullTask.IndexOf("     <");
                if (strPosition > 0)
                {
                    MessageBox.Show(strPosition.ToString());
                    string remain = fullTask.Substring(strPosition);
                    fullTask = fullTask.Replace(remain, "");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "GTaskDel Error");
            }
            return fullTask.TrimEnd();
        }

        public void DeleteTask(string task)
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            if (MessageBox.Show($"Task '{task}' will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql_cmd = conn.CreateCommand();
                    sql_cmd.CommandText = $"DELETE FROM TaskList WHERE Task = \"{task}\";";
                    sql_cmd.ExecuteNonQuery();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't delete");
                }
            }
        }

        public bool ResetData(string selectedType)
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            try
            {
                sql_cmd.CommandText = "DELETE FROM TaskList";
                if (selectedType == "")
                {
                    sql_cmd.CommandText += ";UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='TaskList';";
                }
                else
                {
                    sql_cmd.CommandText += $" WHERE Type='{selectedType}';";
                }
                sql_cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Couldn't reset");
                return false;
            }
            return true;
        }
    }
}
