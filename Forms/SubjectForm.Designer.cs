namespace ABCEnrollmentSystem.Forms
{
    partial class SubjectForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.colSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
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
            this.lblPageTitle.Size = new System.Drawing.Size(85, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Subjects";
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
            this.pnlContent.Controls.Add(this.btnArchive);
            this.pnlContent.Controls.Add(this.btnUpdate);
            this.pnlContent.Controls.Add(this.btnAdd);
            this.pnlContent.Controls.Add(this.dgvSubjects);
            this.pnlContent.Controls.Add(this.btnShowAll);
            this.pnlContent.Controls.Add(this.btnSearch);
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
            this.lblSearch.Size = new System.Drawing.Size(187, 15);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search by Subject Code or Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSearch.Location = new System.Drawing.Point(215, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnSearch.Location = new System.Drawing.Point(475, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnShowAll.FlatAppearance.BorderSize = 1;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnShowAll.Location = new System.Drawing.Point(560, 13);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 27);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToResizeRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectCode,
            this.colSubjectName,
            this.colUnits,
            this.colTeacherId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(127, 178, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.GridColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.dgvSubjects.Location = new System.Drawing.Point(20, 55);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(760, 410);
            this.dgvSubjects.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnAdd.Location = new System.Drawing.Point(20, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnUpdate.FlatAppearance.BorderSize = 1;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnUpdate.Location = new System.Drawing.Point(120, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnArchive.Enabled = false;
            this.btnArchive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(242, 109, 109);
            this.btnArchive.FlatAppearance.BorderSize = 1;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.ForeColor = System.Drawing.Color.FromArgb(242, 109, 109);
            this.btnArchive.Location = new System.Drawing.Point(220, 480);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(90, 32);
            this.btnArchive.TabIndex = 6;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.DataPropertyName = "SubjectCode";
            this.colSubjectCode.HeaderText = "Code";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.ReadOnly = true;
            // 
            // colSubjectName
            // 
            this.colSubjectName.DataPropertyName = "SubjectName";
            this.colSubjectName.HeaderText = "Subject Name";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.ReadOnly = true;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Units";
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colTeacherId
            // 
            this.colTeacherId.DataPropertyName = "TeacherId";
            this.colTeacherId.HeaderText = "Teacher ID";
            this.colTeacherId.Name = "colTeacherId";
            this.colTeacherId.ReadOnly = true;
            // 
            // SubjectForm
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
            this.Name = "SubjectForm";
            this.Text = "Subjects";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
    }
}