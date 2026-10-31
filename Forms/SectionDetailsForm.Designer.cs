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
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSectionCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.label1);
            this.grpSection.Controls.Add(this.txtSectionCode);
            this.grpSection.Controls.Add(this.label2);
            this.grpSection.Controls.Add(this.txtSectionName);
            this.grpSection.Controls.Add(this.label3);
            this.grpSection.Controls.Add(this.txtDescription);
            this.grpSection.BackColor = System.Drawing.Color.FromArgb(26, 38, 64);
            this.grpSection.ForeColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.grpSection.Location = new System.Drawing.Point(15, 15);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(370, 160);
            this.grpSection.TabIndex = 0;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Section Details";
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Section Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSectionCode
            // 
            this.txtSectionCode.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSectionCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectionCode.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSectionCode.Location = new System.Drawing.Point(120, 25);
            this.txtSectionCode.Name = "txtSectionCode";
            this.txtSectionCode.Size = new System.Drawing.Size(235, 23);
            this.txtSectionCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Section Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSectionName
            // 
            this.txtSectionName.BackColor = System.Drawing.Color.FromArgb(34, 50, 83);
            this.txtSectionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectionName.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.txtSectionName.Location = new System.Drawing.Point(120, 53);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(235, 23);
            this.txtSectionName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(242, 184, 75);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.btnSave.Location = new System.Drawing.Point(215, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(305, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // SectionDetailsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(16, 25, 43);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 235);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.FromArgb(232, 238, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SectionDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Section Details";
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSection;
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