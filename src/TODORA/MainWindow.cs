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

        private void resetTable()
        {
            if (MessageBox.Show("All data will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    SQLiteConnection conn;
                    conn = CreateConnection();
                    SQLiteCommand sql_cmd;
                    sql_cmd = conn.CreateCommand();
                    sql_cmd.CommandText = "DELETE FROM TaskList;";
                    sql_cmd.ExecuteNonQuery();
                    sql_cmd.CommandText = "UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='TaskList';";
                    sql_cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
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
            this.Opacity = 0.95;
            readData();
            if (taskList.Items.Count == 0)
            {
                taskList.Items.Add("Nothing to do...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deleteTasks();
            resetTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show($"Task #{txtID.Text} will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
            tabIndicator.Location = tabALL.Location;
            tabIndicator.BackColor = Color.Silver;
            tabALL.BackColor = Color.FromArgb(64,64,64);
            tabAssignment.BackColor = Color.FromArgb(12, 12, 12);
            tabOther.BackColor = Color.FromArgb(12, 12, 12);
            tabResearch.BackColor = Color.FromArgb(12, 12, 12);
            tabReport.BackColor = Color.FromArgb(12, 12, 12);
            readData();
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabAssignment_Click(object sender, EventArgs e)
        {
            tabIndicator.Location = tabAssignment.Location;
            tabIndicator.BackColor = Color.FromArgb(27, 158, 26);
            tabAssignment.BackColor = Color.FromArgb(14, 60, 19);
            tabALL.BackColor = Color.FromArgb(12, 12, 12);
            tabReport.BackColor = Color.FromArgb(12, 12, 12);
            tabOther.BackColor = Color.FromArgb(12, 12, 12);
            tabResearch.BackColor = Color.FromArgb(12, 12, 12);
            readData(" WHERE Type = 'Assignment'");
        }

        private void tabReport_Click(object sender, EventArgs e)
        {
            tabIndicator.Location = tabReport.Location;
            tabIndicator.BackColor = Color.FromArgb(255, 0, 0);
            tabReport.BackColor = Color.FromArgb(60, 6, 1);
            tabAssignment.BackColor = Color.FromArgb(12, 12, 12);
            tabOther.BackColor = Color.FromArgb(12, 12, 12);
            tabResearch.BackColor = Color.FromArgb(12, 12, 12);
            tabALL.BackColor = Color.FromArgb(12, 12, 12);
            readData(" WHERE Type = 'Report'");
        }

        private void tabResearch_Click(object sender, EventArgs e)
        {
            tabIndicator.Location = tabResearch.Location;
            tabIndicator.BackColor = Color.FromArgb(6, 117, 153);
            tabResearch.BackColor = Color.FromArgb(3, 36, 53);
            tabAssignment.BackColor = Color.FromArgb(12, 12, 12);
            tabALL.BackColor = Color.FromArgb(12, 12, 12);
            tabOther.BackColor = Color.FromArgb(12, 12, 12);
            tabReport.BackColor = Color.FromArgb(12, 12, 12);
            readData(" WHERE Type = 'Research'");
        }

        private void tabOther_Click(object sender, EventArgs e)
        {
            tabIndicator.Location = tabOther.Location;
            tabIndicator.BackColor = Color.MediumSlateBlue;
            tabOther.BackColor = Color.FromArgb(41, 36, 74);
            tabAssignment.BackColor = Color.FromArgb(12, 12, 12);
            tabResearch.BackColor = Color.FromArgb(12, 12, 12);
            tabReport.BackColor = Color.FromArgb(12, 12, 12);
            tabALL.BackColor = Color.FromArgb(12, 12, 12);
            readData(" WHERE Type = 'Other'");
        }
    }
}
