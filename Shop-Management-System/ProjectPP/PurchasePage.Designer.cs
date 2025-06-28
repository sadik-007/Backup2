namespace ProjectPP
{
    partial class PurchasePage
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.lblUnavailable = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblModel.Location = new System.Drawing.Point(470, 40);
            this.lblModel.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(219, 45);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Product Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblPrice.Location = new System.Drawing.Point(471, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(156, 41);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "৳150,000";
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmPurchase.FlatAppearance.BorderSize = 0;
            this.btnConfirmPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPurchase.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPurchase.Location = new System.Drawing.Point(478, 520);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(540, 55);
            this.btnConfirmPurchase.TabIndex = 6;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            this.btnConfirmPurchase.Click += new System.EventHandler(this.btnConfirmPurchase_Click);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblProductCode.ForeColor = System.Drawing.Color.Gray;
            this.lblProductCode.Location = new System.Drawing.Point(474, 95);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(131, 23);
            this.lblProductCode.TabIndex = 7;
            this.lblProductCode.Text = "Product Code: -";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblType.ForeColor = System.Drawing.Color.Gray;
            this.lblType.Location = new System.Drawing.Point(474, 118);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(126, 23);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Product Type: -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key Features";
            // 
            // txtFeatures
            // 
            this.txtFeatures.BackColor = System.Drawing.Color.White;
            this.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeatures.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFeatures.Location = new System.Drawing.Point(478, 251);
            this.txtFeatures.Multiline = true;
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.ReadOnly = true;
            this.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeatures.Size = new System.Drawing.Size(540, 260);
            this.txtFeatures.TabIndex = 10;
            this.txtFeatures.TabStop = false;
            // 
            // lblUnavailable
            // 
            this.lblUnavailable.AutoSize = true;
            this.lblUnavailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnavailable.ForeColor = System.Drawing.Color.Red;
            this.lblUnavailable.Location = new System.Drawing.Point(473, 185);
            this.lblUnavailable.Name = "lblUnavailable";
            this.lblUnavailable.Size = new System.Drawing.Size(359, 28);
            this.lblUnavailable.TabIndex = 11;
            this.lblUnavailable.Text = "This product is currently unavailable";
            this.lblUnavailable.Visible = false;
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(40, 40);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(400, 400);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // PurchasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 603);
            this.Controls.Add(this.lblUnavailable);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnConfirmPurchase);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.picProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchasePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm Your Purchase";
            this.Load += new System.EventHandler(this.PurchasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.Label lblUnavailable;
    }
}