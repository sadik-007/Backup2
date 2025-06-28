using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class PurchasePage : Form
    {
        private byte[] _imageData;
        private string _model, _productCode, _productType, _features, _status;
        private decimal _price;
        private string _username;  // add username field

        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public PurchasePage(byte[] imageData, string model, decimal price, string productCode, string productType, string features, string status, string username)
        {
            InitializeComponent();

            _imageData = imageData;
            _model = model;
            _price = price;
            _productCode = productCode;
            _productType = productType;
            _features = features;
            _status = status;
            _username = username;  // assign username
        }

        private void PurchasePage_Load(object sender, EventArgs e)
        {
            lblModel.Text = _model;
            lblProductCode.Text = "Product Code: " + _productCode;
            lblType.Text = "Product Type: " + _productType;
            lblPrice.Text = "৳" + _price.ToString("N0");
            txtFeatures.Text = _features;

            if (_imageData != null && _imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_imageData))
                {
                    picProduct.Image = Image.FromStream(ms);
                }
            }

            if (_status.ToLower() != "in stock")
            {
                lblUnavailable.Visible = true;
                btnConfirmPurchase.Enabled = false;
                btnConfirmPurchase.BackColor = Color.Gray;
            }
            else
            {
                lblUnavailable.Visible = false;
            }
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_username))
            {
                MessageBox.Show("User is not logged in or username is not set.");
                return;
            }

            int currentPoints = 0;
            int pointsEarned = (int)Math.Floor(_price / 1000m) * 10;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string selectQuery = "SELECT Points FROM Customer WHERE User_Name = @UserName";
                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, con))
                    {
                        cmdSelect.Parameters.AddWithValue("@UserName", _username);

                        object result = cmdSelect.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            currentPoints = Convert.ToInt32(result);
                        else
                            currentPoints = 0;
                    }

                    int newPoints = currentPoints + pointsEarned;

                    string updateQuery = "UPDATE Customer SET Points = @Points WHERE User_Name = @UserName";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Points", newPoints);
                        cmdUpdate.Parameters.AddWithValue("@UserName", _username);

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("User not found, points not updated.");
                            return;
                        }
                    }

                    PaySlip paySlip = new PaySlip(_model, _price, pointsEarned, newPoints);
                    //this.Hide();
                    paySlip.ShowDialog();
                }

                var customerHome = Application.OpenForms.OfType<CustomerHomePage>().FirstOrDefault();
                if (customerHome != null)
                {
                    customerHome.Show();
                    customerHome.LoadProductsFromDatabase();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Purchase failed: " + ex.Message);
            }
        }

        // Empty handlers to avoid errors if designer generates these events
        private void lblModel_Click(object sender, EventArgs e) { }
        private void lblUnavailable_Click(object sender, EventArgs e) { }
    }
}
