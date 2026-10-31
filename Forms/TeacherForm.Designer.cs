namespace ABCEnrollmentSystem
{
    partial class TeacherForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnExit = new Button();
            btnReports = new Button();
            btnEnroll = new Button();
            btnSections = new Button();
            btnTeachers = new Button();
            btnSubjects = new Button();
            btnStudents = new Button();
            btnDashboard = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlHeader = new Panel();
            lblSchoolYear = new Label();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvTeachers = new DataGridView();
            colTeacherId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            btnShowAll = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(26, 38, 64);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnEnroll);
            pnlSidebar.Controls.Add(btnSections);
            pnlSidebar.Controls.Add(btnTeachers);
            pnlSidebar.Controls.Add(btnSubjects);
            pnlSidebar.Controls.Add(btnStudents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 620);
            pnlSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.FromArgb(34, 50, 83);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(46, 63, 102);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(232, 238, 252);
            btnExit.Location = new Point(20, 565);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(34, 50, 83);
            btnReports.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.FromArgb(232, 238, 252);
            btnReports.Location = new Point(20, 427);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(160, 34);
            btnReports.TabIndex = 6;
            btnReports.Text = "Summary Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(34, 50, 83);
            btnEnroll.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.ForeColor = Color.FromArgb(232, 238, 252);
            btnEnroll.Location = new Point(20, 385);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(160, 34);
            btnEnroll.TabIndex = 5;
            btnEnroll.Text = "Enroll a Student";
            btnEnroll.UseVisualStyleBackColor = false;
            // 
            // btnSections
            // 
            btnSections.BackColor = Color.FromArgb(34, 50, 83);
            btnSections.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnSections.FlatStyle = FlatStyle.Flat;
            btnSections.ForeColor = Color.FromArgb(232, 238, 252);
            btnSections.Location = new Point(20, 343);
            btnSections.Name = "btnSections";
            btnSections.Size = new Size(160, 34);
            btnSections.TabIndex = 4;
            btnSections.Text = "Sections";
            btnSections.UseVisualStyleBackColor = false;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = Color.FromArgb(34, 50, 83);
            btnTeachers.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.ForeColor = Color.FromArgb(232, 238, 252);
            btnTeachers.Location = new Point(20, 301);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(160, 34);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = false;
            // 
            // btnSubjects
            // 
            btnSubjects.BackColor = Color.FromArgb(34, 50, 83);
            btnSubjects.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.ForeColor = Color.FromArgb(232, 238, 252);
            btnSubjects.Location = new Point(20, 259);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(160, 34);
            btnSubjects.TabIndex = 2;
            btnSubjects.Text = "Subjects";
            btnSubjects.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.FromArgb(34, 50, 83);
            btnStudents.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.ForeColor = Color.FromArgb(232, 238, 252);
            btnStudents.Location = new Point(20, 217);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(160, 34);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(34, 50, 83);
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(127, 178, 255);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(232, 238, 252);
            btnDashboard.Location = new Point(20, 175);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(232, 238, 252);
            lblSubtitle.Location = new Point(0, 132);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(200, 18);
            lblSubtitle.TabIndex = 10;
            lblSubtitle.Text = "Enrollment System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(232, 238, 252);
            lblTitle.Location = new Point(0, 108);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 22);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "ABC Senior High";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(60, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 38, 64);
            pnlHeader.Controls.Add(lblSchoolYear);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.ForeColor = Color.FromArgb(242, 184, 75);
            lblSchoolYear.Location = new Point(600, 18);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(180, 24);
            lblSchoolYear.TabIndex = 1;
            lblSchoolYear.Text = "S.Y. 2026-2027";
            lblSchoolYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(232, 238, 252);
            lblPageTitle.Location = new Point(20, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(87, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Teachers";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(16, 25, 43);
            pnlContent.Controls.Add(btnDelete);
            pnlContent.Controls.Add(btnUpdate);
            pnlContent.Controls.Add(btnAdd);
            pnlContent.Controls.Add(dgvTeachers);
            pnlContent.Controls.Add(btnShowAll);
            pnlContent.Controls.Add(btnSearch);
            pnlContent.Controls.Add(txtSearch);
            pnlContent.Controls.Add(lblSearch);
            pnlContent.Location = new Point(200, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 560);
            pnlContent.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(26, 38, 64);
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(242, 109, 109);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(242, 109, 109);
            btnDelete.Location = new Point(220, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(26, 38, 64);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(46, 63, 102);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(232, 238, 252);
            btnUpdate.Location = new Point(120, 480);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 32);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(242, 184, 75);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(16, 25, 43);
            btnAdd.Location = new Point(20, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.AllowUserToResizeRows = false;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.BackgroundColor = Color.FromArgb(16, 25, 43);
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 52, 90);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { colTeacherId, colName });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(26, 38, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(232, 238, 252);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(127, 178, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 25, 43);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTeachers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTeachers.EnableHeadersVisualStyles = false;
            dgvTeachers.GridColor = Color.FromArgb(46, 63, 102);
            dgvTeachers.Location = new Point(20, 55);
            dgvTeachers.MultiSelect = false;
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(760, 410);
            dgvTeachers.TabIndex = 3;
            // 
            // colTeacherId
            // 
            colTeacherId.DataPropertyName = "TeacherId";
            colTeacherId.HeaderText = "Teacher ID";
            colTeacherId.Name = "colTeacherId";
            colTeacherId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "FullName";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(26, 38, 64);
            btnShowAll.FlatAppearance.BorderColor = Color.FromArgb(46, 63, 102);
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.ForeColor = Color.FromArgb(232, 238, 252);
            btnShowAll.Location = new Point(560, 13);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 27);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(26, 38, 64);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(46, 63, 102);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(232, 238, 252);
            btnSearch.Location = new Point(475, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(34, 50, 83);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.FromArgb(232, 238, 252);
            txtSearch.Location = new Point(215, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(232, 238, 252);
            lblSearch.Location = new Point(20, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(167, 15);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search by Teacher ID or Name:";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 43);
            ClientSize = new Size(1000, 620);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            ForeColor = Color.FromArgb(232, 238, 252);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TeacherForm";
            Text = "Teachers";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}