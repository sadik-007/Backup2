namespace ProjectPP
{
    partial class admreg
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
            this.regacc = new System.Windows.Forms.Label();
            this.accusername = new System.Windows.Forms.Label();
            this.acctextBoxusername = new System.Windows.Forms.TextBox();
            this.acctextBoxgmail = new System.Windows.Forms.TextBox();
            this.accgmail = new System.Windows.Forms.Label();
            this.acctextBoxpass = new System.Windows.Forms.TextBox();
            this.accpass = new System.Windows.Forms.Label();
            this.accdob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.accback = new System.Windows.Forms.Button();
            this.accapply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regacc
            // 
            this.regacc.AutoSize = true;
            this.regacc.Font = new System.Drawing.Font("Siyam Rupali", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regacc.Location = new System.Drawing.Point(364, 42);
            this.regacc.Name = "regacc";
            this.regacc.Size = new System.Drawing.Size(490, 71);
            this.regacc.TabIndex = 0;
            this.regacc.Text = "Create a new account";
            // 
            // accusername
            // 
            this.accusername.AutoSize = true;
            this.accusername.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accusername.Location = new System.Drawing.Point(178, 166);
            this.accusername.Name = "accusername";
            this.accusername.Size = new System.Drawing.Size(182, 46);
            this.accusername.TabIndex = 1;
            this.accusername.Text = "User Name:";
            // 
            // acctextBoxusername
            // 
            this.acctextBoxusername.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctextBoxusername.Location = new System.Drawing.Point(376, 168);
            this.acctextBoxusername.Name = "acctextBoxusername";
            this.acctextBoxusername.Size = new System.Drawing.Size(549, 46);
            this.acctextBoxusername.TabIndex = 2;
            // 
            // acctextBoxgmail
            // 
            this.acctextBoxgmail.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctextBoxgmail.Location = new System.Drawing.Point(376, 263);
            this.acctextBoxgmail.Name = "acctextBoxgmail";
            this.acctextBoxgmail.Size = new System.Drawing.Size(549, 46);
            this.acctextBoxgmail.TabIndex = 4;
            this.acctextBoxgmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // accgmail
            // 
            this.accgmail.AutoSize = true;
            this.accgmail.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accgmail.Location = new System.Drawing.Point(251, 261);
            this.accgmail.Name = "accgmail";
            this.accgmail.Size = new System.Drawing.Size(109, 46);
            this.accgmail.TabIndex = 3;
            this.accgmail.Text = "Gmail:";
            // 
            // acctextBoxpass
            // 
            this.acctextBoxpass.Font = new System.Drawing.Font("Siyam Rupali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctextBoxpass.Location = new System.Drawing.Point(376, 451);
            this.acctextBoxpass.Name = "acctextBoxpass";
            this.acctextBoxpass.Size = new System.Drawing.Size(549, 46);
            this.acctextBoxpass.TabIndex = 6;
            // 
            // accpass
            // 
            this.accpass.AutoSize = true;
            this.accpass.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accpass.Location = new System.Drawing.Point(201, 451);
            this.accpass.Name = "accpass";
            this.accpass.Size = new System.Drawing.Size(159, 46);
            this.accpass.TabIndex = 5;
            this.accpass.Text = "Password:";
            // 
            // accdob
            // 
            this.accdob.AutoSize = true;
            this.accdob.Font = new System.Drawing.Font("Siyam Rupali", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accdob.Location = new System.Drawing.Point(151, 356);
            this.accdob.Name = "accdob";
            this.accdob.Size = new System.Drawing.Size(209, 46);
            this.accdob.TabIndex = 7;
            this.accdob.Text = "Date of Birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(549, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // accback
            // 
            this.accback.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accback.Location = new System.Drawing.Point(319, 577);
            this.accback.Name = "accback";
            this.accback.Size = new System.Drawing.Size(112, 58);
            this.accback.TabIndex = 9;
            this.accback.Text = "Back";
            this.accback.UseVisualStyleBackColor = true;
            this.accback.Click += new System.EventHandler(this.accback_Click);
            // 
            // accapply
            // 
            this.accapply.Font = new System.Drawing.Font("Siyam Rupali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accapply.Location = new System.Drawing.Point(791, 577);
            this.accapply.Name = "accapply";
            this.accapply.Size = new System.Drawing.Size(134, 58);
            this.accapply.TabIndex = 10;
            this.accapply.Text = "Apply";
            this.accapply.UseVisualStyleBackColor = true;
            this.accapply.Click += new System.EventHandler(this.accapply_Click);
            // 
            // admreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.accapply);
            this.Controls.Add(this.accback);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.accdob);
            this.Controls.Add(this.acctextBoxpass);
            this.Controls.Add(this.accpass);
            this.Controls.Add(this.acctextBoxgmail);
            this.Controls.Add(this.accgmail);
            this.Controls.Add(this.acctextBoxusername);
            this.Controls.Add(this.accusername);
            this.Controls.Add(this.regacc);
            this.Name = "admreg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admreg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regacc;
        private System.Windows.Forms.Label accusername;
        private System.Windows.Forms.TextBox acctextBoxusername;
        private System.Windows.Forms.TextBox acctextBoxgmail;
        private System.Windows.Forms.Label accgmail;
        private System.Windows.Forms.TextBox acctextBoxpass;
        private System.Windows.Forms.Label accpass;
        private System.Windows.Forms.Label accdob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button accback;
        private System.Windows.Forms.Button accapply;
    }
}