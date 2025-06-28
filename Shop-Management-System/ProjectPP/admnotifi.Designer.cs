namespace ProjectPP
{
    partial class admnotifi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifiback = new System.Windows.Forms.Button();
            this.notifiEmptyNotifications = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 508);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // notifiback
            // 
            this.notifiback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notifiback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifiback.Location = new System.Drawing.Point(34, 626);
            this.notifiback.Name = "notifiback";
            this.notifiback.Size = new System.Drawing.Size(107, 45);
            this.notifiback.TabIndex = 1;
            this.notifiback.Text = "Back";
            this.notifiback.UseVisualStyleBackColor = true;
            this.notifiback.Click += new System.EventHandler(this.notifiback_Click);
            // 
            // notifiEmptyNotifications
            // 
            this.notifiEmptyNotifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifiEmptyNotifications.AutoSize = true;
            this.notifiEmptyNotifications.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifiEmptyNotifications.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notifiEmptyNotifications.Location = new System.Drawing.Point(484, 335);
            this.notifiEmptyNotifications.Name = "notifiEmptyNotifications";
            this.notifiEmptyNotifications.Size = new System.Drawing.Size(215, 31);
            this.notifiEmptyNotifications.TabIndex = 2;
            this.notifiEmptyNotifications.Text = "No notifications yet.";
            this.notifiEmptyNotifications.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notifications";
            // 
            // admnotifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notifiEmptyNotifications);
            this.Controls.Add(this.notifiback);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admnotifi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Notifications";
            this.Load += new System.EventHandler(this.admnotifi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button notifiback;
        private System.Windows.Forms.Label notifiEmptyNotifications;
        private System.Windows.Forms.Label label1;
    }
}