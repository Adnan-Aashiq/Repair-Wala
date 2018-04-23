namespace WindowsFormsApp1
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.cmdcustomer = new System.Windows.Forms.Button();
            this.cmdrepairer = new System.Windows.Forms.Button();
            this.cmdadmin = new System.Windows.Forms.Button();
            this.txtrepair = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.cmdhome = new System.Windows.Forms.Button();
            this.cmdrepairid = new System.Windows.Forms.Button();
            this.cmdadminId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdcustomer
            // 
            this.cmdcustomer.BackColor = System.Drawing.Color.Honeydew;
            this.cmdcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcustomer.Location = new System.Drawing.Point(-5, 46);
            this.cmdcustomer.Name = "cmdcustomer";
            this.cmdcustomer.Size = new System.Drawing.Size(174, 47);
            this.cmdcustomer.TabIndex = 0;
            this.cmdcustomer.Text = "Customer Portal";
            this.cmdcustomer.UseVisualStyleBackColor = false;
            this.cmdcustomer.Click += new System.EventHandler(this.cmdcustomer_Click);
            // 
            // cmdrepairer
            // 
            this.cmdrepairer.BackColor = System.Drawing.Color.Honeydew;
            this.cmdrepairer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdrepairer.Location = new System.Drawing.Point(175, 46);
            this.cmdrepairer.Name = "cmdrepairer";
            this.cmdrepairer.Size = new System.Drawing.Size(174, 47);
            this.cmdrepairer.TabIndex = 3;
            this.cmdrepairer.Text = "Repairer Portal";
            this.cmdrepairer.UseVisualStyleBackColor = false;
            this.cmdrepairer.Click += new System.EventHandler(this.cmdrepairer_Click);
            // 
            // cmdadmin
            // 
            this.cmdadmin.BackColor = System.Drawing.Color.Honeydew;
            this.cmdadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdadmin.Location = new System.Drawing.Point(355, 46);
            this.cmdadmin.Name = "cmdadmin";
            this.cmdadmin.Size = new System.Drawing.Size(174, 47);
            this.cmdadmin.TabIndex = 4;
            this.cmdadmin.Text = "Admin Portal";
            this.cmdadmin.UseVisualStyleBackColor = false;
            this.cmdadmin.Click += new System.EventHandler(this.cmdadmin_Click);
            // 
            // txtrepair
            // 
            this.txtrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepair.ForeColor = System.Drawing.Color.Gray;
            this.txtrepair.Location = new System.Drawing.Point(238, 260);
            this.txtrepair.Name = "txtrepair";
            this.txtrepair.Size = new System.Drawing.Size(166, 21);
            this.txtrepair.TabIndex = 1;
            this.txtrepair.Text = "Enter Passcode!";
            this.txtrepair.Click += new System.EventHandler(this.txtpasscode_Click);
            this.txtrepair.TextChanged += new System.EventHandler(this.txtpasscode_TextChanged);
            this.txtrepair.Enter += new System.EventHandler(this.txtpasscode_Enter);
            this.txtrepair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpasscode_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-5, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtadmin
            // 
            this.txtadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmin.ForeColor = System.Drawing.Color.Gray;
            this.txtadmin.Location = new System.Drawing.Point(238, 332);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(166, 21);
            this.txtadmin.TabIndex = 6;
            this.txtadmin.Text = "Enter Passcode";
            this.txtadmin.Click += new System.EventHandler(this.txtpassadmin_Click);
            this.txtadmin.TextChanged += new System.EventHandler(this.txtpassadmin_TextChanged);
            this.txtadmin.Enter += new System.EventHandler(this.txtpassadmin_Enter);
            // 
            // cmdhome
            // 
            this.cmdhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdhome.Location = new System.Drawing.Point(-5, -1);
            this.cmdhome.Margin = new System.Windows.Forms.Padding(0);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(200, 44);
            this.cmdhome.TabIndex = 26;
            this.cmdhome.Text = "Home";
            this.cmdhome.UseVisualStyleBackColor = false;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // cmdrepairid
            // 
            this.cmdrepairid.BackColor = System.Drawing.Color.Honeydew;
            this.cmdrepairid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdrepairid.Location = new System.Drawing.Point(469, 250);
            this.cmdrepairid.Name = "cmdrepairid";
            this.cmdrepairid.Size = new System.Drawing.Size(174, 31);
            this.cmdrepairid.TabIndex = 27;
            this.cmdrepairid.Text = "Login";
            this.cmdrepairid.UseVisualStyleBackColor = false;
            this.cmdrepairid.Click += new System.EventHandler(this.cmdproceed_Click);
            // 
            // cmdadminId
            // 
            this.cmdadminId.BackColor = System.Drawing.Color.Honeydew;
            this.cmdadminId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdadminId.Location = new System.Drawing.Point(451, 322);
            this.cmdadminId.Name = "cmdadminId";
            this.cmdadminId.Size = new System.Drawing.Size(174, 31);
            this.cmdadminId.TabIndex = 28;
            this.cmdadminId.Text = "Login";
            this.cmdadminId.UseVisualStyleBackColor = false;
            this.cmdadminId.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.cmdadminId);
            this.Controls.Add(this.cmdadmin);
            this.Controls.Add(this.cmdrepairer);
            this.Controls.Add(this.cmdcustomer);
            this.Controls.Add(this.cmdrepairid);
            this.Controls.Add(this.cmdhome);
            this.Controls.Add(this.txtadmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrepair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmhome";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdcustomer;
        private System.Windows.Forms.Button cmdrepairer;
        private System.Windows.Forms.Button cmdadmin;
        private System.Windows.Forms.TextBox txtrepair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Button cmdhome;
        private System.Windows.Forms.Button cmdrepairid;
        private System.Windows.Forms.Button cmdadminId;
    }
}