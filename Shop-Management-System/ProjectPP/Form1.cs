using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPP
{
    public partial class Form1 : Form
    {
        private string _userRole;

        public Form1(string userRole = "Customer")
        {
            InitializeComponent();
            _userRole = userRole;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = _userRole + " Log In";
            this.label1.Text = _userRole + " Log In";
            if (_userRole != "Customer")
            {
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    if (_userRole == "Customer")
                    {
                        string query = "SELECT Full_Name FROM Customer WHERE User_Name=@Username AND Password=@Password";
                        using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                        {
                            sqlCmd.Parameters.AddWithValue("@Username", username);
                            sqlCmd.Parameters.AddWithValue("@Password", password);
                            object result = sqlCmd.ExecuteScalar();

                            if (result != null)
                            {
                                string fullName = result.ToString();
                                
                                CustomerHomePage customerHome = new CustomerHomePage(fullName);
                                customerHome.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        string tableName = "";
                        switch (_userRole)
                        {
                            case "Admin": tableName = "Admins"; break;
                            case "Salesman": tableName = "Salesmen"; break;
                            case "Dealer": tableName = "Dealers"; break;
                        }

                        string query = $"SELECT COUNT(1) FROM {tableName} WHERE User_Name=@Username AND Password=@Password";
                        using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                        {
                            sqlCmd.Parameters.AddWithValue("@Username", username);
                            sqlCmd.Parameters.AddWithValue("@Password", password);
                            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                            if (count == 1)
                            {
                                MessageBox.Show(_userRole + " Login Successful! Dashboard coming soon.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password for this role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset resetForm = new Reset();
            resetForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registrationForm = new Form2();
            registrationForm.Show();
            this.Hide();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void linkBackToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Starting startingForm = Application.OpenForms.OfType<Starting>().FirstOrDefault();
            if (startingForm != null)
            {
                startingForm.Show();
            }
            else
            {
                startingForm = new Starting();
                startingForm.Show();
            }
            this.Close();
        }

        // --- THIS EMPTY METHOD FIXES THE ERROR ---
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            // This method is required by the designer file but is not used.
        }
    }
}