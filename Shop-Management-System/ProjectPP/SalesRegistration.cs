
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class SalesRegistration : Form
    {
        string Con = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public SalesRegistration()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e) { }

        private void txtusername_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtconpass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesmanLog backlog = new SalesmanLog();
            backlog.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Starting starting = new Starting();
            starting.Show();
            this.Hide();
        }

        private void btnlogSales_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text.Trim();
            string username = txtusername.Text.Trim();
            string gmail = txtemail.Text.Trim();
            string phonenum = txtphnnum.Text.Trim();
            string password = txtPass.Text;
            string confirmpassword = txtconpass.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gmail) ||
                string.IsNullOrEmpty(phonenum) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpassword))
            {
                MessageBox.Show("All details must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Con))
                {
                    sqlCon.Open();

                    string checkUserQuery = "SELECT COUNT(1) FROM SalesmanLogin WHERE User_Name = @UserName";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, sqlCon))
                    {
                        checkUserCmd.Parameters.AddWithValue("@UserName", username);
                        int userCount = (int)checkUserCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username not available!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO SalesmanLogin (Full_Name, User_Name, Gmail, Contact_Number, Password) VALUES (@FullName, @UserName, @Gmail, @Contact, @Password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon))
                    {
                        insertCmd.Parameters.AddWithValue("@FullName", Name);
                        insertCmd.Parameters.AddWithValue("@UserName", username);
                        insertCmd.Parameters.AddWithValue("@Gmail", gmail);
                        insertCmd.Parameters.AddWithValue("@Contact", phonenum);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SalesmanLog loginForm = new SalesmanLog();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
