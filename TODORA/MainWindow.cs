using System;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TODORA
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int isOnlyFinished  = 2;

        // Import DwmApi to set TITLE bar DARK
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        // To Open a sqlConnection
        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: CreateConnection");
            }
            return conn;
        }

        private void insertData()
        {
            try
            {
                SQLiteConnection conn;
                conn = CreateConnection();
                SQLiteCommand sql_cmd;
                sql_cmd = conn.CreateCommand();
                string date = getDate();
                string values = date + "', '" + txtTask.Text + "', '" + getTaskType(comboTaskType.SelectedIndex) + "' , '0";

                sql_cmd.CommandText = "INSERT INTO TaskList (Date, Task, Type, Status) VALUES('" + values + "');";
                sql_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void readData(string str = ";")
        {
            if (str == ";" && isOnlyFinished == 1)
            {
                str = " WHERE Status = '1'";
            }
            else if (str == ";" && isOnlyFinished == 0)
            {
                str = " WHERE Status = '0'";
            }

            SQLiteConnection conn;
            conn = CreateConnection();
            SQLiteDataReader sql_datareader;
            SQLiteCommand sql_cmd;
            sql_cmd = conn.CreateCommand();
            sql_cmd.CommandText = "SELECT * FROM TaskList" + str;
            sql_datareader = sql_cmd.ExecuteReader();

            taskList.Items.Clear();

            while (sql_datareader.Read())
            {
                string task = "";
                task += "#" + sql_datareader.GetInt32(0).ToString(); // #1
                task += " - " + sql_datareader.GetString(1); // 12/15/2023
                task += " - " + sql_datareader.GetString(2); // Clean my room
                task += " - " + sql_datareader.GetString(3); // Other
                taskList.Items.Add(task);
            }
            conn.Close();
        }

        private void deleteData()
        {
            try
            {
                SQLiteConnection conn;
                conn = CreateConnection();
                SQLiteCommand sql_cmd;
                sql_cmd = conn.CreateCommand();
                sql_cmd.CommandText = "DELETE FROM TaskList;";
                sql_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void deleteTasks()
        {
            taskList.Items.Clear();
        }

        private string getTaskType(int index)
        {
            string taskType;
            switch (index)
            {
                case 1:
                    taskType = "Report";
                    break;
                case 2:
                    taskType = "Research";
                    break;
                case 3:
                    taskType = "Other";
                    break;
                default:
                    taskType = "Assignment";
                    break;
            }
            return taskType;
        }

        private string getDate()
        {
            string date = datePicker.Value.ToShortDateString();
            return date;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertData();
            txtTask.Clear();
            readData();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            readData();
            if (taskList.Items.Count == 0)
            {
                taskList.Items.Add("Nothing is here.... Add new tasks...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deleteTasks();
            deleteData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    SQLiteConnection conn;
                    conn = CreateConnection();
                    SQLiteCommand sql_cmd;
                    sql_cmd = conn.CreateCommand();
                    sql_cmd.CommandText = "DELETE FROM TaskList WHERE ID = " + txtID.Text + ";";
                    sql_cmd.ExecuteNonQuery();
                    txtID.Clear();
                    readData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    SQLiteConnection conn;
                    conn = CreateConnection();
                    SQLiteCommand sql_cmd;
                    sql_cmd = conn.CreateCommand();
                    sql_cmd.CommandText = "UPDATE TaskList SET Status = '1' WHERE ID = " + txtID.Text + ";";
                    sql_cmd.ExecuteNonQuery();
                    txtID.Clear();
                    readData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void tabALL_Click(object sender, EventArgs e)
        {
            isOnlyFinished = 2;
            tabIndicator.Location = tabALL.Location;
            tabIndicator.BackColor = Color.Silver;
            tabALL.BackColor = Color.FromArgb(64,64,64);
            tabFinished.BackColor = Color.FromArgb(18, 18, 18);
            tabUnfinished.BackColor = Color.FromArgb(18, 18, 18);
            readData();
        }

        private void tabFinished_Click(object sender, EventArgs e)
        {
            isOnlyFinished = 1;
            tabIndicator.Location = tabFinished.Location;
            tabIndicator.BackColor = Color.FromArgb(27, 158, 26);
            tabFinished.BackColor = Color.FromArgb(14, 60, 19);
            tabALL.BackColor = Color.FromArgb(18, 18, 18);
            tabUnfinished.BackColor = Color.FromArgb(18, 18, 18);
            readData(" WHERE Status = '1'");
        }

        private void tabUnfinished_Click(object sender, EventArgs e)
        {
            isOnlyFinished = 0;
            tabIndicator.Location = tabUnfinished.Location;
            tabIndicator.BackColor = Color.FromArgb(255, 0, 0);
            tabUnfinished.BackColor = Color.FromArgb(60, 6, 1);
            tabFinished.BackColor = Color.FromArgb(18, 18, 18);
            tabALL.BackColor = Color.FromArgb(18, 18, 18);
            readData(" WHERE Status = '0'");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
