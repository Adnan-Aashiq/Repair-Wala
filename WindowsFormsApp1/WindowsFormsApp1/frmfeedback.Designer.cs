namespace WindowsFormsApp1
{
    partial class frmfeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfeedback));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.txtcomplaint = new System.Windows.Forms.TextBox();
            this.cmdsubmit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(162, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // txtcomment
            // 
            this.txtcomment.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcomment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcomment.Location = new System.Drawing.Point(163, 198);
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(230, 26);
            this.txtcomment.TabIndex = 2;
            this.txtcomment.Text = "Comment About Your Experience";
            this.txtcomment.Click += new System.EventHandler(this.txtcomment_Click);
            this.txtcomment.TextChanged += new System.EventHandler(this.txtcomment_TextChanged);
            // 
            // txtcomplaint
            // 
            this.txtcomplaint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtcomplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcomplaint.Location = new System.Drawing.Point(162, 260);
            this.txtcomplaint.Name = "txtcomplaint";
            this.txtcomplaint.Size = new System.Drawing.Size(231, 26);
            this.txtcomplaint.TabIndex = 5;
            this.txtcomplaint.Text = "Complain About Your Experience";
            this.txtcomplaint.Click += new System.EventHandler(this.txtcomplaint_Click);
            this.txtcomplaint.TextChanged += new System.EventHandler(this.txtcomplaint_TextChanged);
            // 
            // cmdsubmit
            // 
            this.cmdsubmit.BackColor = System.Drawing.Color.Honeydew;
            this.cmdsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsubmit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdsubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdsubmit.Location = new System.Drawing.Point(163, 330);
            this.cmdsubmit.Name = "cmdsubmit";
            this.cmdsubmit.Size = new System.Drawing.Size(158, 30);
            this.cmdsubmit.TabIndex = 29;
            this.cmdsubmit.Text = "Submit";
            this.cmdsubmit.UseVisualStyleBackColor = false;
            this.cmdsubmit.Click += new System.EventHandler(this.cmdcreg_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(-2, -1);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 46;
            this.button4.Text = "Feedback";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(361, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "See Previous Feedback";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(87, 138);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(60, 201);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Comment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(61, 267);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Complain";
            // 
            // frmfeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmdsubmit);
            this.Controls.Add(this.txtcomplaint);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmfeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmfeedback";
            this.Load += new System.EventHandler(this.frmfeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtcomment;
        private System.Windows.Forms.TextBox txtcomplaint;
        private System.Windows.Forms.Button cmdsubmit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}