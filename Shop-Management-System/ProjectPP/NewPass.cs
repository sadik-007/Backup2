using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class NewPass : Form
    {
        private string _userName;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public NewPass(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void NewPass_Load(object sender, EventArgs e)
        {
            this.Text = "Set New Password for " + _userName;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE Customer SET Password = @NewPassword WHERE User_Name = @UserName";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        sqlCmd.Parameters.AddWithValue("@UserName", _userName);

                        int rowsAffected = sqlCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Call the new link click logic to navigate back
                            linkBackToLogin_LinkClicked(sender, null);
                        }
                        else
                        {
                            MessageBox.Show("Password could not be updated. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void togglePasswordVisibility_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Name == "btnShowNewPassword")
            {
                txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
            }
            else if (clickedButton.Name == "btnShowConfirmPassword")
            {
                txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
            }
        }

        // --- NEW METHOD FOR THE "BACK TO LOGIN PAGE" LINK ---
        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Find the original login form that is hidden
            Form1 loginForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                // As a backup, create a new customer login form
                loginForm = new Form1("Customer");
                loginForm.Show();
            }

            // Find and close the intermediate Reset form
            Form resetForm = Application.OpenForms.OfType<Reset>().FirstOrDefault();
            if (resetForm != null)
            {
                resetForm.Close();
            }

            // Close this form
            this.Close();
        }
    }
}