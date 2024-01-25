namespace TODORA
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMainMnu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabIndicator = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.Button();
            this.tabMeeting = new System.Windows.Forms.Button();
            this.tabHobby = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabResearch = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabAssignment = new System.Windows.Forms.Button();
            this.tabALL = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTask = new System.Windows.Forms.ListBox();
            this.txtTask = new MetroFramework.Controls.MetroTextBox();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.timerStartUp = new System.Windows.Forms.Timer(this.components);
            this.panelMainMnu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMnu
            // 
            this.panelMainMnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.panelMainMnu.Controls.Add(this.panel2);
            this.panelMainMnu.Controls.Add(this.panel4);
            this.panelMainMnu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMnu.Location = new System.Drawing.Point(5, 60);
            this.panelMainMnu.Name = "panelMainMnu";
            this.panelMainMnu.Size = new System.Drawing.Size(165, 573);
            this.panelMainMnu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 528);
            this.panel2.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.BackgroundImage = global::Todora.Properties.Resources.BG2;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.Controls.Add(this.tabIndicator);
            this.panelMenu.Controls.Add(this.tabOther);
            this.panelMenu.Controls.Add(this.tabMeeting);
            this.panelMenu.Controls.Add(this.tabHobby);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.tabResearch);
            this.panelMenu.Controls.Add(this.tabReport);
            this.panelMenu.Controls.Add(this.btnReset);
            this.panelMenu.Controls.Add(this.tabAssignment);
            this.panelMenu.Controls.Add(this.tabALL);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(162, 528);
            this.panelMenu.TabIndex = 1;
            // 
            // tabIndicator
            // 
            this.tabIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(117)))), ((int)(((byte)(153)))));
            this.tabIndicator.Location = new System.Drawing.Point(1, 1);
            this.tabIndicator.Name = "tabIndicator";
            this.tabIndicator.Size = new System.Drawing.Size(16, 52);
            this.tabIndicator.TabIndex = 2;
            // 
            // tabOther
            // 
            this.tabOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabOther.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabOther.FlatAppearance.BorderSize = 0;
            this.tabOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabOther.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOther.ForeColor = System.Drawing.Color.Silver;
            this.tabOther.Location = new System.Drawing.Point(0, 312);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabOther.Size = new System.Drawing.Size(162, 52);
            this.tabOther.TabIndex = 14;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = false;
            this.tabOther.Click += new System.EventHandler(this.tabOther_Click);
            // 
            // tabMeeting
            // 
            this.tabMeeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabMeeting.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMeeting.FlatAppearance.BorderSize = 0;
            this.tabMeeting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabMeeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMeeting.ForeColor = System.Drawing.Color.Silver;
            this.tabMeeting.Location = new System.Drawing.Point(0, 260);
            this.tabMeeting.Name = "tabMeeting";
            this.tabMeeting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabMeeting.Size = new System.Drawing.Size(162, 52);
            this.tabMeeting.TabIndex = 13;
            this.tabMeeting.Text = "Meetings";
            this.tabMeeting.UseVisualStyleBackColor = false;
            this.tabMeeting.Click += new System.EventHandler(this.tabMeetings_Click);
            // 
            // tabHobby
            // 
            this.tabHobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabHobby.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabHobby.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabHobby.FlatAppearance.BorderSize = 0;
            this.tabHobby.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabHobby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabHobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabHobby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHobby.ForeColor = System.Drawing.Color.Silver;
            this.tabHobby.Location = new System.Drawing.Point(0, 208);
            this.tabHobby.Name = "tabHobby";
            this.tabHobby.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabHobby.Size = new System.Drawing.Size(162, 52);
            this.tabHobby.TabIndex = 12;
            this.tabHobby.Text = "Hobbies";
            this.tabHobby.UseVisualStyleBackColor = false;
            this.tabHobby.Click += new System.EventHandler(this.tabHobbies_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(163)))), ((int)(((byte)(214)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(7, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabResearch
            // 
            this.tabResearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabResearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabResearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabResearch.FlatAppearance.BorderSize = 0;
            this.tabResearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabResearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabResearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResearch.ForeColor = System.Drawing.Color.Silver;
            this.tabResearch.Location = new System.Drawing.Point(0, 156);
            this.tabResearch.Name = "tabResearch";
            this.tabResearch.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabResearch.Size = new System.Drawing.Size(162, 52);
            this.tabResearch.TabIndex = 7;
            this.tabResearch.Text = "Researches";
            this.tabResearch.UseVisualStyleBackColor = false;
            this.tabResearch.Click += new System.EventHandler(this.tabResearch_Click);
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabReport.FlatAppearance.BorderSize = 0;
            this.tabReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReport.ForeColor = System.Drawing.Color.Silver;
            this.tabReport.Location = new System.Drawing.Point(0, 104);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabReport.Size = new System.Drawing.Size(162, 52);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = false;
            this.tabReport.Click += new System.EventHandler(this.tabReport_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReset.Location = new System.Drawing.Point(7, 471);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 36);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabAssignment
            // 
            this.tabAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabAssignment.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabAssignment.FlatAppearance.BorderSize = 0;
            this.tabAssignment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabAssignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAssignment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAssignment.ForeColor = System.Drawing.Color.Silver;
            this.tabAssignment.Location = new System.Drawing.Point(0, 52);
            this.tabAssignment.Name = "tabAssignment";
            this.tabAssignment.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabAssignment.Size = new System.Drawing.Size(162, 52);
            this.tabAssignment.TabIndex = 2;
            this.tabAssignment.Text = "Assignments";
            this.tabAssignment.UseVisualStyleBackColor = false;
            this.tabAssignment.Click += new System.EventHandler(this.tabAssignment_Click);
            // 
            // tabALL
            // 
            this.tabALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.tabALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabALL.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabALL.FlatAppearance.BorderSize = 0;
            this.tabALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.tabALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.tabALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabALL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabALL.ForeColor = System.Drawing.Color.Silver;
            this.tabALL.Location = new System.Drawing.Point(0, 0);
            this.tabALL.Name = "tabALL";
            this.tabALL.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabALL.Size = new System.Drawing.Size(162, 52);
            this.tabALL.TabIndex = 1;
            this.tabALL.Text = "All tasks";
            this.tabALL.UseVisualStyleBackColor = false;
            this.tabALL.Click += new System.EventHandler(this.tabALL_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 45);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(121, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 46);
            this.label5.TabIndex = 23;
            this.label5.Text = "☰";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 45);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelBody.BackgroundImage = global::Todora.Properties.Resources.BG2;
            this.panelBody.Controls.Add(this.label4);
            this.panelBody.Controls.Add(this.label3);
            this.panelBody.Controls.Add(this.lstTask);
            this.panelBody.Controls.Add(this.txtTask);
            this.panelBody.Controls.Add(this.cmbType);
            this.panelBody.Controls.Add(this.dateTimePicker);
            this.panelBody.Controls.Add(this.btnSend);
            this.panelBody.Controls.Add(this.label2);
            this.panelBody.Controls.Add(this.button1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(170, 60);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(783, 573);
            this.panelBody.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(322, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(19, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date :";
            // 
            // lstTask
            // 
            this.lstTask.BackColor = System.Drawing.Color.Black;
            this.lstTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.lstTask.FormattingEnabled = true;
            this.lstTask.HorizontalScrollbar = true;
            this.lstTask.ItemHeight = 26;
            this.lstTask.Location = new System.Drawing.Point(19, 60);
            this.lstTask.Name = "lstTask";
            this.lstTask.Size = new System.Drawing.Size(743, 366);
            this.lstTask.TabIndex = 20;
            // 
            // txtTask
            // 
            // 
            // 
            // 
            this.txtTask.CustomButton.Image = null;
            this.txtTask.CustomButton.Location = new System.Drawing.Point(470, 2);
            this.txtTask.CustomButton.Name = "";
            this.txtTask.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtTask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTask.CustomButton.TabIndex = 1;
            this.txtTask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTask.CustomButton.UseSelectable = true;
            this.txtTask.CustomButton.Visible = false;
            this.txtTask.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTask.Lines = new string[0];
            this.txtTask.Location = new System.Drawing.Point(100, 501);
            this.txtTask.MaxLength = 32767;
            this.txtTask.Name = "txtTask";
            this.txtTask.PasswordChar = '\0';
            this.txtTask.PromptText = "Enter your task here";
            this.txtTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTask.SelectedText = "";
            this.txtTask.SelectionLength = 0;
            this.txtTask.SelectionStart = 0;
            this.txtTask.ShortcutsEnabled = true;
            this.txtTask.Size = new System.Drawing.Size(502, 34);
            this.txtTask.TabIndex = 17;
            this.txtTask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTask.UseCustomForeColor = true;
            this.txtTask.UseSelectable = true;
            this.txtTask.WaterMark = "Enter your task here";
            this.txtTask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTask_KeyDown);
            // 
            // cmbType
            // 
            this.cmbType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbType.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 19;
            this.cmbType.Items.AddRange(new object[] {
            "Assignment",
            "Report",
            "Research",
            "Hobby",
            "Meeting",
            "Other"});
            this.cmbType.Location = new System.Drawing.Point(397, 438);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(144, 25);
            this.cmbType.TabIndex = 15;
            this.cmbType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbType.UseCustomForeColor = true;
            this.cmbType.UseSelectable = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimePicker.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(101, 439);
            this.dateTimePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(164, 26);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateTimePicker.UseCustomForeColor = true;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(163)))), ((int)(((byte)(214)))));
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(641, 500);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 34);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(19, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::Todora.Properties.Resources.BG3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(783, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tasks";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold);
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.labelVersion.Location = new System.Drawing.Point(17, 636);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(153, 24);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "TODORA v2.0.3";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.labelCopyright.Location = new System.Drawing.Point(346, 636);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(296, 24);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "github.com/pahasara/todora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(379, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "TODORA v2.0";
            // 
            // titleLogo
            // 
            this.titleLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLogo.Image = ((System.Drawing.Image)(resources.GetObject("titleLogo.Image")));
            this.titleLogo.Location = new System.Drawing.Point(4, 7);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(49, 48);
            this.titleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleLogo.TabIndex = 10;
            this.titleLogo.TabStop = false;
            this.titleLogo.Click += new System.EventHandler(this.titleLogo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(856, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "GPL-3.0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(958, 668);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelMainMnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 35);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMainMnu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMainMnu;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tabIndicator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tabALL;
        private System.Windows.Forms.Button tabReport;
        private System.Windows.Forms.Button tabAssignment;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button tabResearch;
        private MetroFramework.Controls.MetroDateTime dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox titleLogo;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroTextBox txtTask;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button tabHobby;
        private System.Windows.Forms.Button tabOther;
        private System.Windows.Forms.Button tabMeeting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerStartUp;
    }
}

