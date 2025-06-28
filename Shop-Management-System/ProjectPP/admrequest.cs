using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPP
{
    public partial class admrequest : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";
        private string currentTable = "";

        public admrequest()
        {
            InitializeComponent();
        }

        private void admrequest_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Customer", "Salesman", "Dealer" });
            comboBox1.SelectedIndex = 0;
            LoadUsers();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            string userType = comboBox1.SelectedItem.ToString();
            currentTable = userType + (userType == "Salesman" ? "en" : "s"); // Customer → Customers, Salesman → Salesmen, Dealer → Dealers

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {currentTable}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dataGridView1.SelectedRows[0].Cells["User_Name"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = $"DELETE FROM {currentTable} WHERE User_Name = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("User removed successfully.");
                            LoadUsers(); // Refresh list
                        }
                        else
                        {
                            MessageBox.Show("User could not be removed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message);
            }
        }

        private void reqback_Click(object sender, EventArgs e)
        {
            admwork admWork = new admwork();
            admWork.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reqrequest_Click(object sender, EventArgs e)
        {

        }
    }
}
