using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class admreg : Form
    {
        public admreg()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accback_Click(object sender, EventArgs e)
        {
            Starting starting = new Starting();
            starting.Show();
            this.Hide();
        }

        private void accapply_Click(object sender, EventArgs e)
        {
            string username = acctextBoxusername.Text;
            string gmail = acctextBoxgmail.Text;
            string password = acctextBoxpass.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connctionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connctionString))
                {
                    sqlCon.Open();
                    string checkQuery = "Select Count(1) from Admins where User_Name=@username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, sqlCon))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int userExits = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (userExits > 0)
                        {
                            MessageBox.Show("This user name is already taken.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string insertQuery = "Insert into Admins(User_Name,Gmail,Password,DOB)values (@username,@gmail,@password,@DOB)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("Gmail", gmail);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Admin Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Starting starting = new Starting();
                    starting.Show();
                    this.Hide();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
