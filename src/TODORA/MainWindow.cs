using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todora;

namespace TODORA
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Core core = new Core();
        string selectedType = ""; // Selected Tab (All tasks/Report/...)

        private void SetType(string type = "")
        {
            selectedType = type;
        }

        private void ClearTasks()
        {
            lstTask.Items.Clear();
        }

        private void ReadData(string sqlCommand, string selectedType)
        {
            SQLiteConnection conn = Core.CreateConnection();
            SQLiteCommand sql_cmd = conn.CreateCommand();
            SQLiteDataReader sql_datareader;
            string formattedTask;
            try
            {

                sql_cmd.CommandText = sqlCommand;
                sql_datareader = sql_cmd.ExecuteReader();
                while (sql_datareader.Read())
                {
                    string date = sql_datareader.GetString(1).Replace('/', '-').PadLeft(10, ' ');
                    string task = sql_datareader.GetString(2);
                    if (selectedType == "")
                    {
                        string type = sql_datareader.GetString(3);
                        formattedTask = $"{date}  |  {task}     <{type}>\n";
                    }
                    else
                    {
                        formattedTask = $"{date}  |  {task}\n";
                    }
                    lstTask.Items.Add(formattedTask);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Reading Error");
            }
        }

        private void Read(bool isDateChanged = false)
        {
            string selectedDate = dateTimePicker.Value.ToShortDateString();
            string sqlCommand = core.SelectData(selectedType, selectedDate, isDateChanged);
            ClearTasks();
            ReadData(sqlCommand, selectedType);
        }

        private void Send()
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                string date = dateTimePicker.Value.ToShortDateString();
                string task = txtTask.Text.Trim();
                string type = cmbType.SelectedItem.ToString();
                core.InsertData(date, task, type);
                txtTask.Clear();
                Read();
            }
            else
            {
                MessageBox.Show("Please enter a valid task before saving.", "Validation Error");
            }
        }

        private void Delete()
        {
            string selectedItem = lstTask.SelectedItem.ToString();
            string taskToBeDeleted = core.GetTaskToDelete(selectedItem);
            core.DeleteTask(taskToBeDeleted);
            Read();
        }

        private void Reset()
        {
            if (MessageBox.Show("All data in this tab will be deleted. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (core.ResetData(selectedType))
                {
                    ClearTasks();
                }
            }
        }

        private void ValidateDelete()
        {
            if (lstTask.SelectedItems.Count > 0 && lstTask.SelectedItem.ToString() != "Nothing to do...")
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void ValidateSend()
        {
            if (txtTask.Text != "")
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cmbType.SelectedIndex = 0;
            Read();
            if (lstTask.Items.Count == 0)
            {
                lstTask.Items.Add("Nothing to do...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ValidateDelete();
            ValidateSend();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
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
            Read();
        }

        private void tabAssignment_Click(object sender, EventArgs e)
        {
            SetType("Assignment");
            SetTab(tabAssignment);
            cmbType.SelectedIndex = 0;
            Read();
        }

        private void tabReport_Click(object sender, EventArgs e)
        {
            SetType("Report");
            SetTab(tabReport);
            cmbType.SelectedIndex = 1;
            Read();
        }

        private void tabResearch_Click(object sender, EventArgs e)
        {
            SetType("Research");
            SetTab(tabResearch);
            cmbType.SelectedIndex = 2;
            Read();
        }

        private void tabOther_Click(object sender, EventArgs e)
        {
            SetType("Other");
            SetTab(tabOther);
            cmbType.SelectedIndex = 5;
            Read();
        }

        private void tabHobbies_Click(object sender, EventArgs e)
        {
            SetType("Hobby");
            SetTab(tabHobby);
            cmbType.SelectedIndex = 3;
            Read();
        }

        private void tabMeetings_Click(object sender, EventArgs e)
        {
            SetType("Meeting");
            SetTab(tabMeeting);
            cmbType.SelectedIndex = 4;
            Read();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Read(true);
        }

        private void titleLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/pahasara/todora");
        }

        private void txtTask_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }
    }
}
