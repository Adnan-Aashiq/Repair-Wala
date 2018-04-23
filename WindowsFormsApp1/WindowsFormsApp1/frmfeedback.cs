using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmfeedback : Form
    {
        public frmfeedback()
        {
            InitializeComponent();
        }

        private static frmfeedback feedback_form;

        public static frmfeedback get_instance()
        {
            if (feedback_form == null)
            {
                feedback_form = new frmfeedback();
                return feedback_form;
            }
            else
                return feedback_form;
        }

        private void cmdsubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmfeedback_Load(object sender, EventArgs e)
        {

        }

        private void txtcomplaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcomplaint_Click(object sender, EventArgs e)
        {
            txtcomplaint.Clear();
            if(txtcomment.Text == "")
            {
                txtcomment.Text = "Comment About Your Experience";
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdcreg_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("FeedBack Submitted!");
            this.Hide();
        }

        private void txtcomment_Click(object sender, EventArgs e)
        {
            txtcomment.Clear();
            if(txtcomplaint.Text == "")
            {
                txtcomplaint.Text = "Complain About Your Experience";
            }
        }

        private void txtcomment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
        }
    }
}
