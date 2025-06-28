using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class PurchasePage : Form
    {
        private byte[] _imageData;
        private string _model, _productCode, _productType, _features, _status;
        private decimal _price;

        public PurchasePage(byte[] imageData, string model, decimal price, string productCode, string productType, string features, string status)
        {
            InitializeComponent();

            _imageData = imageData;
            _model = model;
            _price = price;
            _productCode = productCode;
            _productType = productType;
            _features = features;
            _status = status;
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
            MessageBox.Show("Thank you for your purchase!", "Purchase Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}