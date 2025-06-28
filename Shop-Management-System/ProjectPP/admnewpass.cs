using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class admnewpass : Form
    {
        private string _userName;
        // Ensure this connection string is correct for your environment
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public admnewpass(string userName)
        {
            InitializeComponent();
            _userName = userName;
            this.Text = "Set New Password for " + _userName;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newPassword = newtextBoxnewpass.Text;
            string confirmPassword = newtextBoxconfirmpass.Text;

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
                    string query = "UPDATE Admins SET Password = @Password WHERE User_Name = @UserName";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@Password", newPassword);
                        sqlCmd.Parameters.AddWithValue("@UserName", _userName);

                        int rowsAffected = sqlCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Go back to Admin login
                            AdminLog admlog = new AdminLog();
                            admlog.Show();
                            this.Hide();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }

        private void resettextBoxusername_TextChanged(object sender, EventArgs e)
        {
            // This method can be left empty if not needed
        }
    }
}