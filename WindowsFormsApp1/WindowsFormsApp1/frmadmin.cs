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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        private static frmadmin admin_frm;

        public static frmadmin get_instance()
        {
            if (admin_frm == null)
            {
                admin_frm = new frmadmin();
                return admin_frm;
            }
            else
                return admin_frm;
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            Myserver.Admin admin = new Myserver.Admin();
            lbladminname.Text = admin.Name;
            lbladminname.Show();
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
            txtraddress.Text = "Enter Address";
            txtrid.Text = "Issue Id";
            txtrcnic.Text = "Enter Repairers Id";
            txtrcell.Text = "Enter Repairer Cell#";
            txtrname.Text = "Enter Repairers Name";
        }

        
        private void txtid_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdcreg_Click(object sender, EventArgs e)
        {

            if (txtrname.Text == "" || txtrcell.Text == "" || txtraddress.Text == "" || txtrid.Text == "" || txtrcnic.Text == "")
            {
                MessageBox.Show("Enter all the entries!");
            }
            else
            {
                if (!txtrname.Text.Any(Char.IsLetter) || !txtraddress.Text.Any(Char.IsLetter) ) //agr letter nahi hai
                {
                    MessageBox.Show("Name & Address should be Letters!");
                }
                else
                {
                    if (txtrcell.Text.Any(Char.IsLetter) || txtrcnic.Text.Any(Char.IsLetter))
                    {
                        MessageBox.Show("Phone & Cnic Number Should be Digits!");
                    }
                    else
                    {
                        Myserver.Service1 server = new Myserver.Service1();
                        bool ok = true;
                        int id = int.Parse(txtrid.Text);
                        server.Add_Repairer(txtrname.Text, txtraddress.Text, txtrcell.Text,txtrcnic.Text, id,ok);
                        txtrid.Text = id.ToString();
                        MessageBox.Show("Repairer Registered!");
                        
                        
                        /*server.(txtcname.Text, txtcproblem.Text, txtcaddress.Text, txtccell.Text, txtcdevice.Text, txtcmail.Text, out x, out ok);
                        MessageBox.Show("User has been Registered!");
                        txtcid.Text = x.ToString();
                        txtcid.Show();*/
                    }
                }
            }
        }
      

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cmdreset_Click(object sender, EventArgs e)
        {
            txtraddress.Text = "Enter Address";
            txtrid.Text = "Issue Id";
            txtrcnic.Text = "Enter Repairers Id";
            txtrcell.Text = "Enter Repairer Cell#";
            txtrname.Text = "Enter Repairers Name";
        }

        private void txtrname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtrcell_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtraddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrname_Click(object sender, EventArgs e)
        {
            txtrname.Clear();
            
            if (txtrcell.Text == "")
            {
                txtrcell.Text = "Enter Repairer Cell#";
            }
            if (txtrexist.Text == "")
            {
                txtrexist.Text = "Enter Id of Existing Repairer";
            }
            if (txtrcnic.Text == "")
            {
                txtrcnic.Text = "Enter Repairers Id";
            }
            if (txtrid.Text == "")
            {
                txtrid.Text = "Issue Id";
            }
            if (txtraddress.Text == "")
            {
                txtraddress.Text = "Enter Address";
            }
        }

        private void txtrcell_Click(object sender, EventArgs e)
        {
            txtrcell.Clear();
            
            if (txtrname.Text == "")
            {
                txtrname.Text = "Enter Repairers Name";
            }
            if (txtrexist.Text == "")
            {
                txtrexist.Text = "Enter Id of Existing Repairer";
            }
            if (txtrcnic.Text == "")
            {
                txtrcnic.Text = "Enter Repairers Id";
            }
            if (txtrid.Text == "")
            {
                txtrid.Text = "Issue Id";
            }
            if (txtraddress.Text == "")
            {
                txtraddress.Text = "Enter Address";
            }
        }

        private void txtrcnic_Click(object sender, EventArgs e)
        {
            txtrcnic.Clear();
            
            if (txtrcell.Text == "")
            {
                txtrcell.Text = "Enter Repairer Cell#";
            }
            if (txtrexist.Text == "")
            {
                txtrexist.Text = "Enter Id of Existing Repairer";
            }
            if (txtrname.Text == "")
            {
                txtrname.Text = "Enter Repairers Name";
            }
            if (txtrid.Text == "")
            {
                txtrid.Text = "Issue Id";
            }
            if (txtraddress.Text == "")
            {
                txtraddress.Text = "Enter Address";
            }
        }

        private void txtraddress_Click(object sender, EventArgs e)
        {
            txtraddress.Clear();
            
            if (txtrcell.Text == "")
            {
                txtrcell.Text = "Enter Repairer Cell#";
            }
            if (txtrexist.Text == "")
            {
                txtrexist.Text = "Enter Id of Existing Repairer";
            }
            if (txtrcnic.Text == "")
            {
                txtrcnic.Text = "Enter Repairers Id";
            }
            if (txtrid.Text == "")
            {
                txtrid.Text = "Issue Id";
            }
            if (txtrname.Text == "")
            {
                txtrname.Text = "Enter Repairers Name";
            }
        }

        private void txtrid_Click(object sender, EventArgs e)
        {
            txtrid.Clear();
            
            if (txtrcell.Text == "")
            {
                txtrcell.Text = "Enter Repairer Cell#";
            }
            if (txtrexist.Text == "")
            {
                txtrexist.Text = "Enter Id of Existing Repairer";
            }
            if (txtrcnic.Text == "")
            {
                txtrcnic.Text = "Enter Repairers Id";
            }
            if (txtrname.Text == "")
            {
                txtrname.Text = "Enter Repairers Name";
            }
            if (txtraddress.Text == "")
            {
                txtraddress.Text = "Enter Address";
            }
        }

        private void txtrexist_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrexist_Click(object sender, EventArgs e)
        {
            txtrexist.Clear();
            
            if (txtrcell.Text == "")
            {
                txtrcell.Text = "Enter Repairer Cell#";
            }
            if (txtrname.Text == "")
            {
                txtrname.Text = "Enter Repairers Name";
            }
            if (txtrcnic.Text == "")
            {
                txtrcnic.Text = "Enter Repairers Id";
            }
            if (txtrid.Text == "")
            {
                txtrid.Text = "Issue Id";
            }
            if (txtraddress.Text == "")
            {
                txtraddress.Text = "Enter Address";
            }
        }
    }
}
