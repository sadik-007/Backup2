using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        // Form Load event handler (empty if you want)
        private void AdminLog_Load(object sender, EventArgs e)
        {
            // You can put initialization code here if needed
        }

        // Event handler for welcome label click (optional)
        private void label1_Click(object sender, EventArgs e)
        {
            // You can leave empty or do something if desired
        }

        // Event handler for back label click (optional)
        private void label2_Click(object sender, EventArgs e)
        {
            // You can leave empty or do something if desired
        }

        // Login button click
        private void button1_Click(object sender, EventArgs e)
        {
            string username = logtextBoxusername.Text.Trim();
            string password = logtextBoxpass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your actual connection string here:
            string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

            try
            {
                using (SqlConnection SqlCon = new SqlConnection(connectionString))
                {
                    SqlCon.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE User_Name=@username AND Password=@password";
                    using (SqlCommand sqlCmd = new SqlCommand(query, SqlCon))
                    {
                        sqlCmd.Parameters.AddWithValue("@username", username);
                        sqlCmd.Parameters.AddWithValue("@password", password);

                        int count = (int)sqlCmd.ExecuteScalar();
                        if (count == 1)
                        {
                            MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            admwork admWork = new admwork(); // Assuming admwork is the admin dashboard form
                            admWork.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Register button click
        private void button2_Click(object sender, EventArgs e)
        {
            admreg admReg = new admreg();  // Assuming admreg is the registration form
            admReg.Show();
            this.Hide();
        }

        // Forgot password button click
        private void button3_Click(object sender, EventArgs e)
        {
            admresetpass admreset = new admresetpass(); // Assuming admresetpass is the reset password form
            admreset.Show();
            this.Hide();
        }

        // Back button click
        private void logbackbutton_Click(object sender, EventArgs e)
        {
            Starting starting = new Starting();  // Assuming Starting is your main/home form
            starting.Show();
            this.Hide();
        }
    }
}
