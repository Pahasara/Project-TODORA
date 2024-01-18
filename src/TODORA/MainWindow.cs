using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace TODORA
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string selectedType = ""; // Selected Tab (All tasks/Report/...)

        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while connecting to the database. If the problem persists, please report the issue on GitHub: github.com/pahasara/todora/issues", "CreateConnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        private void SetType(string type = "")
        {
            selectedType = type;
        }

        private void InsertData()
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            string values = $"'{dateTimePicker.Value.ToShortDateString()}', '{txtTask.Text}', '{cmbType.SelectedItem}'";
            try
            {
                sql_cmd.CommandText = $"INSERT INTO TaskList (Date, Task, Type) VALUES({values});";
                sql_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InsertData");
            }
        }

        private string GetTaskType()
        {
            if (selectedType != "")
            {
                return $" WHERE Type = '{selectedType}';";
            }
            else
            {
                return ";";
            }
        }

        private void ReadData()
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            SQLiteDataReader sql_datareader;

            try
            {
                sql_cmd.CommandText = "SELECT * FROM TaskList" + GetTaskType();
                sql_datareader = sql_cmd.ExecuteReader();
                lstTask.Items.Clear();

                while (sql_datareader.Read())
                {
                    string id = sql_datareader.GetInt32(0).ToString().PadLeft(3, '0');
                    string task = sql_datareader.GetString(2);
                    string type = sql_datareader.GetString(3);
                    string date = sql_datareader.GetString(1).Replace('/', '-');

                    string formattedTask = $"{id}  |  {task}        <{type}>        [{date}]\n";
                    lstTask.Items.Add(formattedTask);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ReadData");
            }
        }

        private void ResetData()
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
                ClearTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Couldn't reset");
            }
        }

        private void DeleteTask(int index)
        {
            SQLiteConnection conn = CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            if (MessageBox.Show(this, "Task " + index.ToString().PadLeft(3, '0') + " will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql_cmd = conn.CreateCommand();
                    sql_cmd.CommandText = $"DELETE FROM TaskList WHERE ID = {index};";
                    sql_cmd.ExecuteNonQuery();
                    ReadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "DeleteTask");
                }
            }
        }

        private void ClearTasks()
        {
            lstTask.Items.Clear();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cmbType.SelectedIndex = 0;

            ReadData();
            if (lstTask.Items.Count == 0)
            {
                lstTask.Items.Add("Nothing to do...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data in this tab will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ResetData();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Validate btnDelete
            if (lstTask.SelectedItems.Count > 0 && lstTask.SelectedItem.ToString() != "Nothing to do...")
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }

            // Validate btnSend
            if (txtTask.Text != "")
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string task = lstTask.SelectedItem.ToString();
            int charPos = task.IndexOf("#");
            task = task.Substring(charPos + 1);

            string index = "";

            foreach (char x in task)
            {
                if (x == ' ')
                {
                    break;
                }
                if (x == '#')
                {
                    continue;
                }
                index += x;
            }
            DeleteTask(Convert.ToInt32(index));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                InsertData();
                txtTask.Clear();
                ReadData();
            }
            else
            {
                MessageBox.Show("Please enter a valid task before saving.", "Validation Error");
            }
        }

        private void SetTab(Button btn)
        {
            tabResearch.BackColor = Color.FromArgb(12, 12, 12);
            tabAssignment.BackColor = Color.FromArgb(12, 12, 12);
            tabALL.BackColor = Color.FromArgb(12, 12, 12);
            tabOther.BackColor = Color.FromArgb(12, 12, 12);
            tabReport.BackColor = Color.FromArgb(12, 12, 12);
            tabHobby.BackColor = Color.FromArgb(12, 12, 12);
            tabMeeting.BackColor = Color.FromArgb(12, 12, 12);
            tabIndicator.Location = btn.Location;
            btn.BackColor = Color.FromArgb(3, 36, 53);
        }

        private void tabALL_Click(object sender, EventArgs e)
        {
            SetType();
            SetTab(tabALL);
            ReadData();
        }

        private void tabAssignment_Click(object sender, EventArgs e)
        {
            SetType("Assignment");
            SetTab(tabAssignment);
            cmbType.SelectedIndex = 0;
            ReadData();
        }

        private void tabReport_Click(object sender, EventArgs e)
        {
            SetType("Report");
            SetTab(tabReport);
            cmbType.SelectedIndex = 1;
            ReadData();
        }

        private void tabResearch_Click(object sender, EventArgs e)
        {
            SetType("Research");
            SetTab(tabResearch);
            cmbType.SelectedIndex = 2;
            ReadData();
        }

        private void tabOther_Click(object sender, EventArgs e)
        {
            SetType("Other");
            SetTab(tabOther);
            cmbType.SelectedIndex = 5;
            ReadData();
        }

        private void tabHobbies_Click(object sender, EventArgs e)
        {
            SetType("Hobby");
            SetTab(tabHobby);
            cmbType.SelectedIndex = 3;
            ReadData();
        }

        private void tabMeetings_Click(object sender, EventArgs e)
        {
            SetType("Meeting");
            SetTab(tabMeeting);
            cmbType.SelectedIndex = 4;
            ReadData();
        }
    }
}
