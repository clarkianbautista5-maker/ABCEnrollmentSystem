namespace ABCEnrollmentSystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.colActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnEnroll);
            this.pnlSidebar.Controls.Add(this.btnSections);
            this.pnlSidebar.Controls.Add(this.btnTeachers);
            this.pnlSidebar.Controls.Add(this.btnSubjects);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblSubtitle);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 620);
            this.pnlSidebar.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(60, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblTitle.Location = new System.Drawing.Point(0, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 22);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "ABC Senior High";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblSubtitle.Location = new System.Drawing.Point(0, 132);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(200, 18);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Enrollment System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnDashboard.FlatAppearance.BorderSize = 1;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnDashboard.Location = new System.Drawing.Point(20, 175);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(160, 34);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnStudents.FlatAppearance.BorderSize = 1;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnStudents.Location = new System.Drawing.Point(20, 217);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(160, 34);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnSubjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnSubjects.FlatAppearance.BorderSize = 1;
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnSubjects.Location = new System.Drawing.Point(20, 259);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(160, 34);
            this.btnSubjects.TabIndex = 2;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.UseVisualStyleBackColor = false;
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnTeachers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnTeachers.FlatAppearance.BorderSize = 1;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnTeachers.Location = new System.Drawing.Point(20, 301);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(160, 34);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            // 
            // btnSections
            // 
            this.btnSections.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnSections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnSections.FlatAppearance.BorderSize = 1;
            this.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSections.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnSections.Location = new System.Drawing.Point(20, 343);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(160, 34);
            this.btnSections.TabIndex = 4;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = false;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnEnroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnEnroll.FlatAppearance.BorderSize = 1;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnEnroll.Location = new System.Drawing.Point(20, 385);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(160, 34);
            this.btnEnroll.TabIndex = 5;
            this.btnEnroll.Text = "Enroll a Student";
            this.btnEnroll.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(127, 178, 255);
            this.btnReports.FlatAppearance.BorderSize = 1;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnReports.Location = new System.Drawing.Point(20, 427);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(160, 34);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Summary Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnExit.FlatAppearance.BorderSize = 1;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnExit.Location = new System.Drawing.Point(20, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.pnlHeader.Controls.Add(this.lblSchoolYear);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(97, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = false;
            this.lblSchoolYear.ForeColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.lblSchoolYear.Location = new System.Drawing.Point(600, 18);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(180, 24);
            this.lblSchoolYear.TabIndex = 1;
            this.lblSchoolYear.Text = "S.Y. 2026-2027";
            this.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.Controls.Add(this.lblFooter);
            this.pnlContent.Controls.Add(this.dgvActivity);
            this.pnlContent.Controls.Add(this.btnExport);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Controls.Add(this.lblSearch);
            this.pnlContent.Location = new System.Drawing.Point(200, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 560);
            this.pnlContent.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblSearch.Location = new System.Drawing.Point(20, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSearch.Location = new System.Drawing.Point(80, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnExport.Location = new System.Drawing.Point(610, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 30);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Activity Log";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AllowUserToResizeRows = false;
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivity.BackgroundColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActivityType,
            this.colDescription,
            this.colUser,
            this.colDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(127, 178, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivity.EnableHeadersVisualStyles = false;
            this.dgvActivity.GridColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.dgvActivity.Location = new System.Drawing.Point(20, 55);
            this.dgvActivity.MultiSelect = false;
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivity.Size = new System.Drawing.Size(760, 455);
            this.dgvActivity.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = false;
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(154, 168, 199);
            this.lblFooter.Location = new System.Drawing.Point(20, 525);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(500, 15);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "Displaying last 50 activities.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(154, 168, 199);
            this.lblStatus.Location = new System.Drawing.Point(600, 525);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Ready.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colActivityType
            // 
            this.colActivityType.DataPropertyName = "ActivityType";
            this.colActivityType.HeaderText = "Activity Type";
            this.colActivityType.Name = "colActivityType";
            this.colActivityType.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "UserName";
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "ActivityDate";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDate.HeaderText = "Date & Time";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ABC Senior High - Enrollment System";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}