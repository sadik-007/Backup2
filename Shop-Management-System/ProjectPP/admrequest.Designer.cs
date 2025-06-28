namespace ProjectPP
{
    partial class admrequest
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
            this.reqrequest = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reqback = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reqrequest
            // 
            this.reqrequest.AutoSize = true;
            this.reqrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqrequest.Location = new System.Drawing.Point(22, 30);
            this.reqrequest.Name = "reqrequest";
            this.reqrequest.Size = new System.Drawing.Size(190, 32);
            this.reqrequest.TabIndex = 0;
            this.reqrequest.Text = "Account List:";
            this.reqrequest.Click += new System.EventHandler(this.reqrequest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // reqback
            // 
            this.reqback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqback.Location = new System.Drawing.Point(51, 649);
            this.reqback.Name = "reqback";
            this.reqback.Size = new System.Drawing.Size(82, 42);
            this.reqback.TabIndex = 2;
            this.reqback.Text = "Back";
            this.reqback.UseVisualStyleBackColor = true;
            this.reqback.Click += new System.EventHandler(this.reqback_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // admrequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reqback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reqrequest);
            this.Name = "admrequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admrequest";
            this.Load += new System.EventHandler(this.admrequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqrequest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reqback;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}