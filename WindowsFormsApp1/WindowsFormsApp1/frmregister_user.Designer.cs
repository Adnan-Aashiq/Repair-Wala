namespace WindowsFormsApp1
{
    partial class frmregister_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregister_user));
            this.txtcmail = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtcproblem = new System.Windows.Forms.TextBox();
            this.txtccell = new System.Windows.Forms.TextBox();
            this.txtcdevice = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.cmdclogin = new System.Windows.Forms.Button();
            this.cmdfeedback = new System.Windows.Forms.Button();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.cmdrepair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdhome = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcmail
            // 
            this.txtcmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcmail.Location = new System.Drawing.Point(107, 346);
            this.txtcmail.Name = "txtcmail";
            this.txtcmail.Size = new System.Drawing.Size(180, 26);
            this.txtcmail.TabIndex = 31;
            this.txtcmail.Text = "Enter E Mail";
            // 
            // txtcaddress
            // 
            this.txtcaddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcaddress.Location = new System.Drawing.Point(107, 301);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(180, 26);
            this.txtcaddress.TabIndex = 30;
            this.txtcaddress.Text = "Enter Address";
            // 
            // txtcproblem
            // 
            this.txtcproblem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcproblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcproblem.Location = new System.Drawing.Point(107, 255);
            this.txtcproblem.Name = "txtcproblem";
            this.txtcproblem.Size = new System.Drawing.Size(180, 26);
            this.txtcproblem.TabIndex = 29;
            this.txtcproblem.Text = "Enter Problem";
            this.txtcproblem.Click += new System.EventHandler(this.txtcproblem_Click);
            this.txtcproblem.TextChanged += new System.EventHandler(this.txtcproblem_TextChanged);
            // 
            // txtccell
            // 
            this.txtccell.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtccell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtccell.Location = new System.Drawing.Point(107, 165);
            this.txtccell.Name = "txtccell";
            this.txtccell.Size = new System.Drawing.Size(180, 26);
            this.txtccell.TabIndex = 28;
            this.txtccell.Text = "Enter Phone#";
            // 
            // txtcdevice
            // 
            this.txtcdevice.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcdevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcdevice.Location = new System.Drawing.Point(107, 210);
            this.txtcdevice.Name = "txtcdevice";
            this.txtcdevice.Size = new System.Drawing.Size(180, 26);
            this.txtcdevice.TabIndex = 27;
            this.txtcdevice.Text = "Enter Device";
            this.txtcdevice.Click += new System.EventHandler(this.txtcdevice_Click);
            this.txtcdevice.TextChanged += new System.EventHandler(this.txtcdevice_TextChanged);
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcname.Location = new System.Drawing.Point(107, 121);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(180, 26);
            this.txtcname.TabIndex = 25;
            this.txtcname.Text = "Enter Name";
            // 
            // cmdclogin
            // 
            this.cmdclogin.BackColor = System.Drawing.Color.Honeydew;
            this.cmdclogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdclogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdclogin.Location = new System.Drawing.Point(335, 301);
            this.cmdclogin.Name = "cmdclogin";
            this.cmdclogin.Size = new System.Drawing.Size(158, 27);
            this.cmdclogin.TabIndex = 33;
            this.cmdclogin.Text = "Login";
            this.cmdclogin.UseVisualStyleBackColor = false;
            this.cmdclogin.Click += new System.EventHandler(this.cmdclogin_Click);
            // 
            // cmdfeedback
            // 
            this.cmdfeedback.BackColor = System.Drawing.Color.Honeydew;
            this.cmdfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdfeedback.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdfeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdfeedback.Location = new System.Drawing.Point(531, 344);
            this.cmdfeedback.Name = "cmdfeedback";
            this.cmdfeedback.Size = new System.Drawing.Size(158, 27);
            this.cmdfeedback.TabIndex = 42;
            this.cmdfeedback.Text = "Feedback";
            this.cmdfeedback.UseVisualStyleBackColor = false;
            this.cmdfeedback.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcid.Location = new System.Drawing.Point(368, 245);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(92, 26);
            this.txtcid.TabIndex = 40;
            this.txtcid.Text = "Enter Id";
            this.txtcid.Click += new System.EventHandler(this.txtcid_Click);
            this.txtcid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdrepair
            // 
            this.cmdrepair.BackColor = System.Drawing.Color.Honeydew;
            this.cmdrepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdrepair.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdrepair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdrepair.Location = new System.Drawing.Point(335, 344);
            this.cmdrepair.Name = "cmdrepair";
            this.cmdrepair.Size = new System.Drawing.Size(158, 28);
            this.cmdrepair.TabIndex = 39;
            this.cmdrepair.Text = "Repair";
            this.cmdrepair.UseVisualStyleBackColor = false;
            this.cmdrepair.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(199, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 44;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdhome
            // 
            this.cmdhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdhome.Location = new System.Drawing.Point(-1, -1);
            this.cmdhome.Margin = new System.Windows.Forms.Padding(0);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(200, 44);
            this.cmdhome.TabIndex = 43;
            this.cmdhome.Text = "Home";
            this.cmdhome.UseVisualStyleBackColor = false;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(399, -1);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 45;
            this.button4.Text = "Register User";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmregister_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdhome);
            this.Controls.Add(this.cmdfeedback);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.cmdrepair);
            this.Controls.Add(this.txtcmail);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(this.txtcproblem);
            this.Controls.Add(this.txtccell);
            this.Controls.Add(this.txtcdevice);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.cmdclogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmregister_user";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmregister_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcmail;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtcproblem;
        private System.Windows.Forms.TextBox txtccell;
        private System.Windows.Forms.TextBox txtcdevice;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Button cmdclogin;
        private System.Windows.Forms.Button cmdfeedback;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Button cmdrepair;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdhome;
        private System.Windows.Forms.Button button4;
    }
}