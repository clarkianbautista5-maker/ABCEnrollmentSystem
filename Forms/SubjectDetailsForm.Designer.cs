namespace ABCEnrollmentSystem.Forms
{
    partial class SubjectDetailsForm
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
            this.grpSubject = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudUnits = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).BeginInit();
            this.grpSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSubject
            // 
            this.grpSubject.Controls.Add(this.label1);
            this.grpSubject.Controls.Add(this.txtSubjectCode);
            this.grpSubject.Controls.Add(this.label2);
            this.grpSubject.Controls.Add(this.txtSubjectName);
            this.grpSubject.Controls.Add(this.label3);
            this.grpSubject.Controls.Add(this.txtDescription);
            this.grpSubject.Controls.Add(this.label4);
            this.grpSubject.Controls.Add(this.nudUnits);
            this.grpSubject.Controls.Add(this.label5);
            this.grpSubject.Controls.Add(this.cboTeacher);
            this.grpSubject.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.grpSubject.ForeColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.grpSubject.Location = new System.Drawing.Point(15, 15);
            this.grpSubject.Name = "grpSubject";
            this.grpSubject.Size = new System.Drawing.Size(370, 220);
            this.grpSubject.TabIndex = 0;
            this.grpSubject.TabStop = false;
            this.grpSubject.Text = "Subject Details";
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectCode.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSubjectCode.Location = new System.Drawing.Point(120, 25);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(235, 23);
            this.txtSubjectCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectName.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSubjectName.Location = new System.Drawing.Point(120, 53);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(235, 23);
            this.txtSubjectName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtDescription.Location = new System.Drawing.Point(120, 81);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Units";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudUnits
            // 
            this.nudUnits.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.nudUnits.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.nudUnits.Location = new System.Drawing.Point(120, 149);
            this.nudUnits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnits.Name = "nudUnits";
            this.nudUnits.Size = new System.Drawing.Size(80, 23);
            this.nudUnits.TabIndex = 3;
            this.nudUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teacher";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTeacher
            // 
            this.cboTeacher.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.cboTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTeacher.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.cboTeacher.FormattingEnabled = true;
            this.cboTeacher.Location = new System.Drawing.Point(120, 177);
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(235, 23);
            this.cboTeacher.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnSave.Location = new System.Drawing.Point(215, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 63, 102);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.btnCancel.Location = new System.Drawing.Point(305, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // SubjectDetailsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.grpSubject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subject Details";
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).EndInit();
            this.grpSubject.ResumeLayout(false);
            this.grpSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}