using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABCEnrollmentSystem.Forms
{
    public partial class LogInForm : Form
    {
        private string _username, _password;
        public LogInForm()
        {
            InitializeComponent();
            ClearErrors();
            txtUser.KeyDown += txtUser_KeyDown;
            txtPass.KeyDown += txtPass_KeyDown;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '●';

        }

        private void ClearErrors()
        {
            lblErrorUser.Text = string.Empty;
            lblerrorpass.Text = string.Empty;
            lblErrorUser.Visible = false;
            lblerrorpass.Visible = false;
        }
        private static void ShowError(Label label, string message)
        {
            label.Text = message;
            label.Visible = true;

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            lbldatedisplay.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblTimeDisplay.Text = DateTime.Now.ToString("hh:mm tt");

            txtUser.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ClearErrors();

            string username = txtUser.Text.Trim();
            string password = txtPass.Text;

            bool hasError = false;

            if (string.IsNullOrEmpty(username))
            {
                ShowError(lblErrorUser, "Username is required.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowError(lblerrorpass, "Password is required.");
                hasError = true;
            }

            if (hasError)
            {
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection("Server = DESKTOP-JG0361V\\SQLEXPRESS; Database = ABCEnrollmentDb; Trusted_Connection = True; TrustServerCertificate = True;"))
                {
                    connection.Open();

                    string query = "SELECT Username, Password FROM Users WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() && reader["Password"].ToString() == password)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult = DialogResult.OK;
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                ShowError(lblerrorpass, "Invalid username or password. Please try again.");
                                txtPass.Clear();
                                txtPass.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to complete the login request. Please contact the system administrator.\n\nDetails: " + ex.Message, "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
                e.SuppressKeyPress = true;
            }

        }
    }
}
