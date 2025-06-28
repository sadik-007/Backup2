namespace ProjectPP
{
    partial class admresetpass
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
            this.label1 = new System.Windows.Forms.Label();
            this.resetusername = new System.Windows.Forms.Label();
            this.resettextBoxusername = new System.Windows.Forms.TextBox();
            this.resettextBoxgmail = new System.Windows.Forms.TextBox();
            this.resetgmail = new System.Windows.Forms.Label();
            this.resetback = new System.Windows.Forms.Button();
            this.resetchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // resetusername
            // 
            this.resetusername.AutoSize = true;
            this.resetusername.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetusername.Location = new System.Drawing.Point(237, 245);
            this.resetusername.Name = "resetusername";
            this.resetusername.Size = new System.Drawing.Size(182, 46);
            this.resetusername.TabIndex = 1;
            this.resetusername.Text = "User Name:";
            // 
            // resettextBoxusername
            // 
            this.resettextBoxusername.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resettextBoxusername.Location = new System.Drawing.Point(444, 247);
            this.resettextBoxusername.Name = "resettextBoxusername";
            this.resettextBoxusername.Size = new System.Drawing.Size(529, 46);
            this.resettextBoxusername.TabIndex = 2;
            this.resettextBoxusername.TextChanged += new System.EventHandler(this.resettextBoxusername_TextChanged);
            // 
            // resettextBoxgmail
            // 
            this.resettextBoxgmail.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resettextBoxgmail.Location = new System.Drawing.Point(440, 323);
            this.resettextBoxgmail.Name = "resettextBoxgmail";
            this.resettextBoxgmail.Size = new System.Drawing.Size(529, 46);
            this.resettextBoxgmail.TabIndex = 8;
            // 
            // resetgmail
            // 
            this.resetgmail.AutoSize = true;
            this.resetgmail.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetgmail.Location = new System.Drawing.Point(237, 323);
            this.resetgmail.Name = "resetgmail";
            this.resetgmail.Size = new System.Drawing.Size(109, 46);
            this.resetgmail.TabIndex = 7;
            this.resetgmail.Text = "Gmail:";
            // 
            // resetback
            // 
            this.resetback.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetback.Location = new System.Drawing.Point(352, 495);
            this.resetback.Name = "resetback";
            this.resetback.Size = new System.Drawing.Size(116, 57);
            this.resetback.TabIndex = 10;
            this.resetback.Text = "Back";
            this.resetback.UseVisualStyleBackColor = true;
            this.resetback.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetchange
            // 
            this.resetchange.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetchange.Location = new System.Drawing.Point(724, 495);
            this.resetchange.Name = "resetchange";
            this.resetchange.Size = new System.Drawing.Size(189, 57);
            this.resetchange.TabIndex = 11;
            this.resetchange.Text = "Proceed";
            this.resetchange.UseVisualStyleBackColor = true;
            this.resetchange.Click += new System.EventHandler(this.resetchange_Click);
            // 
            // admresetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.resetchange);
            this.Controls.Add(this.resetback);
            this.Controls.Add(this.resettextBoxgmail);
            this.Controls.Add(this.resetgmail);
            this.Controls.Add(this.resettextBoxusername);
            this.Controls.Add(this.resetusername);
            this.Controls.Add(this.label1);
            this.Name = "admresetpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admresetpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resetusername;
        private System.Windows.Forms.TextBox resettextBoxusername;
        private System.Windows.Forms.TextBox resettextBoxgmail;
        private System.Windows.Forms.Label resetgmail;
        private System.Windows.Forms.Button resetback;
        private System.Windows.Forms.Button resetchange;
    }
}