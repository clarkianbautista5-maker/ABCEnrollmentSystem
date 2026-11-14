namespace ABCEnrollmentSystem.Forms
{
    partial class TeacherDetailsForm
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
            txtTeacherId = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtMiddleName = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(26, 38, 64);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTeacherId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.ForeColor = Color.FromArgb(242, 184, 75);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teacher Details";
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(232, 238, 252);
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "Teacher ID";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTeacherId
            // 
            txtTeacherId.BackColor = Color.FromArgb(34, 50, 83);
            txtTeacherId.BorderStyle = BorderStyle.FixedSingle;
            txtTeacherId.ForeColor = Color.FromArgb(232, 238, 252);
            txtTeacherId.Location = new Point(120, 25);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(235, 23);
            txtTeacherId.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(232, 238, 252);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(34, 50, 83);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.FromArgb(232, 238, 252);
            txtFirstName.Location = new Point(120, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(232, 238, 252);
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 6;
            label3.Text = "Middle Name";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.FromArgb(34, 50, 83);
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.FromArgb(232, 238, 252);
            txtMiddleName.Location = new Point(120, 81);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(235, 23);
            txtMiddleName.TabIndex = 2;
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(232, 238, 252);
            label4.Location = new Point(10, 112);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(34, 50, 83);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.FromArgb(232, 238, 252);
            txtLastName.Location = new Point(120, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 23);
            txtLastName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(242, 184, 75);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(16, 25, 43);
            btnSave.Location = new Point(215, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 4;
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
            btnCancel.Location = new Point(305, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // TeacherDetailsForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 43);
            CancelButton = btnCancel;
            ClientSize = new Size(400, 225);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            ForeColor = Color.FromArgb(232, 238, 252);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeacherDetailsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Teacher Details";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}