// SalesmanHomePage.Designer.cs
namespace ProjectPP
{
    partial class SalesmanHomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.btnMobile = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnAccessories = new System.Windows.Forms.Button();
            this.btnHeadphones = new System.Windows.Forms.Button();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblShopName);
            this.pnlHeader.Controls.Add(this.lblWelcomeUser);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(886, 65);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(729, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.Blue;
            this.lblShopName.Location = new System.Drawing.Point(15, 12);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(274, 37);
            this.lblShopName.TabIndex = 1;
            this.lblShopName.Text = "📦 Sales Dashboard";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWelcomeUser.Location = new System.Drawing.Point(677, 9);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(198, 24);
            this.lblWelcomeUser.TabIndex = 2;
            this.lblWelcomeUser.Text = "👤 Welcome, Salesman";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(360, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search Products...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(578, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCategories.Controls.Add(this.btnAll);
            this.pnlCategories.Controls.Add(this.btnLaptop);
            this.pnlCategories.Controls.Add(this.btnDesktop);
            this.pnlCategories.Controls.Add(this.btnMobile);
            this.pnlCategories.Controls.Add(this.btnPhone);
            this.pnlCategories.Controls.Add(this.btnTablet);
            this.pnlCategories.Controls.Add(this.btnCamera);
            this.pnlCategories.Controls.Add(this.btnTV);
            this.pnlCategories.Controls.Add(this.btnMonitor);
            this.pnlCategories.Controls.Add(this.btnAccessories);
            this.pnlCategories.Controls.Add(this.btnHeadphones);
            this.pnlCategories.Controls.Add(this.btnWebcam);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 65);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(886, 61);
            this.pnlCategories.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAll.Location = new System.Drawing.Point(3, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "ALL";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLaptop.Location = new System.Drawing.Point(84, 3);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(75, 23);
            this.btnLaptop.TabIndex = 1;
            this.btnLaptop.Text = "Laptop";
            this.btnLaptop.UseVisualStyleBackColor = false;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // btnDesktop
            // 
            this.btnDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDesktop.Location = new System.Drawing.Point(165, 3);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(75, 23);
            this.btnDesktop.TabIndex = 2;
            this.btnDesktop.Text = "Desktop";
            this.btnDesktop.UseVisualStyleBackColor = false;
            this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
            // 
            // btnMobile
            // 
            this.btnMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMobile.Location = new System.Drawing.Point(246, 3);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(75, 23);
            this.btnMobile.TabIndex = 3;
            this.btnMobile.Text = "Mobile";
            this.btnMobile.UseVisualStyleBackColor = false;
            this.btnMobile.Click += new System.EventHandler(this.btnMobile_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPhone.Location = new System.Drawing.Point(327, 3);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(75, 23);
            this.btnPhone.TabIndex = 4;
            this.btnPhone.Text = "Phone";
            this.btnPhone.UseVisualStyleBackColor = false;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTablet.Location = new System.Drawing.Point(408, 3);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(75, 23);
            this.btnTablet.TabIndex = 5;
            this.btnTablet.Text = "Tablet";
            this.btnTablet.UseVisualStyleBackColor = false;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCamera.Location = new System.Drawing.Point(489, 3);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(75, 23);
            this.btnCamera.TabIndex = 6;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTV.Location = new System.Drawing.Point(570, 3);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(75, 23);
            this.btnTV.TabIndex = 7;
            this.btnTV.Text = "TV";
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMonitor.Location = new System.Drawing.Point(651, 3);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnMonitor.TabIndex = 8;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnAccessories
            // 
            this.btnAccessories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAccessories.Location = new System.Drawing.Point(732, 3);
            this.btnAccessories.Name = "btnAccessories";
            this.btnAccessories.Size = new System.Drawing.Size(75, 23);
            this.btnAccessories.TabIndex = 9;
            this.btnAccessories.Text = "Accessories";
            this.btnAccessories.UseVisualStyleBackColor = false;
            this.btnAccessories.Click += new System.EventHandler(this.btnAccessories_Click);
            // 
            // btnHeadphones
            // 
            this.btnHeadphones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHeadphones.Location = new System.Drawing.Point(3, 32);
            this.btnHeadphones.Name = "btnHeadphones";
            this.btnHeadphones.Size = new System.Drawing.Size(75, 23);
            this.btnHeadphones.TabIndex = 10;
            this.btnHeadphones.Text = "Headphones";
            this.btnHeadphones.UseVisualStyleBackColor = false;
            this.btnHeadphones.Click += new System.EventHandler(this.btnHeadphones_Click);
            // 
            // btnWebcam
            // 
            this.btnWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWebcam.Location = new System.Drawing.Point(84, 32);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(75, 23);
            this.btnWebcam.TabIndex = 11;
            this.btnWebcam.Text = "Webcam";
            this.btnWebcam.UseVisualStyleBackColor = false;
            this.btnWebcam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 126);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(886, 445);
            this.pnlBody.TabIndex = 0;
            // 
            // SalesmanHomePage
            // 
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SalesmanHomePage";
            this.Text = "Salesman Dashboard";
            this.Load += new System.EventHandler(this.SalesmanHomePage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel pnlCategories;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.Button btnMobile;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnAccessories;
        private System.Windows.Forms.Button btnHeadphones;
        private System.Windows.Forms.Button btnWebcam;
        private System.Windows.Forms.FlowLayoutPanel pnlBody;
    }
}
