using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class ResetSalesmanPass : Form
    {
        // ✅ Correct connection string syntax (no square brackets)
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public ResetSalesmanPass()
        {
            InitializeComponent();
        }

        // ✅ Reset/Verify button click
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = richTextBox2.Text.Trim(); // Salesman username
            string gmail = richTextBox1.Text.Trim();    // Salesman Gmail

            // ✅ Input validation
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("Please enter both User Name and Gmail.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    // ✅ Query to validate credentials
                    string query = "SELECT COUNT(1) FROM SalesmanLogin WHERE User_Name = @UserName AND Gmail = @Gmail";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@UserName", userName);
                        sqlCmd.Parameters.AddWithValue("@Gmail", gmail);

                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            // ✅ Credentials match — open password reset form
                            NewPassSales newPassForm = new NewPassSales(userName); // Assume NewPassSales has a constructor that accepts username
                            newPassForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // ❌ Credentials don't match
                            MessageBox.Show("User Name and/or Gmail not found. Please try again.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ❗ Handle database or runtime error
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Back to login or previous form
        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Starting back2 = new Starting();
            back2.Show();
            this.Hide();
        }

        // 🧹 Optional UI event handlers (can be removed if unused)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesmanLog salesmanLog = new SalesmanLog();
            salesmanLog.Show();
            this.Hide();
        }

        private void ResetSalesmanPass_Load(object sender, EventArgs e)
        {

        }
    }
}
