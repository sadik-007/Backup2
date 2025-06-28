namespace ProjectPP
{
    partial class admorder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.orderplace = new System.Windows.Forms.Label();
            this.orderback = new System.Windows.Forms.Button();
            this.orderdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderdataGridView)).BeginInit();
            this.SuspendLayout();

            // orderplace
            this.orderplace.AutoSize = true;
            this.orderplace.Font = new System.Drawing.Font("Siyam Rupali", 16.2F,
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderplace.Location = new System.Drawing.Point(25, 24);
            this.orderplace.Name = "orderplace";
            this.orderplace.Size = new System.Drawing.Size(192, 46);
            this.orderplace.TabIndex = 0;
            this.orderplace.Text = "Place Order:";

            // orderback
            this.orderback.Font = new System.Drawing.Font("Siyam Rupali", 13.8F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderback.Location = new System.Drawing.Point(33, 613);
            this.orderback.Name = "orderback";
            this.orderback.Size = new System.Drawing.Size(102, 43);
            this.orderback.TabIndex = 1;
            this.orderback.Text = "Back";
            this.orderback.UseVisualStyleBackColor = true;
            this.orderback.Click += new System.EventHandler(this.orderback_Click);

            // orderdataGridView
            this.orderdataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdataGridView.Location = new System.Drawing.Point(12, 87);
            this.orderdataGridView.Name = "orderdataGridView";
            this.orderdataGridView.RowHeadersWidth = 51;
            this.orderdataGridView.RowTemplate.Height = 24;
            this.orderdataGridView.Size = new System.Drawing.Size(1158, 486);
            this.orderdataGridView.TabIndex = 2;
            this.orderdataGridView.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.orderdataGridView_CellContentClick);

            // admorder
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.orderdataGridView);
            this.Controls.Add(this.orderback);
            this.Controls.Add(this.orderplace);
            this.Name = "admorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admorder";
            ((System.ComponentModel.ISupportInitialize)(this.orderdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label orderplace;
        private System.Windows.Forms.Button orderback;
        private System.Windows.Forms.DataGridView orderdataGridView;
    }
}
