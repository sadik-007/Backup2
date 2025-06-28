namespace ProjectPP
{
    partial class admnewpass
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.newtextBoxconfirmpass = new System.Windows.Forms.TextBox();
            this.newconfirmpass = new System.Windows.Forms.Label();
            this.newtextBoxnewpass = new System.Windows.Forms.TextBox();
            this.newnewpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(726, 490);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(166, 57);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(354, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 57);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // newtextBoxconfirmpass
            // 
            this.newtextBoxconfirmpass.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtextBoxconfirmpass.Location = new System.Drawing.Point(442, 318);
            this.newtextBoxconfirmpass.Name = "newtextBoxconfirmpass";
            this.newtextBoxconfirmpass.Size = new System.Drawing.Size(529, 46);
            this.newtextBoxconfirmpass.TabIndex = 15;
            this.newtextBoxconfirmpass.UseSystemPasswordChar = true;
            // 
            // newconfirmpass
            // 
            this.newconfirmpass.AutoSize = true;
            this.newconfirmpass.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newconfirmpass.Location = new System.Drawing.Point(129, 316);
            this.newconfirmpass.Name = "newconfirmpass";
            this.newconfirmpass.Size = new System.Drawing.Size(267, 46);
            this.newconfirmpass.TabIndex = 14;
            this.newconfirmpass.Text = "ConfirmPassword:";
            // 
            // newtextBoxnewpass
            // 
            this.newtextBoxnewpass.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtextBoxnewpass.Location = new System.Drawing.Point(446, 242);
            this.newtextBoxnewpass.Name = "newtextBoxnewpass";
            this.newtextBoxnewpass.Size = new System.Drawing.Size(529, 46);
            this.newtextBoxnewpass.TabIndex = 13;
            this.newtextBoxnewpass.UseSystemPasswordChar = true;
            this.newtextBoxnewpass.TextChanged += new System.EventHandler(this.resettextBoxusername_TextChanged);
            // 
            // newnewpass
            // 
            this.newnewpass.AutoSize = true;
            this.newnewpass.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnewpass.Location = new System.Drawing.Point(167, 240);
            this.newnewpass.Name = "newnewpass";
            this.newnewpass.Size = new System.Drawing.Size(229, 46);
            this.newnewpass.TabIndex = 12;
            this.newnewpass.Text = "New Password:";
            // 
            // admnewpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.newtextBoxconfirmpass);
            this.Controls.Add(this.newconfirmpass);
            this.Controls.Add(this.newtextBoxnewpass);
            this.Controls.Add(this.newnewpass);
            this.Controls.Add(this.label1);
            this.Name = "admnewpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admnewpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox newtextBoxconfirmpass;
        private System.Windows.Forms.Label newconfirmpass;
        private System.Windows.Forms.TextBox newtextBoxnewpass;
        private System.Windows.Forms.Label newnewpass;
    }
}