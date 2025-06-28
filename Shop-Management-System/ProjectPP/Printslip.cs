using System;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class Printslip : Form
    {
        public Printslip(string model, string productCode, string productType, decimal unitPrice, int quantity, decimal totalPrice, string features)
        {
            InitializeComponent();

            lblModel.Text = "Model: " + model;
            lblProductCode.Text = "Product Code: " + productCode;
            lblProductType.Text = "Type: " + productType;
            lblUnitPrice.Text = "Unit Price: ৳" + unitPrice.ToString("N0");
            lblQuantity.Text = "Quantity: " + quantity;
            lblTotalPrice.Text = "Total Price: ৳" + totalPrice.ToString("N0");
            txtFeatures.Text = features;
        }

        private void Printslip_Load(object sender, EventArgs e)
        {
            // Optional: further layout or print prep logic
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Starting salesmanHomePage = new Starting();
            salesmanHomePage.Show();
            this.Close();
        }
    }
}
