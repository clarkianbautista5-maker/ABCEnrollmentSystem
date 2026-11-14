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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtSubjectCode = new TextBox();
            label2 = new Label();
            txtSubjectName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            nudUnits = new NumericUpDown();
            label5 = new Label();
            cboTeacher = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(26, 38, 64);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSubjectCode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSubjectName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudUnits);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboTeacher);
            groupBox1.ForeColor = Color.FromArgb(242, 184, 75);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subject Details";
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(232, 238, 252);
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "Subject Code";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.BackColor = Color.FromArgb(34, 50, 83);
            txtSubjectCode.BorderStyle = BorderStyle.FixedSingle;
            txtSubjectCode.ForeColor = Color.FromArgb(232, 238, 252);
            txtSubjectCode.Location = new Point(120, 25);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(235, 23);
            txtSubjectCode.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(232, 238, 252);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "Subject Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSubjectName
            // 
            txtSubjectName.BackColor = Color.FromArgb(34, 50, 83);
            txtSubjectName.BorderStyle = BorderStyle.FixedSingle;
            txtSubjectName.ForeColor = Color.FromArgb(232, 238, 252);
            txtSubjectName.Location = new Point(120, 53);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(235, 23);
            txtSubjectName.TabIndex = 1;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(232, 238, 252);
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Description";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(34, 50, 83);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.ForeColor = Color.FromArgb(232, 238, 252);
            txtDescription.Location = new Point(120, 81);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(235, 60);
            txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(232, 238, 252);
            label4.Location = new Point(10, 152);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Units";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudUnits
            // 
            nudUnits.BackColor = Color.FromArgb(34, 50, 83);
            nudUnits.ForeColor = Color.FromArgb(232, 238, 252);
            nudUnits.Location = new Point(120, 149);
            nudUnits.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudUnits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudUnits.Name = "nudUnits";
            nudUnits.Size = new Size(80, 23);
            nudUnits.TabIndex = 3;
            nudUnits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(232, 238, 252);
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Teacher";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboTeacher
            // 
            cboTeacher.BackColor = Color.FromArgb(34, 50, 83);
            cboTeacher.DisplayMember = "FullName";
            cboTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTeacher.FlatStyle = FlatStyle.Flat;
            cboTeacher.ForeColor = Color.FromArgb(232, 238, 252);
            cboTeacher.FormattingEnabled = true;
            cboTeacher.Location = new Point(120, 177);
            cboTeacher.Name = "cboTeacher";
            cboTeacher.Size = new Size(235, 23);
            cboTeacher.TabIndex = 4;
            cboTeacher.ValueMember = "TeacherId";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(242, 184, 75);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(16, 25, 43);
            btnSave.Location = new Point(215, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(26, 38, 64);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(46, 63, 102);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(232, 238, 252);
            btnCancel.Location = new Point(305, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // SubjectDetailsForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 43);
            CancelButton = btnCancel;
            ClientSize = new Size(400, 295);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            ForeColor = Color.FromArgb(232, 238, 252);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubjectDetailsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Subject Details";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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