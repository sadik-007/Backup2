using System;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class PaySlip : Form
    {
        public PaySlip(string productName, decimal productPrice, int pointsAdded, int newTotalPoints)
        {
            InitializeComponent();

            // Populate the labels with the data passed from the purchase page
            lblUserName.Text = CurrentUser.FullName;
            lblProductName.Text = productName;
            lblPrice.Text = "৳" + productPrice.ToString("N0");
            lblPointsAdded.Text = "+ " + pointsAdded.ToString();
            lblTotalPoints.Text = newTotalPoints.ToString();

            // Add extra details
            lblTransactionInfo.Text = "Date: " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            // Optional: Any logic you need when the payslip loads
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}