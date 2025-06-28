using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class admorder : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public admorder()
        {
            InitializeComponent();
            LoadProductData();
        }

        private void LoadProductData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, Name, StockQuantity FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("OrderQuantity", typeof(int));
                foreach (DataRow row in dt.Rows)
                {
                    row["OrderQuantity"] = 0;
                }

                orderdataGridView.DataSource = dt;

                if (!orderdataGridView.Columns.Contains("Order"))
                {
                    DataGridViewButtonColumn orderBtn = new DataGridViewButtonColumn();
                    orderBtn.Name = "Order";
                    orderBtn.HeaderText = "Place Order";
                    orderBtn.Text = "Order";
                    orderBtn.UseColumnTextForButtonValue = true;
                    orderdataGridView.Columns.Add(orderBtn);
                }

                orderdataGridView.Columns["OrderQuantity"].ReadOnly = false;
                orderdataGridView.Columns["StockQuantity"].ReadOnly = true;
            }
        }

        private void orderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderdataGridView.Columns["Order"].Index && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(orderdataGridView.Rows[e.RowIndex].Cells["ProductID"].Value);
                string productName = orderdataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int stockQty = Convert.ToInt32(orderdataGridView.Rows[e.RowIndex].Cells["StockQuantity"].Value);

                if (!int.TryParse(orderdataGridView.Rows[e.RowIndex].Cells["OrderQuantity"].Value.ToString(), out int orderQty) || orderQty <= 0)
                {
                    MessageBox.Show("Please enter a valid order quantity.");
                    return;
                }

                if (orderQty > stockQty)
                {
                    MessageBox.Show("Order quantity exceeds available stock.");
                    return;
                }

                bool success = SendToOrderRequest(productId, productName, orderQty);

                if (success)
                {
                    MessageBox.Show("Order placed. Dealer notified via OrderRequest.");
                    LoadProductData();
                }
            }
        }

        private bool SendToOrderRequest(int productId, string productName, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO DealerNotifications 
                                (ProductID, ProductName, Quantity, Status, NotificationDate)
                                VALUES (@ProductID, @ProductName, @Quantity, @Status, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Status", "Pending");

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while notifying dealer: " + ex.Message);
                    return false;
                }
            }
        }

        private void orderback_Click(object sender, EventArgs e)
        {
            this.Hide();
            admwork admWork = new admwork();
            admWork.Show();
        }
    }
}
