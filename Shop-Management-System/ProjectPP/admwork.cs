using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class admwork : Form
    {
        public admwork()
        {
            InitializeComponent();
        }

        private void workproduct_Click(object sender, EventArgs e)
        {

            ProductEntry productentry = new ProductEntry();
            productentry.Show();
            this.Hide();
        }

        private void worknoti_Click(object sender, EventArgs e)
        {
            admnotifi admNotifi = new admnotifi();
            admNotifi.Show();
            this.Hide();
        }

        private void workback_Click(object sender, EventArgs e)
        {
            AdminLog admlog = new AdminLog();
            admlog.Show();
            this.Hide();
        }

        private void workreq_Click(object sender, EventArgs e)
        {
            admrequest admreq = new admrequest();
            admreq.Show();
            this.Hide();
        }

        private void workorder_Click(object sender, EventArgs e)
        {
            admorder admorder = new admorder();
            admorder.Show();
            this.Hide();
        }
    }
}
