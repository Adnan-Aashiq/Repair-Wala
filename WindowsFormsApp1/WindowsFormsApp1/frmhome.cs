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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private static frmhome home_form;

        public static frmhome get_instance()
        {
            if (home_form == null)
            {
                home_form = new frmhome();
                return home_form;
            }
            else
                return home_form;
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            txtrepair.Hide();
            txtadmin.Hide();
            cmdrepairid.Hide();
            cmdadminId.Hide();
        }

        private void txtpasscode_Click(object sender, EventArgs e)
        {
            txtrepair.Clear();
        }

        private void cmdcustomer_Click(object sender, EventArgs e)
        {
            frmguest_user frm = frmguest_user.get_instance();
            this.Hide();
            frm.Show();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdrepairer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Passcode!");
            txtrepair.Show();
            cmdrepairid.Show();
        }

        private void txtpasscode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdadmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Passcode!");
            txtadmin.Show();
            cmdadminId.Show();
        }

        private void txtpassadmin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpassadmin_Click(object sender, EventArgs e)
        {
            txtadmin.Clear();
        }

        private void txtpasscode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtpasscode_Enter(object sender, EventArgs e)
        {
        }

        private void txtpassadmin_Enter(object sender, EventArgs e)
        {

        }

        private void cmdproceed_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            txtadmin.Hide();
            cmdadminId.Hide();
        }
    }
}
