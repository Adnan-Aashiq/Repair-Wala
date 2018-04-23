namespace WindowsFormsApp1
{
    partial class frmguest_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmguest_user));
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtcdevice = new System.Windows.Forms.TextBox();
            this.txtccell = new System.Windows.Forms.TextBox();
            this.txtcproblem = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtcmail = new System.Windows.Forms.TextBox();
            this.cmdcreg = new System.Windows.Forms.Button();
            this.cmdclogin = new System.Windows.Forms.Button();
            this.cmdhome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdrepair = new System.Windows.Forms.Button();
            this.lblidtext = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.cmdreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcname
            // 
            this.txtcname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcname.Location = new System.Drawing.Point(82, 83);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(180, 26);
            this.txtcname.TabIndex = 0;
            this.txtcname.Text = "Enter Name";
            this.txtcname.Click += new System.EventHandler(this.txtcname_Click);
            this.txtcname.TextChanged += new System.EventHandler(this.txtcname_TextChanged);
            this.txtcname.Enter += new System.EventHandler(this.txtcname_Enter);
            // 
            // txtcdevice
            // 
            this.txtcdevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcdevice.Location = new System.Drawing.Point(82, 172);
            this.txtcdevice.Name = "txtcdevice";
            this.txtcdevice.Size = new System.Drawing.Size(180, 26);
            this.txtcdevice.TabIndex = 4;
            this.txtcdevice.Text = "Enter Device";
            this.txtcdevice.Click += new System.EventHandler(this.txtcdevice_Click);
            // 
            // txtccell
            // 
            this.txtccell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtccell.Location = new System.Drawing.Point(82, 127);
            this.txtccell.Name = "txtccell";
            this.txtccell.Size = new System.Drawing.Size(180, 26);
            this.txtccell.TabIndex = 6;
            this.txtccell.Text = "Enter Phone#";
            this.txtccell.Click += new System.EventHandler(this.txtccell_Click);
            // 
            // txtcproblem
            // 
            this.txtcproblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcproblem.Location = new System.Drawing.Point(82, 217);
            this.txtcproblem.Name = "txtcproblem";
            this.txtcproblem.Size = new System.Drawing.Size(180, 26);
            this.txtcproblem.TabIndex = 8;
            this.txtcproblem.Text = "Enter Problem";
            this.txtcproblem.Click += new System.EventHandler(this.txtcproblem_Click);
            this.txtcproblem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtcaddress
            // 
            this.txtcaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcaddress.Location = new System.Drawing.Point(82, 263);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(180, 26);
            this.txtcaddress.TabIndex = 10;
            this.txtcaddress.Text = "Enter Address";
            this.txtcaddress.Click += new System.EventHandler(this.txtcaddress_Click);
            // 
            // txtcmail
            // 
            this.txtcmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcmail.Location = new System.Drawing.Point(82, 308);
            this.txtcmail.Name = "txtcmail";
            this.txtcmail.Size = new System.Drawing.Size(180, 26);
            this.txtcmail.TabIndex = 12;
            this.txtcmail.Text = "Enter E Mail";
            this.txtcmail.Click += new System.EventHandler(this.txtcmail_Click);
            // 
            // cmdcreg
            // 
            this.cmdcreg.BackColor = System.Drawing.Color.Honeydew;
            this.cmdcreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdcreg.Location = new System.Drawing.Point(306, 273);
            this.cmdcreg.Name = "cmdcreg";
            this.cmdcreg.Size = new System.Drawing.Size(158, 29);
            this.cmdcreg.TabIndex = 14;
            this.cmdcreg.Text = "Register";
            this.cmdcreg.UseVisualStyleBackColor = false;
            this.cmdcreg.Click += new System.EventHandler(this.cmdcreg_Click);
            // 
            // cmdclogin
            // 
            this.cmdclogin.BackColor = System.Drawing.Color.Honeydew;
            this.cmdclogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdclogin.Location = new System.Drawing.Point(306, 343);
            this.cmdclogin.Name = "cmdclogin";
            this.cmdclogin.Size = new System.Drawing.Size(158, 27);
            this.cmdclogin.TabIndex = 15;
            this.cmdclogin.Text = "Login";
            this.cmdclogin.UseVisualStyleBackColor = false;
            this.cmdclogin.Click += new System.EventHandler(this.cmdclogin_Click);
            // 
            // cmdhome
            // 
            this.cmdhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdhome.Location = new System.Drawing.Point(0, 1);
            this.cmdhome.Margin = new System.Windows.Forms.Padding(0);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(200, 44);
            this.cmdhome.TabIndex = 23;
            this.cmdhome.Text = "Home";
            this.cmdhome.UseVisualStyleBackColor = false;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(200, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Customer Portal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(400, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Guest User";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cmdrepair
            // 
            this.cmdrepair.BackColor = System.Drawing.Color.Honeydew;
            this.cmdrepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdrepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdrepair.Location = new System.Drawing.Point(504, 341);
            this.cmdrepair.Name = "cmdrepair";
            this.cmdrepair.Size = new System.Drawing.Size(158, 29);
            this.cmdrepair.TabIndex = 27;
            this.cmdrepair.Text = "Repair";
            this.cmdrepair.UseVisualStyleBackColor = false;
            this.cmdrepair.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblidtext
            // 
            this.lblidtext.AutoSize = true;
            this.lblidtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidtext.Location = new System.Drawing.Point(78, 352);
            this.lblidtext.Name = "lblidtext";
            this.lblidtext.Size = new System.Drawing.Size(108, 19);
            this.lblidtext.TabIndex = 28;
            this.lblidtext.Text = "Your Login Id :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(196, 352);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 19);
            this.lblid.TabIndex = 29;
            this.lblid.Text = "Id";
            // 
            // cmdreset
            // 
            this.cmdreset.BackColor = System.Drawing.Color.Honeydew;
            this.cmdreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdreset.Location = new System.Drawing.Point(306, 308);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(158, 29);
            this.cmdreset.TabIndex = 30;
            this.cmdreset.Text = "Reset";
            this.cmdreset.UseVisualStyleBackColor = false;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click_1);
            // 
            // frmguest_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.cmdreset);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblidtext);
            this.Controls.Add(this.cmdrepair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdhome);
            this.Controls.Add(this.txtcmail);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(this.txtcproblem);
            this.Controls.Add(this.txtccell);
            this.Controls.Add(this.txtcdevice);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.cmdclogin);
            this.Controls.Add(this.cmdcreg);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmguest_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmcustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtcdevice;
        private System.Windows.Forms.TextBox txtccell;
        private System.Windows.Forms.TextBox txtcproblem;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtcmail;
        private System.Windows.Forms.Button cmdcreg;
        private System.Windows.Forms.Button cmdclogin;
        private System.Windows.Forms.Button cmdhome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdrepair;
        private System.Windows.Forms.Label lblidtext;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button cmdreset;
    }
}

