namespace ProjectPP
{
    partial class AdminLog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.logwelcome = new System.Windows.Forms.Label();
            this.logadmin = new System.Windows.Forms.Label();
            this.logback = new System.Windows.Forms.Label();
            this.logusername = new System.Windows.Forms.Label();
            this.logtextBoxusername = new System.Windows.Forms.TextBox();
            this.logtextBoxpass = new System.Windows.Forms.TextBox();
            this.logpass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logacc = new System.Windows.Forms.Button();
            this.logforgot = new System.Windows.Forms.Button();
            this.logbackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logwelcome
            // 
            this.logwelcome.AutoSize = true;
            this.logwelcome.Font = new System.Drawing.Font("Siyam Rupali", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logwelcome.Location = new System.Drawing.Point(111, 145);
            this.logwelcome.Name = "logwelcome";
            this.logwelcome.Size = new System.Drawing.Size(234, 76);
            this.logwelcome.TabIndex = 0;
            this.logwelcome.Text = "Welcome";
            this.logwelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // logadmin
            // 
            this.logadmin.AutoSize = true;
            this.logadmin.Font = new System.Drawing.Font("Siyam Rupali", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logadmin.Location = new System.Drawing.Point(141, 407);
            this.logadmin.Name = "logadmin";
            this.logadmin.Size = new System.Drawing.Size(195, 76);
            this.logadmin.TabIndex = 1;
            this.logadmin.Text = "Admin!";
            // 
            // logback
            // 
            this.logback.AutoSize = true;
            this.logback.Font = new System.Drawing.Font("Siyam Rupali", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logback.Location = new System.Drawing.Point(240, 272);
            this.logback.Name = "logback";
            this.logback.Size = new System.Drawing.Size(135, 76);
            this.logback.TabIndex = 2;
            this.logback.Text = "Back";
            this.logback.Click += new System.EventHandler(this.label2_Click);
            // 
            // logusername
            // 
            this.logusername.AutoSize = true;
            this.logusername.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold);
            this.logusername.Location = new System.Drawing.Point(599, 71);
            this.logusername.Name = "logusername";
            this.logusername.Size = new System.Drawing.Size(182, 46);
            this.logusername.TabIndex = 3;
            this.logusername.Text = "User Name:";
            // 
            // logtextBoxusername
            // 
            this.logtextBoxusername.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold);
            this.logtextBoxusername.Location = new System.Drawing.Point(632, 145);
            this.logtextBoxusername.Name = "logtextBoxusername";
            this.logtextBoxusername.Size = new System.Drawing.Size(465, 46);
            this.logtextBoxusername.TabIndex = 4;
            // 
            // logtextBoxpass
            // 
            this.logtextBoxpass.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold);
            this.logtextBoxpass.Location = new System.Drawing.Point(632, 302);
            this.logtextBoxpass.Name = "logtextBoxpass";
            this.logtextBoxpass.PasswordChar = '*'; // mask password input
            this.logtextBoxpass.Size = new System.Drawing.Size(465, 46);
            this.logtextBoxpass.TabIndex = 6;
            // 
            // logpass
            // 
            this.logpass.AutoSize = true;
            this.logpass.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold);
            this.logpass.Location = new System.Drawing.Point(599, 229);
            this.logpass.Name = "logpass";
            this.logpass.Size = new System.Drawing.Size(159, 46);
            this.logpass.TabIndex = 5;
            this.logpass.Text = "Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(958, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logacc
            // 
            this.logacc.Font = new System.Drawing.Font("Siyam Rupali", 12F, System.Drawing.FontStyle.Bold);
            this.logacc.Location = new System.Drawing.Point(799, 578);
            this.logacc.Name = "logacc";
            this.logacc.Size = new System.Drawing.Size(285, 54);
            this.logacc.TabIndex = 8;
            this.logacc.Text = "Don't have an account";
            this.logacc.UseVisualStyleBackColor = true;
            this.logacc.Click += new System.EventHandler(this.button2_Click);
            // 
            // logforgot
            // 
            this.logforgot.Font = new System.Drawing.Font("Siyam Rupali", 12F, System.Drawing.FontStyle.Bold);
            this.logforgot.Location = new System.Drawing.Point(841, 488);
            this.logforgot.Name = "logforgot";
            this.logforgot.Size = new System.Drawing.Size(243, 54);
            this.logforgot.TabIndex = 9;
            this.logforgot.Text = "Forgot Password?";
            this.logforgot.UseVisualStyleBackColor = true;
            this.logforgot.Click += new System.EventHandler(this.button3_Click);
            // 
            // logbackbutton
            // 
            this.logbackbutton.Font = new System.Drawing.Font("Siyam Rupali", 10.2F, System.Drawing.FontStyle.Bold);
            this.logbackbutton.Location = new System.Drawing.Point(49, 626);
            this.logbackbutton.Name = "logbackbutton";
            this.logbackbutton.Size = new System.Drawing.Size(75, 41);
            this.logbackbutton.TabIndex = 10;
            this.logbackbutton.Text = "Back";
            this.logbackbutton.UseVisualStyleBackColor = true;
            this.logbackbutton.Click += new System.EventHandler(this.logbackbutton_Click);
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.logbackbutton);
            this.Controls.Add(this.logforgot);
            this.Controls.Add(this.logacc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logtextBoxpass);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.logtextBoxusername);
            this.Controls.Add(this.logusername);
            this.Controls.Add(this.logback);
            this.Controls.Add(this.logadmin);
            this.Controls.Add(this.logwelcome);
            this.Name = "AdminLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLog";
            this.Load += new System.EventHandler(this.AdminLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label logwelcome;
        private System.Windows.Forms.Label logadmin;
        private System.Windows.Forms.Label logback;
        private System.Windows.Forms.Label logusername;
        private System.Windows.Forms.TextBox logtextBoxusername;
        private System.Windows.Forms.TextBox logtextBoxpass;
        private System.Windows.Forms.Label logpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logacc;
        private System.Windows.Forms.Button logforgot;
        private System.Windows.Forms.Button logbackbutton;
    }
}
