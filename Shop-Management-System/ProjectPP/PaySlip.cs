using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ProjectPP
{
    public partial class PaySlip : Form
    {
        private decimal _productPrice;
        private int _currentPoints;
        private int _pointsEarned;
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=Practice Database;Trusted_Connection=True;";

        public PaySlip(decimal productPrice)
        {
            InitializeComponent();
            _productPrice = productPrice;
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            FetchCurrentPoints();
            _pointsEarned = (int)Math.Floor(_productPrice / 1000) * 10;

            lblUserName.Text = CurrentUser.FullName;
            lblProductPrice.Text = "৳" + _productPrice.ToString("N0");
            lblPointsAdded.Text = "+ " + _pointsEarned.ToString();
            lblCurrentPoints.Text = _currentPoints.ToString();

            numPointsToUse.Maximum = _currentPoints;
            UpdateFinalPrice();
        }

        private void FetchCurrentPoints()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Points FROM Customer WHERE User_Name = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", CurrentUser.UserName);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            _currentPoints = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not fetch user points. Error: " + ex.Message);
                _currentPoints = 0;
            }
        }

        private void chkUsePoints_CheckedChanged(object sender, EventArgs e)
        {
            numPointsToUse.Enabled = chkUsePoints.Checked;
            if (!chkUsePoints.Checked)
            {
                numPointsToUse.Value = 0;
            }
            UpdateFinalPrice();
        }

        private void numPointsToUse_ValueChanged(object sender, EventArgs e)
        {
            UpdateFinalPrice();
        }

        private void UpdateFinalPrice()
        {
            decimal finalPrice = _productPrice;
            if (chkUsePoints.Checked)
            {
                int pointsToUse = (int)numPointsToUse.Value;
                decimal discount = Math.Floor((decimal)pointsToUse / 100);
                finalPrice = _productPrice - discount;
            }
            lblReducedPrice.Text = "৳" + finalPrice.ToString("N0");
        }

        private void btnCompletePurchase_Click(object sender, EventArgs e)
        {
            int pointsUsed = 0;
            if (chkUsePoints.Checked)
            {
                pointsUsed = (int)numPointsToUse.Value;
            }
            int finalPoints = _currentPoints - pointsUsed + _pointsEarned;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Customer SET Points = @NewPoints WHERE User_Name = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NewPoints", finalPoints);
                        cmd.Parameters.AddWithValue("@UserName", CurrentUser.UserName);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Purchase Complete! Thank you.", "Success");

                // Close the purchase page and this payslip, then show the customer homepage again
                Application.OpenForms.OfType<PurchasePage>().FirstOrDefault()?.Close();
                var customerHome = Application.OpenForms.OfType<CustomerHomePage>().FirstOrDefault();
                if (customerHome != null)
                {
                    customerHome.Show();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to complete purchase. Error: " + ex.Message);
            }
        }
    }
}