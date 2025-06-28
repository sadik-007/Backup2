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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblQtyError = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnConfirmSell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblModel.Location = new System.Drawing.Point(30, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(87, 32);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(30, 48);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(0, 16);
            this.lblProductCode.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 16);
            this.lblType.TabIndex = 2;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(30, 96);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 16);
            this.lblUnitPrice.TabIndex = 3;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(30, 120);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(0, 16);
            this.lblAvailable.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(30, 216);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 28);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ৳0";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfStock.Location = new System.Drawing.Point(30, 144);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(79, 16);
            this.lblOutOfStock.TabIndex = 6;
            this.lblOutOfStock.Text = "Out of stock!";
            this.lblOutOfStock.Visible = false;
            // 
            // lblQtyError
            // 
            this.lblQtyError.AutoSize = true;
            this.lblQtyError.ForeColor = System.Drawing.Color.Red;
            this.lblQtyError.Location = new System.Drawing.Point(160, 168);
            this.lblQtyError.Name = "lblQtyError";
            this.lblQtyError.Size = new System.Drawing.Size(183, 16);
            this.lblQtyError.TabIndex = 7;
            this.lblQtyError.Text = "Invalid quantity or out of stock!";
            this.lblQtyError.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(30, 168);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 22);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtFeatures
            // 
            this.txtFeatures.BackColor = System.Drawing.Color.White;
            this.txtFeatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeatures.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFeatures.Location = new System.Drawing.Point(360, 48);
            this.txtFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFeatures.Multiline = true;
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.ReadOnly = true;
            this.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeatures.Size = new System.Drawing.Size(360, 104);
            this.txtFeatures.TabIndex = 9;
            this.txtFeatures.TabStop = false;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(360, 168);
            this.picProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(150, 120);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 10;
            this.picProduct.TabStop = false;
            // 
            // btnConfirmSell
            // 
            this.btnConfirmSell.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmSell.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSell.Location = new System.Drawing.Point(30, 256);
            this.btnConfirmSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmSell.Name = "btnConfirmSell";
            this.btnConfirmSell.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmSell.TabIndex = 11;
            this.btnConfirmSell.Text = "Confirm Sell";
            this.btnConfirmSell.UseVisualStyleBackColor = false;
            this.btnConfirmSell.Click += new System.EventHandler(this.btnConfirmSell_Click);
            // 
            // SellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 401);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOutOfStock);
            this.Controls.Add(this.lblQtyError);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnConfirmSell);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellItem";
            this.Text = "Sell Item";
            this.Load += new System.EventHandler(this.SellItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblQtyError;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnConfirmSell;
    }
}
