using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class SellItem : Form
    {
        private byte[] _imageData;
        private string _model, _productCode, _productType, _features;
        private int _availableQty;
        private decimal _unitPrice;

        public SellItem(byte[] imageData, string model, decimal price, string productCode, string productType, string features, int availableQty)
        {
            InitializeComponent();

            _imageData = imageData;
            _model = model;
            _unitPrice = price;
            _productCode = productCode;
            _productType = productType;
            _features = features;
            _availableQty = availableQty;
        }

        private void SellItem_Load(object sender, EventArgs e)
        {
            lblModel.Text = _model;
            lblProductCode.Text = "Product Code: " + _productCode;
            lblType.Text = "Product Type: " + _productType;
            lblUnitPrice.Text = "Unit Price: ৳" + _unitPrice.ToString("N0");
            lblAvailable.Text = "Available: " + _availableQty.ToString();
            txtFeatures.Text = _features;

            if (_imageData != null && _imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_imageData))
                {
                    picProduct.Image = Image.FromStream(ms);
                }
            }

            if (_availableQty <= 0)
            {
                lblOutOfStock.Visible = true;
                btnConfirmSell.Enabled = false;
                btnConfirmSell.BackColor = Color.Gray;
            }

            txtQuantity.Text = "1";
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (int.TryParse(txtQuantity.Text, out int qty))
            {
                if (qty <= _availableQty && qty > 0)
                {
                    decimal total = qty * _unitPrice;
                    lblTotal.Text = "Total: ৳" + total.ToString("N0");
                    btnConfirmSell.Enabled = true;
                    lblQtyError.Visible = false;
                }
                else
                {
                    lblTotal.Text = "Total: ৳0";
                    btnConfirmSell.Enabled = false;
                    lblQtyError.Visible = true;
                }
            }
            else
            {
                lblTotal.Text = "Total: ৳0";
                btnConfirmSell.Enabled = false;
                lblQtyError.Visible = true;
            }
        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnConfirmSell_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int qty) && qty > 0 && qty <= _availableQty)
            {
                decimal totalPrice = qty * _unitPrice;

                // Don't pass image to Printslip anymore
                Printslip slip = new Printslip(
                    _model,
                    _productCode,
                    _productType,
                    _unitPrice,
                    qty,
                    totalPrice,
                    _features
                );
                slip.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
