namespace ABCEnrollmentSystem.Forms
{
    partial class ReportsForm
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
            this.lblReport = new System.Windows.Forms.Label();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtSchoolYear = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
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
            this.lblPageTitle.Size = new System.Drawing.Size(160, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Summary Reports";
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
            this.pnlContent.Controls.Add(this.txtOutput);
            this.pnlContent.Controls.Add(this.btnShow);
            this.pnlContent.Controls.Add(this.txtSchoolYear);
            this.pnlContent.Controls.Add(this.lblYear);
            this.pnlContent.Controls.Add(this.cboReport);
            this.pnlContent.Controls.Add(this.lblReport);
            this.pnlContent.Location = new System.Drawing.Point(200, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 560);
            this.pnlContent.TabIndex = 2;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblReport.Location = new System.Drawing.Point(20, 19);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(45, 15);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = "Report:";
            // 
            // cboReport
            // 
            this.cboReport.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReport.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Items.AddRange(new object[] {
            "Class List per Section",
            "Class List per Subject",
            "Subjects Assigned to Teachers"});
            this.cboReport.Location = new System.Drawing.Point(80, 15);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(260, 23);
            this.cboReport.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.lblYear.Location = new System.Drawing.Point(360, 19);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(146, 15);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "School year (blank = all):";
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSchoolYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolYear.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSchoolYear.Location = new System.Drawing.Point(515, 15);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.Size = new System.Drawing.Size(100, 23);
            this.txtSchoolYear.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnShow.Location = new System.Drawing.Point(630, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 30);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtOutput.Location = new System.Drawing.Point(20, 55);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(760, 485);
            this.txtOutput.TabIndex = 3;
            // 
            // ReportsForm
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
            this.Name = "ReportsForm";
            this.Text = "Summary Reports";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
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
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtSchoolYear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtOutput;
    }
}