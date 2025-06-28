namespace ProjectPP
{
    partial class admnotifi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notinotifica = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifiback = new System.Windows.Forms.Button();
            this.notifiEmptyNotifications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // notinotifica
            // 
            this.notinotifica.AutoSize = true;
            this.notinotifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notinotifica.Location = new System.Drawing.Point(47, 34);
            this.notinotifica.Name = "notinotifica";
            this.notinotifica.Size = new System.Drawing.Size(193, 32);
            this.notinotifica.TabIndex = 0;
            this.notinotifica.Text = "Notifications:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // notifiback
            // 
            this.notifiback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifiback.Location = new System.Drawing.Point(94, 635);
            this.notifiback.Name = "notifiback";
            this.notifiback.Size = new System.Drawing.Size(75, 56);
            this.notifiback.TabIndex = 2;
            this.notifiback.Text = "Back";
            this.notifiback.UseVisualStyleBackColor = true;
            this.notifiback.Click += new System.EventHandler(this.notifiback_Click);
            // 
            // notifiEmptyNotifications
            // 
            this.notifiEmptyNotifications.AutoSize = true;
            this.notifiEmptyNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifiEmptyNotifications.Location = new System.Drawing.Point(61, 107);
            this.notifiEmptyNotifications.Name = "notifiEmptyNotifications";
            this.notifiEmptyNotifications.Size = new System.Drawing.Size(199, 29);
            this.notifiEmptyNotifications.TabIndex = 3;
            this.notifiEmptyNotifications.Text = "No Notifications";
            // 
            // admnotifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.notifiEmptyNotifications);
            this.Controls.Add(this.notifiback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.notinotifica);
            this.Name = "admnotifi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admnotifi";
            this.Load += new System.EventHandler(this.admnotifi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notinotifica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button notifiback;
        private System.Windows.Forms.Label notifiEmptyNotifications;
    }
}