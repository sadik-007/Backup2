namespace ProjectPP
{
    partial class admwork
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
            this.workreq = new System.Windows.Forms.Button();
            this.workproduct = new System.Windows.Forms.Button();
            this.worknoti = new System.Windows.Forms.Button();
            this.workback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workreq
            // 
            this.workreq.Font = new System.Drawing.Font("Siyam Rupali", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workreq.Location = new System.Drawing.Point(148, 104);
            this.workreq.Name = "workreq";
            this.workreq.Size = new System.Drawing.Size(461, 106);
            this.workreq.TabIndex = 0;
            this.workreq.Text = "Request List";
            this.workreq.UseVisualStyleBackColor = true;
            this.workreq.Click += new System.EventHandler(this.workreq_Click);
            // 
            // workproduct
            // 
            this.workproduct.Font = new System.Drawing.Font("Siyam Rupali", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workproduct.Location = new System.Drawing.Point(148, 267);
            this.workproduct.Name = "workproduct";
            this.workproduct.Size = new System.Drawing.Size(461, 113);
            this.workproduct.TabIndex = 1;
            this.workproduct.Text = "Product Availability";
            this.workproduct.UseVisualStyleBackColor = true;
            this.workproduct.Click += new System.EventHandler(this.workproduct_Click);
            // 
            // worknoti
            // 
            this.worknoti.Font = new System.Drawing.Font("Siyam Rupali", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worknoti.Location = new System.Drawing.Point(148, 439);
            this.worknoti.Name = "worknoti";
            this.worknoti.Size = new System.Drawing.Size(461, 96);
            this.worknoti.TabIndex = 2;
            this.worknoti.Text = "Notifications";
            this.worknoti.UseVisualStyleBackColor = true;
            this.worknoti.Click += new System.EventHandler(this.worknoti_Click);
            // 
            // workback
            // 
            this.workback.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workback.Location = new System.Drawing.Point(887, 591);
            this.workback.Name = "workback";
            this.workback.Size = new System.Drawing.Size(102, 57);
            this.workback.TabIndex = 3;
            this.workback.Text = "Back";
            this.workback.UseVisualStyleBackColor = true;
            this.workback.Click += new System.EventHandler(this.workback_Click);
            // 
            // admwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.workback);
            this.Controls.Add(this.worknoti);
            this.Controls.Add(this.workproduct);
            this.Controls.Add(this.workreq);
            this.Name = "admwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admwork";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button workreq;
        private System.Windows.Forms.Button workproduct;
        private System.Windows.Forms.Button worknoti;
        private System.Windows.Forms.Button workback;
    }
}