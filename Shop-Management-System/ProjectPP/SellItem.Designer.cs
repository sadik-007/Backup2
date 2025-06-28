namespace ProjectPP
{
    partial class SellItem
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
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmSell = new System.Windows.Forms.Button();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblQtyError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
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
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblUnitPrice.Location = new System.Drawing.Point(471, 140);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(180, 41);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price: ৳";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblProductCode.ForeColor = System.Drawing.Color.Gray;
            this.lblProductCode.Location = new System.Drawing.Point(474, 95);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(131, 23);
            this.lblProductCode.TabIndex = 3;
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
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Product Type: -";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblAvailable.ForeColor = System.Drawing.Color.Green;
            this.lblAvailable.Location = new System.Drawing.Point(474, 180);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(101, 23);
            this.lblAvailable.TabIndex = 5;
            this.lblAvailable.Text = "Available: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 6;
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
            this.txtFeatures.Size = new System.Drawing.Size(540, 100);
            this.txtFeatures.TabIndex = 7;
            this.txtFeatures.TabStop = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQty.Location = new System.Drawing.Point(474, 370);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(91, 28);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(580, 367);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 34);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblTotal.Location = new System.Drawing.Point(474, 420);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 32);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: ৳0";
            // 
            // btnConfirmSell
            // 
            this.btnConfirmSell.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnConfirmSell.FlatAppearance.BorderSize = 0;
            this.btnConfirmSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSell.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSell.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSell.Location = new System.Drawing.Point(478, 480);
            this.btnConfirmSell.Name = "btnConfirmSell";
            this.btnConfirmSell.Size = new System.Drawing.Size(540, 55);
            this.btnConfirmSell.TabIndex = 11;
            this.btnConfirmSell.Text = "Confirm Sale";
            this.btnConfirmSell.UseVisualStyleBackColor = false;
            this.btnConfirmSell.Click += new System.EventHandler(this.btnConfirmSell_Click);
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOutOfStock.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfStock.Location = new System.Drawing.Point(730, 180);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(254, 28);
            this.lblOutOfStock.TabIndex = 12;
            this.lblOutOfStock.Text = "This product is out of stock";
            this.lblOutOfStock.Visible = false;
            // 
            // lblQtyError
            // 
            this.lblQtyError.AutoSize = true;
            this.lblQtyError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQtyError.ForeColor = System.Drawing.Color.Red;
            this.lblQtyError.Location = new System.Drawing.Point(680, 372);
            this.lblQtyError.Name = "lblQtyError";
            this.lblQtyError.Size = new System.Drawing.Size(221, 23);
            this.lblQtyError.TabIndex = 13;
            this.lblQtyError.Text = "Invalid or exceeds available";
            this.lblQtyError.Visible = false;
            // 
            // SellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 563);
            this.Controls.Add(this.lblQtyError);
            this.Controls.Add(this.lblOutOfStock);
            this.Controls.Add(this.btnConfirmSell);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.picProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Product";
            this.Load += new System.EventHandler(this.SellItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmSell;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblQtyError;
    }
}
