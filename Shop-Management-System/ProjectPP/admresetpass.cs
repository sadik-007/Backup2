using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class admresetpass : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public admresetpass()
        {
            InitializeComponent();
        }

        private void resetchange_Click(object sender, EventArgs e)
        {
            string username = resettextBoxusername.Text.Trim();
            string newPassword = resettextBoxnew.Text.Trim();
            string confirmPassword = resetconfirm.Text.Trim();

            // 1. Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Check if new password and confirm password match
            if (!newPassword.Equals(confirmPassword))
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    // 3. Check if admin username exists
                    string checkQuery = "SELECT COUNT(1) FROM Admins WHERE User_Name = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, sqlCon))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists == 0)
                        {
                            MessageBox.Show("Admin username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 4. Update the password
                    string updateQuery = "UPDATE Admins SET Password = @Password WHERE User_Name = @Username";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlCon))
                    {
                        updateCmd.Parameters.AddWithValue("@Password", newPassword);
                        updateCmd.Parameters.AddWithValue("@Username", username);

                        int rows = updateCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to login
                            AdminLog admlog = new AdminLog();
                            admlog.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Optional: Go back to login
            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }
    }
}
