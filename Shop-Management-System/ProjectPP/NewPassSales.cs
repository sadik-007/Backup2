using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class NewPassSales : Form
    {
        private string _userName;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=[Practice Database];Trusted_Connection=True;";

        public NewPassSales(string userName)
        {
            InitializeComponent();
            _userName = userName;
            this.Text = "Set New Password for " + _userName;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    string query = "UPDATE SalesmanLogin SET Password = @NewPassword WHERE User_Name = @UserName";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        sqlCmd.Parameters.AddWithValue("@UserName", _userName);

                        int rowsAffected = sqlCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Close the Reset form if it's open
                            Form resetForm = Application.OpenForms.OfType<ResetSalesmanPass>().FirstOrDefault();
                            if (resetForm != null) resetForm.Close();

                            // Show login form if available
                            Form loginForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                            if (loginForm != null) loginForm.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: Toggle visibility for new password
        private void btnShowNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
        }

        // Optional: Toggle visibility for confirm password
        private void btnShowConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
        }
    }
}
