namespace ProjectPP
{
    partial class PaySlip
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPointsAdded = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.chkUsePoints = new System.Windows.Forms.CheckBox();
            this.numPointsToUse = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReducedPrice = new System.Windows.Forms.Label();
            this.btnCompletePurchase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPointsToUse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pay Slip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(230, 90);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 28);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(230, 130);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(95, 28);
            this.lblProductPrice.TabIndex = 4;
            this.lblProductPrice.Text = "৳10,000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(33, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Points Earned:";
            // 
            // lblPointsAdded
            // 
            this.lblPointsAdded.AutoSize = true;
            this.lblPointsAdded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsAdded.ForeColor = System.Drawing.Color.Green;
            this.lblPointsAdded.Location = new System.Drawing.Point(230, 170);
            this.lblPointsAdded.Name = "lblPointsAdded";
            this.lblPointsAdded.Size = new System.Drawing.Size(66, 28);
            this.lblPointsAdded.TabIndex = 6;
            this.lblPointsAdded.Text = "+ 100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(33, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Your Available Points:";
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.Location = new System.Drawing.Point(230, 230);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(48, 28);
            this.lblCurrentPoints.TabIndex = 8;
            this.lblCurrentPoints.Text = "500";
            // 
            // chkUsePoints
            // 
            this.chkUsePoints.AutoSize = true;
            this.chkUsePoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsePoints.Location = new System.Drawing.Point(38, 270);
            this.chkUsePoints.Name = "chkUsePoints";
            this.chkUsePoints.Size = new System.Drawing.Size(161, 32);
            this.chkUsePoints.TabIndex = 9;
            this.chkUsePoints.Text = "Use my points";
            this.chkUsePoints.UseVisualStyleBackColor = true;
            this.chkUsePoints.CheckedChanged += new System.EventHandler(this.chkUsePoints_CheckedChanged);
            // 
            // numPointsToUse
            // 
            this.numPointsToUse.Enabled = false;
            this.numPointsToUse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numPointsToUse.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPointsToUse.Location = new System.Drawing.Point(235, 270);
            this.numPointsToUse.Name = "numPointsToUse";
            this.numPointsToUse.Size = new System.Drawing.Size(120, 34);
            this.numPointsToUse.TabIndex = 10;
            this.numPointsToUse.ValueChanged += new System.EventHandler(this.numPointsToUse_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(32, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Final Price:";
            // 
            // lblReducedPrice
            // 
            this.lblReducedPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReducedPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblReducedPrice.Location = new System.Drawing.Point(228, 344);
            this.lblReducedPrice.Name = "lblReducedPrice";
            this.lblReducedPrice.Size = new System.Drawing.Size(200, 41);
            this.lblReducedPrice.TabIndex = 12;
            this.lblReducedPrice.Text = "৳9,995";
            // 
            // btnCompletePurchase
            // 
            this.btnCompletePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCompletePurchase.FlatAppearance.BorderSize = 0;
            this.btnCompletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletePurchase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCompletePurchase.ForeColor = System.Drawing.Color.White;
            this.btnCompletePurchase.Location = new System.Drawing.Point(38, 410);
            this.btnCompletePurchase.Name = "btnCompletePurchase";
            this.btnCompletePurchase.Size = new System.Drawing.Size(390, 55);
            this.btnCompletePurchase.TabIndex = 13;
            this.btnCompletePurchase.Text = "Complete Purchase";
            this.btnCompletePurchase.UseVisualStyleBackColor = false;
            this.btnCompletePurchase.Click += new System.EventHandler(this.btnCompletePurchase_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(38, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 1);
            this.panel1.TabIndex = 14;
            // 
            // PaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompletePurchase);
            this.Controls.Add(this.lblReducedPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numPointsToUse);
            this.Controls.Add(this.chkUsePoints);
            this.Controls.Add(this.lblCurrentPoints);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPointsAdded);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finalize Purchase";
            this.Load += new System.EventHandler(this.PaySlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPointsToUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPointsAdded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.CheckBox chkUsePoints;
        private System.Windows.Forms.NumericUpDown numPointsToUse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReducedPrice;
        private System.Windows.Forms.Button btnCompletePurchase;
        private System.Windows.Forms.Panel panel1;
    }
}