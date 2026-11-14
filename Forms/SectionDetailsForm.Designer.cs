namespace ABCEnrollmentSystem.Forms
{
    partial class SectionDetailsForm
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
            txtSectionCode = new TextBox();
            label2 = new Label();
            txtSectionName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(26, 38, 64);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSectionCode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSectionName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.ForeColor = Color.FromArgb(242, 184, 75);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Section Details";
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(232, 238, 252);
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            label1.Text = "Section Code";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSectionCode
            // 
            txtSectionCode.BackColor = Color.FromArgb(34, 50, 83);
            txtSectionCode.BorderStyle = BorderStyle.FixedSingle;
            txtSectionCode.ForeColor = Color.FromArgb(232, 238, 252);
            txtSectionCode.Location = new Point(120, 25);
            txtSectionCode.Name = "txtSectionCode";
            txtSectionCode.Size = new Size(235, 23);
            txtSectionCode.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(232, 238, 252);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Section Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSectionName
            // 
            txtSectionName.BackColor = Color.FromArgb(34, 50, 83);
            txtSectionName.BorderStyle = BorderStyle.FixedSingle;
            txtSectionName.ForeColor = Color.FromArgb(232, 238, 252);
            txtSectionName.Location = new Point(120, 53);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(235, 23);
            txtSectionName.TabIndex = 1;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(232, 238, 252);
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
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
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(242, 184, 75);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(16, 25, 43);
            btnSave.Location = new Point(215, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 3;
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
            btnCancel.Location = new Point(305, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // SectionDetailsForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 43);
            CancelButton = btnCancel;
            ClientSize = new Size(400, 235);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            ForeColor = Color.FromArgb(232, 238, 252);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SectionDetailsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Section Details";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSectionCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}