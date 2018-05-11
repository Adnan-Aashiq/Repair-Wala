namespace WindowsFormsApp1
{
    partial class frmrepairPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrepairPortal));
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmdhome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdselect = new System.Windows.Forms.Button();
            this.cmddone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblaccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtid.Location = new System.Drawing.Point(268, 259);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(178, 26);
            this.txtid.TabIndex = 2;
            this.txtid.Text = "Enter Id to select Order";
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // cmdhome
            // 
            this.cmdhome.BackColor = System.Drawing.Color.Silver;
            this.cmdhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdhome.Location = new System.Drawing.Point(0, -1);
            this.cmdhome.Margin = new System.Windows.Forms.Padding(0);
            this.cmdhome.Name = "cmdhome";
            this.cmdhome.Size = new System.Drawing.Size(200, 44);
            this.cmdhome.TabIndex = 25;
            this.cmdhome.Text = "Home";
            this.cmdhome.UseVisualStyleBackColor = false;
            this.cmdhome.Click += new System.EventHandler(this.cmdhome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 158);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 304);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(819, 89);
            this.dataGridView2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(200, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 30;
            this.button1.Text = "Repairer Portal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Remove",
            "Fix Appointmert"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completed",
            "Not Completed",
            "Delete",
            "Fix Appointment"});
            this.comboBox1.Location = new System.Drawing.Point(835, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Selected Order";
            // 
            // cmdselect
            // 
            this.cmdselect.BackColor = System.Drawing.Color.Honeydew;
            this.cmdselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdselect.Location = new System.Drawing.Point(471, 254);
            this.cmdselect.Name = "cmdselect";
            this.cmdselect.Size = new System.Drawing.Size(174, 31);
            this.cmdselect.TabIndex = 35;
            this.cmdselect.Text = "Select Order";
            this.cmdselect.UseVisualStyleBackColor = false;
            this.cmdselect.Click += new System.EventHandler(this.cmdselect_Click);
            // 
            // cmddone
            // 
            this.cmddone.BackColor = System.Drawing.Color.Honeydew;
            this.cmddone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmddone.Location = new System.Drawing.Point(850, 348);
            this.cmddone.Name = "cmddone";
            this.cmddone.Size = new System.Drawing.Size(86, 31);
            this.cmddone.TabIndex = 36;
            this.cmddone.Text = "Done";
            this.cmddone.UseVisualStyleBackColor = false;
            this.cmddone.Click += new System.EventHandler(this.cmddone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 63);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(236, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Your Current Account Balance is";
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Location = new System.Drawing.Point(554, 63);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblaccount.Size = new System.Drawing.Size(20, 19);
            this.lblaccount.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.if_sync_126579;
            this.pictureBox1.Location = new System.Drawing.Point(776, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmrepairPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmddone);
            this.Controls.Add(this.cmdselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdhome);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmrepairPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairPortal";
            this.Load += new System.EventHandler(this.frmrepairPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button cmdhome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdselect;
        private System.Windows.Forms.Button cmddone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}