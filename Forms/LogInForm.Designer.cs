namespace ABCEnrollmentSystem.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            groupBox1 = new GroupBox();
            lblerrorpass = new Label();
            lblErrorUser = new Label();
            txtUser = new TextBox();
            btnExit = new Button();
            btnLogIn = new Button();
            checkBox1 = new CheckBox();
            txtPass = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            lbldatedisplay = new Label();
            lblTimeDisplay = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblerrorpass);
            groupBox1.Controls.Add(lblErrorUser);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogIn);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(385, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 535);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // lblerrorpass
            // 
            lblerrorpass.AutoSize = true;
            lblerrorpass.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblerrorpass.ForeColor = Color.Red;
            lblerrorpass.Location = new Point(91, 250);
            lblerrorpass.Name = "lblerrorpass";
            lblerrorpass.Size = new Size(43, 17);
            lblerrorpass.TabIndex = 12;
            lblerrorpass.Text = "label8";
            lblerrorpass.Visible = false;
            // 
            // lblErrorUser
            // 
            lblErrorUser.AutoSize = true;
            lblErrorUser.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorUser.ForeColor = Color.Red;
            lblErrorUser.Location = new Point(91, 148);
            lblErrorUser.Name = "lblErrorUser";
            lblErrorUser.Size = new Size(43, 17);
            lblErrorUser.TabIndex = 11;
            lblErrorUser.Text = "label8";
            lblErrorUser.Visible = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(34, 50, 83);
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.ForeColor = Color.FromArgb(232, 238, 252);
            txtUser.Location = new Point(91, 118);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(238, 27);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(34, 50, 83);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(232, 238, 252);
            btnExit.Location = new Point(119, 458);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(185, 48);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(34, 50, 83);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.ForeColor = Color.FromArgb(232, 238, 252);
            btnLogIn.Location = new Point(119, 375);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(185, 48);
            btnLogIn.TabIndex = 8;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.FromArgb(232, 238, 252);
            checkBox1.Location = new Point(91, 281);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(34, 50, 83);
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.ForeColor = Color.FromArgb(232, 238, 252);
            txtPass.Location = new Point(91, 220);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.Size = new Size(238, 27);
            txtPass.TabIndex = 6;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(232, 238, 252);
            label6.Location = new Point(91, 193);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 3;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(232, 238, 252);
            label5.Location = new Point(91, 94);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(232, 238, 252);
            label4.Location = new Point(30, 61);
            label4.Name = "label4";
            label4.Size = new Size(223, 17);
            label4.TabIndex = 1;
            label4.Text = "Log in to continue to the Dashboard.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(232, 238, 252);
            label3.Location = new Point(30, 27);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 0;
            label3.Text = "Welcome Back!!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(95, 49);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(232, 238, 252);
            label1.Location = new Point(67, 178);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 10;
            label1.Text = "ABC Senior High";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(232, 238, 252);
            label2.Location = new Point(78, 213);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 11;
            label2.Text = "Enrollment System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(107, 288);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 13;
            label7.Text = "__________";
            // 
            // lbldatedisplay
            // 
            lbldatedisplay.AutoSize = true;
            lbldatedisplay.ForeColor = Color.FromArgb(232, 238, 252);
            lbldatedisplay.Location = new Point(79, 332);
            lbldatedisplay.Name = "lbldatedisplay";
            lbldatedisplay.Size = new Size(50, 20);
            lbldatedisplay.TabIndex = 14;
            lbldatedisplay.Text = "label8";
            // 
            // lblTimeDisplay
            // 
            lblTimeDisplay.AutoSize = true;
            lblTimeDisplay.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeDisplay.ForeColor = Color.FromArgb(232, 238, 252);
            lblTimeDisplay.Location = new Point(107, 379);
            lblTimeDisplay.Name = "lblTimeDisplay";
            lblTimeDisplay.Size = new Size(63, 25);
            lblTimeDisplay.TabIndex = 15;
            lblTimeDisplay.Text = "label8";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(107, 425);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 14;
            label8.Text = "__________";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblTimeDisplay);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lbldatedisplay);
            groupBox2.Location = new Point(-3, -10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 699);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label12
            // 
            label12.ForeColor = Color.FromArgb(242, 184, 75);
            label12.Location = new Point(80, 649);
            label12.Name = "label12";
            label12.Size = new Size(115, 32);
            label12.TabIndex = 17;
            label12.Text = "S.Y. 2026-2027";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 38, 64);
            ClientSize = new Size(891, 680);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LogInForm";
            Text = "ABC Senior High -  Log In";
            Load += LogInForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnLogIn;
        private CheckBox checkBox1;
        private TextBox txtPass;
        private Button btnExit;
        private TextBox txtUser;
        private Label label9;
        private Label lblErrorUser;
        private Label lblerrorpass;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label lbldatedisplay;
        private Label lblTimeDisplay;
        private Label label8;
        private GroupBox groupBox2;
        private Label label12;
    }
}