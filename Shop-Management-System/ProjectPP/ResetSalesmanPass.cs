using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class ResetSalesmanPass : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=[Practice Database];Trusted_Connection=True;";

        public ResetSalesmanPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = richTextBox2.Text.Trim(); // Salesman username
            string gmail = richTextBox1.Text.Trim();    // Salesman Gmail

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

                    string query = "SELECT COUNT(1) FROM SalesmanLogin WHERE User_Name = @UserName AND Gmail = @Gmail";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@UserName", userName);
                        sqlCmd.Parameters.AddWithValue("@Gmail", gmail);

                        int count = (int)sqlCmd.ExecuteScalar();

                        if (count == 1)
                        {
                            // Found salesman — go to new password form
                            NewPassSales newPassForm = new NewPassSales(userName); // Assume this form updates password
                            newPassForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User Name and/or Gmail not found. Please try again.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Starting back2 = new Starting();
            back2.Show();
            this.Hide();
        }

        // These are optional events, used only if needed by the form design
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
    }
}
