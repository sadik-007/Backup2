namespace ProjectPP
{
    partial class ProductEntry
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.lblRegularPrice = new System.Windows.Forms.Label();
            this.txtRegularPrice = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.numAvailable = new System.Windows.Forms.NumericUpDown();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Product Details";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblProductCode.Location = new System.Drawing.Point(30, 100);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(125, 25);
            this.lblProductCode.TabIndex = 1;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtProductCode.Location = new System.Drawing.Point(35, 128);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(280, 31);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblProductType.Location = new System.Drawing.Point(30, 175);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(120, 25);
            this.lblProductType.TabIndex = 3;
            this.lblProductType.Text = "Product Type:";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(35, 203);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(280, 33);
            this.cmbProductType.TabIndex = 1;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblBrand.Location = new System.Drawing.Point(30, 250);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(114, 25);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand Name:";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtBrand.Location = new System.Drawing.Point(35, 278);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(280, 31);
            this.txtBrand.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblModel.Location = new System.Drawing.Point(30, 325);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(67, 25);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtModel.Location = new System.Drawing.Point(35, 353);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(280, 31);
            this.txtModel.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblStatus.Location = new System.Drawing.Point(30, 400);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 25);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(35, 428);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(280, 33);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblCurrentPrice.Location = new System.Drawing.Point(380, 100);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(116, 25);
            this.lblCurrentPrice.TabIndex = 11;
            this.lblCurrentPrice.Text = "Current Price:";
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCurrentPrice.Location = new System.Drawing.Point(385, 128);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(280, 31);
            this.txtCurrentPrice.TabIndex = 5;
            // 
            // lblRegularPrice
            // 
            this.lblRegularPrice.AutoSize = true;
            this.lblRegularPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblRegularPrice.Location = new System.Drawing.Point(380, 175);
            this.lblRegularPrice.Name = "lblRegularPrice";
            this.lblRegularPrice.Size = new System.Drawing.Size(117, 25);
            this.lblRegularPrice.TabIndex = 13;
            this.lblRegularPrice.Text = "Regular Price:";
            // 
            // txtRegularPrice
            // 
            this.txtRegularPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtRegularPrice.Location = new System.Drawing.Point(385, 203);
            this.txtRegularPrice.Name = "txtRegularPrice";
            this.txtRegularPrice.Size = new System.Drawing.Size(280, 31);
            this.txtRegularPrice.TabIndex = 6;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblAvailable.Location = new System.Drawing.Point(380, 250);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(154, 25);
            this.lblAvailable.TabIndex = 15;
            this.lblAvailable.Text = "Available Product:";
            // 
            // numAvailable
            // 
            this.numAvailable.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.numAvailable.Location = new System.Drawing.Point(385, 278);
            this.numAvailable.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAvailable.Name = "numAvailable";
            this.numAvailable.Size = new System.Drawing.Size(280, 31);
            this.numAvailable.TabIndex = 7;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblFeatures.Location = new System.Drawing.Point(380, 325);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(115, 25);
            this.lblFeatures.TabIndex = 17;
            this.lblFeatures.Text = "Key Features:";
            // 
            // txtFeatures
            // 
            this.txtFeatures.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFeatures.Location = new System.Drawing.Point(385, 353);
            this.txtFeatures.Multiline = true;
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeatures.Size = new System.Drawing.Size(280, 108);
            this.txtFeatures.TabIndex = 8;
            // 
            // picProductImage
            // 
            this.picProductImage.BackColor = System.Drawing.Color.Gainsboro;
            this.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProductImage.Location = new System.Drawing.Point(724, 128);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(300, 256);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 19;
            this.picProductImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnBrowseImage.Location = new System.Drawing.Point(724, 390);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(300, 40);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "Browse for Image...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(724, 550);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(300, 55);
            this.btnSaveProduct.TabIndex = 10;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(544, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 55);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProductEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picProductImage);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.numAvailable);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.txtRegularPrice);
            this.Controls.Add(this.lblRegularPrice);
            this.Controls.Add(this.txtCurrentPrice);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "ProductEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Entry Form";
            this.Load += new System.EventHandler(this.ProductEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Label lblRegularPrice;
        private System.Windows.Forms.TextBox txtRegularPrice;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.NumericUpDown numAvailable;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnClear;
    }
}