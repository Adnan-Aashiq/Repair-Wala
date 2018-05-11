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
    public partial class frmguest_user : Form
    {
        public static int count=1201;
        public static int inc = 1;
        public frmguest_user()
        {
            InitializeComponent();
        }
        private static frmguest_user guest_user;

        public static frmguest_user get_instance()
        {
            if (guest_user == null)
            {
                guest_user = new frmguest_user();
                return guest_user;
            }
            else
                return guest_user;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdcreg_Click(object sender, EventArgs e)
        {
         
            if (txtcname.Text == "" || txtccell.Text == "" || txtcaddress.Text == "" || txtcdevice.Text == "" || txtcmail.Text == "" || txtcproblem.Text == "")
            {
                MessageBox.Show("Enter all the entries!");
            }
            else
            {
                if(!txtcname.Text.Any(Char.IsLetter) || !txtcaddress.Text.Any(Char.IsLetter) || !txtcproblem.Text.Any(Char.IsLetter) || !txtcdevice.Text.Any(Char.IsLetter) || !txtcmail.Text.Any(Char.IsLetter)) //agr letter nahi hai
                {
                    MessageBox.Show("Name,Address,Problem,Device & Mail should be Letters!");
                }
                else
                {
                    if(txtccell.Text.Any(Char.IsLetter))
                    {
                        MessageBox.Show("Phone Number Should be Digits!");
                    }
                    else
                    {
                        Myserver.Service1 server = new Myserver.Service1();
                        int x;
                        bool ok = true;
                        server.Add_Clients(txtcname.Text, txtcproblem.Text, txtcaddress.Text, txtccell.Text, txtcdevice.Text, txtcmail.Text, out x, out ok);
                        MessageBox.Show("User has been Registered!");
                        List<Myserver.client> list = server.Get_client_list().ToList<Myserver.client>();
                        foreach(Myserver.client c in list)
                        {
                            if(c.Id_client== x)
                            {
                                Utility.curr_reg_client = c;
                                break;
                            }
                        }
                        lblid.Text = x.ToString();
                        lblid.Show();
                        lblidtext.Show();
                        cmdrepair.Show();
                    }
                }
            }

            
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            lblidtext.Hide();
            lblid.Hide();
            cmdrepair.Hide();
        }

        private void cmdclogin_Click(object sender, EventArgs e)
        {
            frmregister_user frm =new frmregister_user();
            this.Hide();
            frm.Show();
            txtcname.Text = "Enter Name";
            txtccell.Text = "Enter Phone#";
            txtcdevice.Text = "Enter Device";
            txtcproblem.Text = "Enter Problem";
            txtcaddress.Text = "Enter Address";
            txtcmail.Text = "Enter E Mail";
            lblidtext.Hide();
            lblid.Hide();

        }

        private void lblcchkid_Click(object sender, EventArgs e)
        {

        }

        private void lblcid_Click(object sender, EventArgs e)
        {

        }

        private void txtcchkid_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void cmdreset_Click(object sender, EventArgs e)
        {
            
        }*/

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdcrepair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Request has been sent!");
        }

        private void txtcname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtcname_Click(object sender, EventArgs e)
        {
            txtcname.Clear();
            if (txtccell.Text == "")
            {
                txtccell.Text = "Enter Phone#";
            }
            if (txtcdevice.Text == "")
            {
                txtcdevice.Text = "Enter Device";
            }
            if (txtcproblem.Text == "")
            {
                txtcproblem.Text = "Enter Problem";
            }
            if (txtcaddress.Text == "")
            {
                txtcaddress.Text = "Enter Address";
            }
            if (txtcmail.Text == "")
            {
                txtcmail.Text = "Enter Mail";
            }
        }

        private void txtccell_Click(object sender, EventArgs e)
        {
            txtccell.Clear();
            
            if(txtcname.Text == "")
            {
                txtcname.Text = "Enter Name";
            }
            if (txtcdevice.Text == "")
            {
                txtcdevice.Text = "Enter Device";
            }
            if (txtcproblem.Text == "")
            {
                txtcproblem.Text = "Enter Problem";
            }
            if (txtcaddress.Text == "")
            {
                txtcaddress.Text = "Enter Address";
            }
            if (txtcmail.Text == "")
            {
                txtcmail.Text = "Enter Mail";
            }

        }

        private void txtcdevice_Click(object sender, EventArgs e)
        {
            txtcdevice.Clear();
            
            if (txtcname.Text == "")
            {
                txtcname.Text = "Enter Name";
            }
            if (txtccell.Text == "")
            {
                txtccell.Text = "Enter Phone#";
            }
            if (txtcproblem.Text == "")
            {
                txtcproblem.Text = "Enter Problem";
            }
            if (txtcaddress.Text == "")
            {
                txtcaddress.Text = "Enter Address";
            }
            if (txtcmail.Text == "")
            {
                txtcmail.Text = "Enter Mail";
            }
        }

        private void txtcproblem_Click(object sender, EventArgs e)
        {
            txtcproblem.Clear();
            
            if (txtcname.Text == "")
            {
                txtcname.Text = "Enter Name";
            }
            if (txtccell.Text == "")
            {
                txtccell.Text = "Enter Phone#";
            }
            if (txtcdevice.Text == "")
            {
                txtcdevice.Text = "Enter Device";
            }
            if (txtcaddress.Text == "")
            {
                txtcaddress.Text = "Enter Address";
            }
            if (txtcmail.Text == "")
            {
                txtcmail.Text = "Enter Mail";
            }
        }

        private void txtcaddress_Click(object sender, EventArgs e)
        {
            txtcaddress.Clear();
           
            if (txtcname.Text == "")
            {
                txtcname.Text = "Enter Name";
            }
            if (txtccell.Text == "")
            {
                txtccell.Text = "Enter Phone#";
            }
            if (txtcdevice.Text == "")
            {
                txtcdevice.Text = "Enter Device";
            }
            if (txtcproblem.Text == "")
            {
                txtcproblem.Text = "Enter Problem";
            }
            if (txtcmail.Text == "")
            {
                txtcmail.Text = "Enter Mail";
            }
        }

        private void txtcmail_Click(object sender, EventArgs e)
        {
            txtcmail.Clear();
            
            if (txtcname.Text == "")
            {
                txtcname.Text = "Enter Name";
            }
            if (txtccell.Text == "")
            {
                txtccell.Text = "Enter Phone#";
            }
            if (txtcdevice.Text == "")
            {
                txtcdevice.Text = "Enter Device";
            }
            if (txtcproblem.Text == "")
            {
                txtcproblem.Text = "Enter Problem";
            }
            if (txtcaddress.Text == "")
            {
                txtcaddress.Text = "Enter Address";
            }
        }

        private void txtcchkid_Click(object sender, EventArgs e)
        {
            

        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            Utility.curr_reg_client = null;
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
            txtcname.Text = "Enter Name";
            txtccell.Text = "Enter Phone#";
            txtcdevice.Text = "Enter Device";
            txtcproblem.Text = "Enter Problem";
            txtcaddress.Text = "Enter Address";
            txtcmail.Text = "Enter E Mail";
            lblidtext.Hide();
            lblid.Hide();
        }

        private void cmdfeedback_Click(object sender, EventArgs e)
        {
            frmfeedback frm = new frmfeedback();
            frm.Show();
        }

        private void txtcname_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Myserver.Service1 server = new Myserver.Service1();
            bool done;
            bool pass;
            server.Assign_client(Utility.curr_reg_client,out done,out pass);
            if(done == true)
            {
                MessageBox.Show("Your Request has been sent!");
            }
            else
            {
                MessageBox.Show("System Failure!");
            }
        }

        private void cmdreset_Click_1(object sender, EventArgs e)
        {
            txtcname.Text = "Enter Name";
            txtccell.Text = "Enter Phone#";
            txtcdevice.Text = "Enter Device";
            txtcproblem.Text = "Enter Problem";
            txtcaddress.Text = "Enter Address";
            txtcmail.Text = "Enter E Mail";
            lblidtext.Hide();
            lblid.Hide();
        }
    }
}
