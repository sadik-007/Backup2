namespace ProjectPP
{
    partial class NewPass
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
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.btnShowNewPassword = new System.Windows.Forms.Button();
            this.linkBackToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(348, 193);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(202, 38);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(355, 257);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(350, 38);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(348, 335);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(245, 38);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(355, 400);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 38);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Location = new System.Drawing.Point(346, 500);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(445, 75);
            this.btnUpdatePassword.TabIndex = 7;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(382, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Set New Password";
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowConfirmPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirmPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(711, 400);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(44, 38);
            this.btnShowConfirmPassword.TabIndex = 6;
            this.btnShowConfirmPassword.Text = "👀";
            this.btnShowConfirmPassword.UseVisualStyleBackColor = false;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.togglePasswordVisibility_Click);
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNewPassword.Location = new System.Drawing.Point(711, 257);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(44, 38);
            this.btnShowNewPassword.TabIndex = 3;
            this.btnShowNewPassword.Text = "👀";
            this.btnShowNewPassword.UseVisualStyleBackColor = false;
            this.btnShowNewPassword.Click += new System.EventHandler(this.togglePasswordVisibility_Click);
            // 
            // linkBackToLogin
            // 
            this.linkBackToLogin.AutoSize = true;
            this.linkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.linkBackToLogin.LinkColor = System.Drawing.Color.Gray;
            this.linkBackToLogin.Location = new System.Drawing.Point(485, 595);
            this.linkBackToLogin.Name = "linkBackToLogin";
            this.linkBackToLogin.Size = new System.Drawing.Size(155, 23);
            this.linkBackToLogin.TabIndex = 8;
            this.linkBackToLogin.TabStop = true;
            this.linkBackToLogin.Text = "Back to Login Page";
            this.linkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToLogin_LinkClicked);
            // 
            // NewPass
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.linkBackToLogin);
            this.Controls.Add(this.btnShowNewPassword);
            this.Controls.Add(this.btnShowConfirmPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblTitle);
            this.Name = "NewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set New Password";
            this.Load += new System.EventHandler(this.NewPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnShowConfirmPassword;
        private System.Windows.Forms.Button btnShowNewPassword;
        private System.Windows.Forms.LinkLabel linkBackToLogin;
    }
}