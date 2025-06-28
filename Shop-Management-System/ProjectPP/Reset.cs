using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPP
{
    public partial class Reset : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public Reset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = richTextBox2.Text;
            string gmail = richTextBox1.Text;

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
                    // This query assumes you have a 'Gmail' column in your 'Customer' table
                    string query = "SELECT COUNT(1) FROM Customer WHERE User_Name = @UserName AND Gmail = @Gmail";

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@UserName", userName);
                        sqlCmd.Parameters.AddWithValue("@Gmail", gmail);
                        int count = (int)sqlCmd.ExecuteScalar();

                        if (count == 1)
                        {
                            NewPass newPassForm = new NewPass(userName);
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

        // --- NEW METHOD FOR THE "BACK TO LOGIN" LINK ---
        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Find the original Form1 that was hidden
            Form1 loginForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                // As a backup, create a new one
                loginForm = new Form1("Customer");
                loginForm.Show();
            }
            // Close this Reset form
            this.Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // This is not used but required by the designer.
        }
    }
}