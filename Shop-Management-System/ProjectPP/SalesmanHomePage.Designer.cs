namespace ProjectPP
{
    partial class SalesmanHomePage
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.btnMobile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBody.Location = new System.Drawing.Point(20, 120);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1150, 500);
            this.pnlBody.TabIndex = 0;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblShopName.Location = new System.Drawing.Point(20, 10);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(339, 46);
            this.lblShopName.TabIndex = 1;
            this.lblShopName.Text = "📦 Sales Dashboard";
            this.lblShopName.Click += new System.EventHandler(this.lblShopName_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWelcomeUser.Location = new System.Drawing.Point(902, 25);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(250, 30);
            this.lblWelcomeUser.TabIndex = 2;
            this.lblWelcomeUser.Text = "👤 Welcome, Salesman";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWelcomeUser.Click += new System.EventHandler(this.lblWelcomeUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(741, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search Products...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(1070, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAll.Location = new System.Drawing.Point(20, 70);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(70, 30);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "ALL";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLaptop.Location = new System.Drawing.Point(100, 70);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(90, 30);
            this.btnLaptop.TabIndex = 6;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnDesktop
            // 
            this.btnDesktop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDesktop.Location = new System.Drawing.Point(200, 70);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(90, 30);
            this.btnDesktop.TabIndex = 7;
            this.btnDesktop.Text = "Desktop";
            this.btnDesktop.UseVisualStyleBackColor = true;
            this.btnDesktop.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnMobile
            // 
            this.btnMobile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMobile.Location = new System.Drawing.Point(300, 70);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(90, 30);
            this.btnMobile.TabIndex = 8;
            this.btnMobile.Text = "Mobile";
            this.btnMobile.UseVisualStyleBackColor = true;
            this.btnMobile.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // SalesmanHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnMobile);
            this.Controls.Add(this.btnDesktop);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SalesmanHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman Dashboard";
            this.Load += new System.EventHandler(this.SalesmanHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBody;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.Button btnMobile;
    }
}
