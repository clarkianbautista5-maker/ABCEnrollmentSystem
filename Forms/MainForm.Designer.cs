namespace ABCEnrollmentSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIn = new System.Windows.Forms.Label();
            this.cboSearchIn = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Controls.Add(this.lblSubtitle);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.btnSubjects);
            this.pnlSidebar.Controls.Add(this.btnTeachers);
            this.pnlSidebar.Controls.Add(this.btnSections);
            this.pnlSidebar.Controls.Add(this.btnEnroll);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblSchoolYear);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(105, 25);
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
            this.pnlContent.Controls.Add(this.lblSearch);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Controls.Add(this.lblSearchIn);
            this.pnlContent.Controls.Add(this.cboSearchIn);
            this.pnlContent.Controls.Add(this.btnSearch);
            this.pnlContent.Controls.Add(this.dgvResults);
            this.pnlContent.Controls.Add(this.lblFooter);
            this.pnlContent.Controls.Add(this.lblStatus);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.pnlContent.Location = new System.Drawing.Point(200, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 560);
            this.pnlContent.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 15);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSearch.Location = new System.Drawing.Point(80, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearchIn
            // 
            this.lblSearchIn.AutoSize = true;
            this.lblSearchIn.Location = new System.Drawing.Point(375, 19);
            this.lblSearchIn.Name = "lblSearchIn";
            this.lblSearchIn.Size = new System.Drawing.Size(20, 15);
            this.lblSearchIn.TabIndex = 5;
            this.lblSearchIn.Text = "in:";
            // 
            // cboSearchIn
            // 
            this.cboSearchIn.Items.AddRange(new object[] {
            "Students",
            "Teachers",
            "Subjects",
            "Sections"});
            this.cboSearchIn.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboSearchIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSearchIn.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboSearchIn.FormattingEnabled = true;
            this.cboSearchIn.Location = new System.Drawing.Point(400, 15);
            this.cboSearchIn.Name = "cboSearchIn";
            this.cboSearchIn.Size = new System.Drawing.Size(160, 23);
            this.cboSearchIn.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnSearch.Location = new System.Drawing.Point(575, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(127, 178, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDetails});
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.dgvResults.Location = new System.Drawing.Point(20, 55);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(760, 455);
            this.dgvResults.TabIndex = 3;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Details";
            this.colDetails.MinimumWidth = 6;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(154, 168, 199);
            this.lblFooter.Location = new System.Drawing.Point(20, 525);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(500, 15);
            this.lblFooter.TabIndex = 6;
            this.lblFooter.Text = "Search results will appear here.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(154, 168, 199);
            this.lblStatus.Location = new System.Drawing.Point(600, 525);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: Ready.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlContent);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Senior High - Enrollment System";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Label lblSearchIn;
        private System.Windows.Forms.ComboBox cboSearchIn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblStatus;
    }
}