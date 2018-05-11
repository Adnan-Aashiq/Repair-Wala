namespace WindowsFormsApp1
{
    partial class OnlineBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineBank));
            this.cmdpay = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtacountnmbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdpay
            // 
            this.cmdpay.BackColor = System.Drawing.Color.Honeydew;
            this.cmdpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdpay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdpay.Location = new System.Drawing.Point(142, 196);
            this.cmdpay.Name = "cmdpay";
            this.cmdpay.Size = new System.Drawing.Size(83, 27);
            this.cmdpay.TabIndex = 53;
            this.cmdpay.Text = "Pay";
            this.cmdpay.UseVisualStyleBackColor = false;
            this.cmdpay.Click += new System.EventHandler(this.cmdpay_Click);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtamount.Location = new System.Drawing.Point(57, 149);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(241, 26);
            this.txtamount.TabIndex = 52;
            this.txtamount.Text = "Enter Ammount";
            this.txtamount.Click += new System.EventHandler(this.txtamount_Click);
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // txtacountnmbr
            // 
            this.txtacountnmbr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtacountnmbr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtacountnmbr.Location = new System.Drawing.Point(57, 117);
            this.txtacountnmbr.Name = "txtacountnmbr";
            this.txtacountnmbr.Size = new System.Drawing.Size(241, 26);
            this.txtacountnmbr.TabIndex = 51;
            this.txtacountnmbr.Text = "Enter Account #";
            this.txtacountnmbr.Click += new System.EventHandler(this.txtacountnmbr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(128, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "   Online  Bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.money__2_;
            this.pictureBox1.Location = new System.Drawing.Point(158, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // OnlineBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdpay);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtacountnmbr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnlineBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineBank";
            this.Load += new System.EventHandler(this.OnlineBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdpay;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtacountnmbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}