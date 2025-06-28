using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectPP
{
    public partial class NewPassSales : Form
    {
        private string _userName;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public NewPassSales(string userName)
        {
            InitializeComponent();
            _userName = userName;
            this.Text = "Set New Password for " + _userName;

            // Hide passwords initially
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        // ✅ Update password in database
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill both password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "UPDATE SalesmanLogin SET Password = @Password WHERE User_Name = @UserName";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@Password", newPassword);
                        sqlCmd.Parameters.AddWithValue("@UserName", _userName);

                        int rowsAffected = sqlCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open login form (Form1) if it exists
                            Form loginForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                            if (loginForm != null)
                            {
                                loginForm.Show();
                            }
                            else
                            {
                                new Form1().Show();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User not found. Password not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Show/hide password using checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        // ✅ Optional: Back button to return to login
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetSalesmanPass resetSalesmanPass1 = new ResetSalesmanPass();
            resetSalesmanPass1.Show();
            this.Hide();
        }
    }
}
