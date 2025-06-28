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
    public partial class admnotifi : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";
        public admnotifi()
        {
            InitializeComponent();
        }

        private void admnotifi_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }
        private void LoadNotifications()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "Select NotificationID,Message,CreatedAt from Notifications where Role='Admin'order by CreatedAt DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            dataGridView1.Visible = false;
                            notifiEmptyNotifications.Visible = true;
                        }
                        else
                        {
                            dataGridView1.DataSource = dt;
                            dataGridView1.Visible = true;
                            notifiEmptyNotifications.Visible = false;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load notifications: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notifiback_Click(object sender, EventArgs e)
        {
            admwork admWork = new admwork();
            admWork.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
