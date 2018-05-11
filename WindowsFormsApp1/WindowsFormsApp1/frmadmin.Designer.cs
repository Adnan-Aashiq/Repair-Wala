namespace WindowsFormsApp1
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmdcreg = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdreset = new System.Windows.Forms.Button();
            this.txtrid = new System.Windows.Forms.TextBox();
            this.txtrcnic = new System.Windows.Forms.TextBox();
            this.txtraddress = new System.Windows.Forms.TextBox();
            this.txtrcell = new System.Windows.Forms.TextBox();
            this.txtrname = new System.Windows.Forms.TextBox();
            this.txtrexist = new System.Windows.Forms.TextBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbladminname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdhome
            // 
            this.cmdhome.BackColor = System.Drawing.Color.Silver;
            this.cmdhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdhome.Location = new System.Drawing.Point(0, 0);
            this.cmdhome.Margin = new System.Windows.Forms.Padding(0);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(200, 44);
            this.cmdhome.TabIndex = 25;
            this.cmdhome.Text = "Home";
            this.cmdhome.UseVisualStyleBackColor = false;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // cmdcreg
            // 
            this.cmdcreg.BackColor = System.Drawing.Color.Honeydew;
            this.cmdcreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdcreg.Location = new System.Drawing.Point(137, 317);
            this.cmdcreg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdcreg.Name = "cmdcreg";
            this.cmdcreg.Size = new System.Drawing.Size(126, 30);
            this.cmdcreg.TabIndex = 27;
            this.cmdcreg.Text = "Register";
            this.cmdcreg.UseVisualStyleBackColor = false;
            this.cmdcreg.Click += new System.EventHandler(this.cmdcreg_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Issue Warning",
            "Check Account",
            "Delete Account"});
            this.comboBox1.Location = new System.Drawing.Point(619, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(200, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Admin Portal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmdreset
            // 
            this.cmdreset.BackColor = System.Drawing.Color.Honeydew;
            this.cmdreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdreset.Location = new System.Drawing.Point(137, 353);
            this.cmdreset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(126, 30);
            this.cmdreset.TabIndex = 37;
            this.cmdreset.Text = "Reset";
            this.cmdreset.UseVisualStyleBackColor = false;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
            // 
            // txtrid
            // 
            this.txtrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrid.Location = new System.Drawing.Point(137, 247);
            this.txtrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrid.Name = "txtrid";
            this.txtrid.Size = new System.Drawing.Size(155, 26);
            this.txtrid.TabIndex = 42;
            this.txtrid.Text = "Issue Id";
            this.txtrid.Click += new System.EventHandler(this.txtrid_Click);
            this.txtrid.TextChanged += new System.EventHandler(this.txtrid_TextChanged);
            // 
            // txtrcnic
            // 
            this.txtrcnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrcnic.Location = new System.Drawing.Point(137, 183);
            this.txtrcnic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrcnic.Name = "txtrcnic";
            this.txtrcnic.Size = new System.Drawing.Size(155, 26);
            this.txtrcnic.TabIndex = 41;
            this.txtrcnic.Text = "Enter Repairers Id";
            this.txtrcnic.Click += new System.EventHandler(this.txtrcnic_Click);
            this.txtrcnic.TextChanged += new System.EventHandler(this.txtrcnic_TextChanged);
            // 
            // txtraddress
            // 
            this.txtraddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtraddress.Location = new System.Drawing.Point(137, 215);
            this.txtraddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtraddress.Name = "txtraddress";
            this.txtraddress.Size = new System.Drawing.Size(155, 26);
            this.txtraddress.TabIndex = 40;
            this.txtraddress.Text = "Enter Address";
            this.txtraddress.Click += new System.EventHandler(this.txtraddress_Click);
            this.txtraddress.TextChanged += new System.EventHandler(this.txtraddress_TextChanged);
            // 
            // txtrcell
            // 
            this.txtrcell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrcell.Location = new System.Drawing.Point(137, 151);
            this.txtrcell.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrcell.Name = "txtrcell";
            this.txtrcell.Size = new System.Drawing.Size(155, 26);
            this.txtrcell.TabIndex = 39;
            this.txtrcell.Text = "Enter Repairer Cell#";
            this.txtrcell.Click += new System.EventHandler(this.txtrcell_Click);
            this.txtrcell.TextChanged += new System.EventHandler(this.txtrcell_TextChanged);
            // 
            // txtrname
            // 
            this.txtrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrname.Location = new System.Drawing.Point(137, 119);
            this.txtrname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrname.Name = "txtrname";
            this.txtrname.Size = new System.Drawing.Size(155, 26);
            this.txtrname.TabIndex = 38;
            this.txtrname.Text = "Enter Repairers Name";
            this.txtrname.Click += new System.EventHandler(this.txtrname_Click);
            this.txtrname.TextChanged += new System.EventHandler(this.txtrname_TextChanged);
            // 
            // txtrexist
            // 
            this.txtrexist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrexist.Location = new System.Drawing.Point(414, 133);
            this.txtrexist.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrexist.Name = "txtrexist";
            this.txtrexist.Size = new System.Drawing.Size(200, 26);
            this.txtrexist.TabIndex = 43;
            this.txtrexist.Text = "Enter Id of Existing Repairer";
            this.txtrexist.Click += new System.EventHandler(this.txtrexist_Click);
            this.txtrexist.TextChanged += new System.EventHandler(this.txtrexist_TextChanged);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblwelcome.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(481, 25);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(117, 34);
            this.lblwelcome.TabIndex = 44;
            this.lblwelcome.Text = "Welcome";
            // 
            // lbladminname
            // 
            this.lbladminname.AutoSize = true;
            this.lbladminname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladminname.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminname.Location = new System.Drawing.Point(593, 25);
            this.lbladminname.Name = "lbladminname";
            this.lbladminname.Size = new System.Drawing.Size(117, 34);
            this.lbladminname.TabIndex = 45;
            this.lbladminname.Text = "Welcome";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(757, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 27);
            this.button2.TabIndex = 46;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbladminname);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.txtrexist);
            this.Controls.Add(this.txtrid);
            this.Controls.Add(this.txtrcnic);
            this.Controls.Add(this.txtraddress);
            this.Controls.Add(this.txtrcell);
            this.Controls.Add(this.txtrname);
            this.Controls.Add(this.cmdreset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdcreg);
            this.Controls.Add(this.cmdhome);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdhome;
        private System.Windows.Forms.Button cmdcreg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdreset;
        private System.Windows.Forms.TextBox txtrid;
        private System.Windows.Forms.TextBox txtrcnic;
        private System.Windows.Forms.TextBox txtraddress;
        private System.Windows.Forms.TextBox txtrcell;
        private System.Windows.Forms.TextBox txtrname;
        private System.Windows.Forms.TextBox txtrexist;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbladminname;
        private System.Windows.Forms.Button button2;
    }
}