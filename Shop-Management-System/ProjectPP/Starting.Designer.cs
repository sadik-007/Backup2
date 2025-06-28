namespace ProjectPP
{
    partial class Starting
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesmanLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblShopName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(962, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(660, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(262, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(399, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Products...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblShopName.Location = new System.Drawing.Point(19, 14);
            this.lblShopName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(136, 37);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Tech Hub";
            this.lblShopName.Click += new System.EventHandler(this.lblShopName_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.phoneToolStripMenuItem,
            this.tabletToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.tvToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 65);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(962, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.computerToolStripMenuItem.Text = "Computer";
            this.computerToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.phoneToolStripMenuItem.Text = "Phone";
            this.phoneToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // tabletToolStripMenuItem
            // 
            this.tabletToolStripMenuItem.Name = "tabletToolStripMenuItem";
            this.tabletToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.tabletToolStripMenuItem.Text = "Tablet";
            this.tabletToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // tvToolStripMenuItem
            // 
            this.tvToolStripMenuItem.Name = "tvToolStripMenuItem";
            this.tvToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.tvToolStripMenuItem.Text = "TV";
            this.tvToolStripMenuItem.Click += new System.EventHandler(this.Category_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerLoginToolStripMenuItem,
            this.adminLoginToolStripMenuItem,
            this.salesmanLoginToolStripMenuItem,
            this.dealerLoginToolStripMenuItem});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.loginToolStripMenuItem.Text = "Log In";
            // 
            // customerLoginToolStripMenuItem
            // 
            this.customerLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.customerLoginToolStripMenuItem.Name = "customerLoginToolStripMenuItem";
            this.customerLoginToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.customerLoginToolStripMenuItem.Text = "🛒 Customer Login";
            this.customerLoginToolStripMenuItem.Click += new System.EventHandler(this.customerLoginToolStripMenuItem_Click);
            // 
            // adminLoginToolStripMenuItem
            // 
            this.adminLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.adminLoginToolStripMenuItem.Name = "adminLoginToolStripMenuItem";
            this.adminLoginToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.adminLoginToolStripMenuItem.Text = "👑 Admin Login";
            this.adminLoginToolStripMenuItem.Click += new System.EventHandler(this.adminLoginToolStripMenuItem_Click);
            // 
            // salesmanLoginToolStripMenuItem
            // 
            this.salesmanLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.salesmanLoginToolStripMenuItem.Name = "salesmanLoginToolStripMenuItem";
            this.salesmanLoginToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.salesmanLoginToolStripMenuItem.Text = "💼 Salesman Login";
            this.salesmanLoginToolStripMenuItem.Click += new System.EventHandler(this.salesmanLoginToolStripMenuItem_Click);
            // 
            // dealerLoginToolStripMenuItem
            // 
            this.dealerLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.dealerLoginToolStripMenuItem.Name = "dealerLoginToolStripMenuItem";
            this.dealerLoginToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.dealerLoginToolStripMenuItem.Text = "🤝 Dealer Login";
            this.dealerLoginToolStripMenuItem.Click += new System.EventHandler(this.dealerLoginToolStripMenuItem_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 93);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlBody.Size = new System.Drawing.Size(962, 478);
            this.pnlBody.TabIndex = 2;
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.pnlHeader);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Starting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Hub - Home";
            this.Load += new System.EventHandler(this.Starting_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tvToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel pnlBody;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesmanLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerLoginToolStripMenuItem;
    }
}