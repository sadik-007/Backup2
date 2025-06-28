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

        // Back button
        private void button1_Click(object sender, EventArgs e)
        {
            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }

        // Proceed/Change button
        private void resetchange_Click(object sender, EventArgs e)
        {
            string username = resettextBoxusername.Text.Trim();
            string gmail = resettextBoxgmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("Please enter both Username and Gmail.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    string query = "SELECT COUNT(1) FROM Admins WHERE User_Name = @Username AND Gmail = @Gmail";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@Username", username);
                        sqlCmd.Parameters.AddWithValue("@Gmail", gmail);

                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            // Open admnewpass form
                            admnewpass newPassForm = new admnewpass(username);
                            newPassForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username and/or Gmail not found. Please try again.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional if you wired TextChanged in designer
        private void resettextBoxusername_TextChanged(object sender, EventArgs e)
        {
            // Optional: leave empty or remove if unused
        }
    }
}
