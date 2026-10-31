namespace ABCEnrollmentSystem.Forms
{
    partial class EnrollmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.txtSchoolYear = new System.Windows.Forms.TextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student";
            // 
            // cboStudent
            // 
            this.cboStudent.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStudent.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboStudent.FormattingEnabled = true;
            this.cboStudent.Location = new System.Drawing.Point(120, 20);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(250, 23);
            this.cboStudent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject";
            // 
            // cboSubject
            // 
            this.cboSubject.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubject.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(120, 55);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(250, 23);
            this.cboSubject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Section";
            // 
            // cboSection
            // 
            this.cboSection.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSection.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(120, 90);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(250, 23);
            this.cboSection.TabIndex = 2;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(15, 128);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(100, 15);
            this.lblSchoolYear.TabIndex = 9;
            this.lblSchoolYear.Text = "School Year";
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSchoolYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolYear.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSchoolYear.Location = new System.Drawing.Point(120, 125);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.Size = new System.Drawing.Size(250, 23);
            this.txtSchoolYear.TabIndex = 3;
            this.txtSchoolYear.Text = "2026-2027";
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnEnroll.FlatAppearance.BorderSize = 0;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnEnroll.Location = new System.Drawing.Point(120, 170);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(120, 32);
            this.btnEnroll.TabIndex = 4;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnClose.Location = new System.Drawing.Point(250, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // EnrollmentForm
            // 
            this.AcceptButton = this.btnEnroll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSection);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.txtSchoolYear);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnrollmentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enroll a Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.TextBox txtSchoolYear;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnClose;
    }
}