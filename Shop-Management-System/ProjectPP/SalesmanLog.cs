using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class SalesmanLog : Form
    {

        private string Con = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public SalesmanLog()
        {
            InitializeComponent();
        }

        private void btnlogSales_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text.Trim();
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Con))
                {
                    sqlCon.Open();

                    string query = "SELECT COUNT(1) FROM SalesmanLogin WHERE User_Name = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@password", pass);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            SalesmanHomePage dashboard = new SalesmanHomePage(user);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            SalesmanHomePage slaesmanhome = new SalesmanHomePage(user);
                            slaesmanhome.Show();
                            this.Hide();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesRegistration registration = new SalesRegistration();
            registration.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Starting back1 = new Starting();
            back1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetSalesmanPass resetForm = new ResetSalesmanPass();
            resetForm.Show();
            this.Hide();
        }
    }
}
