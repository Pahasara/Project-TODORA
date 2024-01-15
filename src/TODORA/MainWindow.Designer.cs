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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMainMnu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.taskList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabIndicator = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.Button();
            this.tabResearch = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabAssignment = new System.Windows.Forms.Button();
            this.tabALL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.panelMainMnu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMnu
            // 
            this.panelMainMnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.panelMainMnu.Controls.Add(this.panel2);
            this.panelMainMnu.Controls.Add(this.panel4);
            this.panelMainMnu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMnu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMnu.Name = "panelMainMnu";
            this.panelMainMnu.Size = new System.Drawing.Size(165, 558);
            this.panelMainMnu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 513);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 45);
            this.panel4.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelBody.BackgroundImage = global::Todora.Properties.Resources.BG2;
            this.panelBody.Controls.Add(this.txtID);
            this.panelBody.Controls.Add(this.btnDelete);
            this.panelBody.Controls.Add(this.datePicker);
            this.panelBody.Controls.Add(this.comboTaskType);
            this.panelBody.Controls.Add(this.btnAdd);
            this.panelBody.Controls.Add(this.label2);
            this.panelBody.Controls.Add(this.txtTask);
            this.panelBody.Controls.Add(this.taskList);
            this.panelBody.Controls.Add(this.button1);
            this.panelBody.Controls.Add(this.label6);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(165, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(697, 558);
            this.panelBody.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Black;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(490, 506);
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(71, 31);
            this.txtID.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(579, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 34);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.datePicker.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(44, 508);
            this.datePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 26);
            this.datePicker.TabIndex = 11;
            // 
            // comboTaskType
            // 
            this.comboTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.comboTaskType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTaskType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTaskType.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            "Assignment",
            "Report",
            "Research",
            "Other"});
            this.comboTaskType.Location = new System.Drawing.Point(202, 508);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(133, 26);
            this.comboTaskType.TabIndex = 9;
            this.comboTaskType.Text = "Assignment";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(163)))), ((int)(((byte)(214)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(578, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(7, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Task:";
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.Black;
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(175)))), ((int)(((byte)(215)))));
            this.txtTask.Location = new System.Drawing.Point(77, 454);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(487, 31);
            this.txtTask.TabIndex = 3;
            // 
            // taskList
            // 
            this.taskList.BackColor = System.Drawing.Color.Black;
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.taskList.HideSelection = false;
            this.taskList.Location = new System.Drawing.Point(14, 59);
            this.taskList.MultiSelect = false;
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(663, 375);
            this.taskList.TabIndex = 1;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.List;
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
            this.button1.Size = new System.Drawing.Size(697, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tasks";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(373, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID (delete):";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.BackgroundImage = global::Todora.Properties.Resources.BG2;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.Controls.Add(this.tabIndicator);
            this.panelMenu.Controls.Add(this.tabOther);
            this.panelMenu.Controls.Add(this.tabResearch);
            this.panelMenu.Controls.Add(this.tabReport);
            this.panelMenu.Controls.Add(this.btnReset);
            this.panelMenu.Controls.Add(this.tabAssignment);
            this.panelMenu.Controls.Add(this.tabALL);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(162, 513);
            this.panelMenu.TabIndex = 1;
            // 
            // tabIndicator
            // 
            this.tabIndicator.BackColor = System.Drawing.Color.Silver;
            this.tabIndicator.Location = new System.Drawing.Point(1, 1);
            this.tabIndicator.Name = "tabIndicator";
            this.tabIndicator.Size = new System.Drawing.Size(16, 51);
            this.tabIndicator.TabIndex = 2;
            // 
            // tabOther
            // 
            this.tabOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabOther.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabOther.FlatAppearance.BorderSize = 0;
            this.tabOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(31)))), ((int)(((byte)(123)))));
            this.tabOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabOther.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOther.ForeColor = System.Drawing.Color.Silver;
            this.tabOther.Location = new System.Drawing.Point(0, 208);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabOther.Size = new System.Drawing.Size(162, 52);
            this.tabOther.TabIndex = 5;
            this.tabOther.Text = "Other";
            this.tabOther.UseVisualStyleBackColor = false;
            this.tabOther.Click += new System.EventHandler(this.tabOther_Click);
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
            this.tabResearch.TabIndex = 4;
            this.tabResearch.Text = "Research";
            this.tabResearch.UseVisualStyleBackColor = false;
            this.tabResearch.Click += new System.EventHandler(this.tabResearch_Click);
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.tabReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabReport.FlatAppearance.BorderSize = 0;
            this.tabReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(6)))), ((int)(((byte)(1)))));
            this.tabReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(1)))));
            this.tabReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReport.ForeColor = System.Drawing.Color.Silver;
            this.tabReport.Location = new System.Drawing.Point(0, 104);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabReport.Size = new System.Drawing.Size(162, 52);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Report";
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
            this.tabAssignment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(80)))), ((int)(((byte)(19)))));
            this.tabAssignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(110)))), ((int)(((byte)(19)))));
            this.tabAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAssignment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAssignment.ForeColor = System.Drawing.Color.Silver;
            this.tabAssignment.Location = new System.Drawing.Point(0, 52);
            this.tabAssignment.Name = "tabAssignment";
            this.tabAssignment.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tabAssignment.Size = new System.Drawing.Size(162, 52);
            this.tabAssignment.TabIndex = 2;
            this.tabAssignment.Text = "Assignment";
            this.tabAssignment.UseVisualStyleBackColor = false;
            this.tabAssignment.Click += new System.EventHandler(this.tabAssignment_Click);
            // 
            // tabALL
            // 
            this.tabALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabALL.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabALL.FlatAppearance.BorderSize = 0;
            this.tabALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tabALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::Todora.Properties.Resources.BG3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 45);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.BackgroundImage = global::Todora.Properties.Resources.BG3;
            this.panelBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBottom.Controls.Add(this.labelVersion);
            this.panelBottom.Controls.Add(this.labelCopyright);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 558);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(862, 46);
            this.panelBottom.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold);
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.labelVersion.Location = new System.Drawing.Point(44, 12);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(76, 24);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v2.0.1";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(163)))), ((int)(((byte)(204)))));
            this.labelCopyright.Location = new System.Drawing.Point(205, 12);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(549, 24);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright ©2024 TEAM BISHOP. All rights reserved.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(862, 604);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelMainMnu);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODORA v2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMainMnu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMainMnu;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tabIndicator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button tabALL;
        private System.Windows.Forms.Button tabReport;
        private System.Windows.Forms.Button tabAssignment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button tabOther;
        private System.Windows.Forms.Button tabResearch;
    }
}

