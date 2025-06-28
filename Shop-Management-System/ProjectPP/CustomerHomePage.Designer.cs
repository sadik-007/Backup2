namespace ProjectPP
{
    partial class CustomerHomePage
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
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatALL = new System.Windows.Forms.Button();
            this.btnCatLaptop = new System.Windows.Forms.Button();
            this.btnCatDesktop = new System.Windows.Forms.Button();
            this.btnCatWatch = new System.Windows.Forms.Button();
            this.btnCatPhone = new System.Windows.Forms.Button();
            this.btnCatTablet = new System.Windows.Forms.Button();
            this.btnCatCamera = new System.Windows.Forms.Button();
            this.btnCatTV = new System.Windows.Forms.Button();
            this.btnCatMonitor = new System.Windows.Forms.Button();
            this.btnCatAccessories = new System.Windows.Forms.Button();
            this.btnCatHeadphones = new System.Windows.Forms.Button();
            this.btnCatWebcam = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcomeUser);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblShopName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1282, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(940, 28);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(330, 28);
            this.lblWelcomeUser.TabIndex = 3;
            this.lblWelcomeUser.Text = "👤 Welcome, User";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(880, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(350, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(531, 38);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Products...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblShopName.Location = new System.Drawing.Point(25, 17);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(184, 45);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Tech Hub";
            this.lblShopName.Click += new System.EventHandler(this.lblShopName_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 130);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBody.Size = new System.Drawing.Size(1282, 573);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.White;
            this.pnlCategories.Controls.Add(this.btnCatALL);
            this.pnlCategories.Controls.Add(this.btnCatLaptop);
            this.pnlCategories.Controls.Add(this.btnCatDesktop);
            this.pnlCategories.Controls.Add(this.btnCatWatch);
            this.pnlCategories.Controls.Add(this.btnCatPhone);
            this.pnlCategories.Controls.Add(this.btnCatTablet);
            this.pnlCategories.Controls.Add(this.btnCatCamera);
            this.pnlCategories.Controls.Add(this.btnCatTV);
            this.pnlCategories.Controls.Add(this.btnCatMonitor);
            this.pnlCategories.Controls.Add(this.btnCatAccessories);
            this.pnlCategories.Controls.Add(this.btnCatHeadphones);
            this.pnlCategories.Controls.Add(this.btnCatWebcam);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 80);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Padding = new System.Windows.Forms.Padding(15, 6, 15, 5);
            this.pnlCategories.Size = new System.Drawing.Size(1282, 50);
            this.pnlCategories.TabIndex = 3;
            // 
            // btnCatALL
            // 
            this.btnCatALL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCatALL.Location = new System.Drawing.Point(20, 9);
            this.btnCatALL.Name = "btnCatALL";
            this.btnCatALL.Size = new System.Drawing.Size(75, 35);
            this.btnCatALL.TabIndex = 0;
            this.btnCatALL.Text = "ALL";
            this.btnCatALL.UseVisualStyleBackColor = true;
            this.btnCatALL.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatLaptop
            // 
            this.btnCatLaptop.AutoSize = true;
            this.btnCatLaptop.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatLaptop.Location = new System.Drawing.Point(100, 9);
            this.btnCatLaptop.Name = "btnCatLaptop";
            this.btnCatLaptop.Size = new System.Drawing.Size(77, 35);
            this.btnCatLaptop.TabIndex = 1;
            this.btnCatLaptop.Text = "Laptop";
            this.btnCatLaptop.UseVisualStyleBackColor = true;
            this.btnCatLaptop.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatDesktop
            // 
            this.btnCatDesktop.AutoSize = true;
            this.btnCatDesktop.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatDesktop.Location = new System.Drawing.Point(182, 9);
            this.btnCatDesktop.Name = "btnCatDesktop";
            this.btnCatDesktop.Size = new System.Drawing.Size(88, 35);
            this.btnCatDesktop.TabIndex = 2;
            this.btnCatDesktop.Text = "Desktop";
            this.btnCatDesktop.UseVisualStyleBackColor = true;
            this.btnCatDesktop.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatWatch
            // 
            this.btnCatWatch.AutoSize = true;
            this.btnCatWatch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatWatch.Location = new System.Drawing.Point(275, 9);
            this.btnCatWatch.Name = "btnCatWatch";
            this.btnCatWatch.Size = new System.Drawing.Size(75, 35);
            this.btnCatWatch.TabIndex = 3;
            this.btnCatWatch.Text = "Watch";
            this.btnCatWatch.UseVisualStyleBackColor = true;
            this.btnCatWatch.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatPhone
            // 
            this.btnCatPhone.AutoSize = true;
            this.btnCatPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatPhone.Location = new System.Drawing.Point(355, 9);
            this.btnCatPhone.Name = "btnCatPhone";
            this.btnCatPhone.Size = new System.Drawing.Size(75, 35);
            this.btnCatPhone.TabIndex = 4;
            this.btnCatPhone.Text = "Phone";
            this.btnCatPhone.UseVisualStyleBackColor = true;
            this.btnCatPhone.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatTablet
            // 
            this.btnCatTablet.AutoSize = true;
            this.btnCatTablet.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatTablet.Location = new System.Drawing.Point(435, 9);
            this.btnCatTablet.Name = "btnCatTablet";
            this.btnCatTablet.Size = new System.Drawing.Size(75, 35);
            this.btnCatTablet.TabIndex = 5;
            this.btnCatTablet.Text = "Tablet";
            this.btnCatTablet.UseVisualStyleBackColor = true;
            this.btnCatTablet.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatCamera
            // 
            this.btnCatCamera.AutoSize = true;
            this.btnCatCamera.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatCamera.Location = new System.Drawing.Point(515, 9);
            this.btnCatCamera.Name = "btnCatCamera";
            this.btnCatCamera.Size = new System.Drawing.Size(85, 35);
            this.btnCatCamera.TabIndex = 6;
            this.btnCatCamera.Text = "Camera";
            this.btnCatCamera.UseVisualStyleBackColor = true;
            this.btnCatCamera.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatTV
            // 
            this.btnCatTV.AutoSize = true;
            this.btnCatTV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatTV.Location = new System.Drawing.Point(605, 9);
            this.btnCatTV.Name = "btnCatTV";
            this.btnCatTV.Size = new System.Drawing.Size(46, 35);
            this.btnCatTV.TabIndex = 7;
            this.btnCatTV.Text = "TV";
            this.btnCatTV.UseVisualStyleBackColor = true;
            this.btnCatTV.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatMonitor
            // 
            this.btnCatMonitor.AutoSize = true;
            this.btnCatMonitor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatMonitor.Location = new System.Drawing.Point(656, 9);
            this.btnCatMonitor.Name = "btnCatMonitor";
            this.btnCatMonitor.Size = new System.Drawing.Size(84, 35);
            this.btnCatMonitor.TabIndex = 8;
            this.btnCatMonitor.Text = "Monitor";
            this.btnCatMonitor.UseVisualStyleBackColor = true;
            this.btnCatMonitor.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatAccessories
            // 
            this.btnCatAccessories.AutoSize = true;
            this.btnCatAccessories.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatAccessories.Location = new System.Drawing.Point(745, 9);
            this.btnCatAccessories.Name = "btnCatAccessories";
            this.btnCatAccessories.Size = new System.Drawing.Size(113, 35);
            this.btnCatAccessories.TabIndex = 9;
            this.btnCatAccessories.Text = "Accessories";
            this.btnCatAccessories.UseVisualStyleBackColor = true;
            this.btnCatAccessories.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatHeadphones
            // 
            this.btnCatHeadphones.AutoSize = true;
            this.btnCatHeadphones.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatHeadphones.Location = new System.Drawing.Point(863, 9);
            this.btnCatHeadphones.Name = "btnCatHeadphones";
            this.btnCatHeadphones.Size = new System.Drawing.Size(117, 35);
            this.btnCatHeadphones.TabIndex = 10;
            this.btnCatHeadphones.Text = "Headphones";
            this.btnCatHeadphones.UseVisualStyleBackColor = true;
            this.btnCatHeadphones.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnCatWebcam
            // 
            this.btnCatWebcam.AutoSize = true;
            this.btnCatWebcam.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCatWebcam.Location = new System.Drawing.Point(985, 9);
            this.btnCatWebcam.Name = "btnCatWebcam";
            this.btnCatWebcam.Size = new System.Drawing.Size(91, 35);
            this.btnCatWebcam.TabIndex = 11;
            this.btnCatWebcam.Text = "Webcam";
            this.btnCatWebcam.UseVisualStyleBackColor = true;
            this.btnCatWebcam.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CustomerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Hub - Welcome";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlBody;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.FlowLayoutPanel pnlCategories;
        private System.Windows.Forms.Button btnCatALL;
        private System.Windows.Forms.Button btnCatLaptop;
        private System.Windows.Forms.Button btnCatDesktop;
        private System.Windows.Forms.Button btnCatWatch;
        private System.Windows.Forms.Button btnCatPhone;
        private System.Windows.Forms.Button btnCatTablet;
        private System.Windows.Forms.Button btnCatCamera;
        private System.Windows.Forms.Button btnCatTV;
        private System.Windows.Forms.Button btnCatMonitor;
        private System.Windows.Forms.Button btnCatAccessories;
        private System.Windows.Forms.Button btnCatHeadphones;
        private System.Windows.Forms.Button btnCatWebcam;
    }
}