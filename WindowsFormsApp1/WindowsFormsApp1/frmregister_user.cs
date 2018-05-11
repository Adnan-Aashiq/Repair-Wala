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
    public partial class frmregister_user : Form
    {
        public frmregister_user()
        {
            InitializeComponent();
        }
        private static frmregister_user register_form;

        public static frmregister_user get_instance()
        {
            if (register_form == null)
            {
                register_form = new frmregister_user();
                return register_form;
            }
            else
                return register_form;
        }

        private void frmregister_user_Load(object sender, EventArgs e)
        {
            txtcaddress.Hide();
            txtccell.Hide();
            txtcdevice.Hide();
            txtcmail.Hide();
            txtcname.Hide();
            txtcproblem.Hide();
            cmdfeedback.Hide();
            cmdrepair.Hide();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            Utility.curr_login_client = null;
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
            txtcaddress.Hide();
            txtccell.Hide();
            txtcdevice.Hide();
            txtcmail.Hide();
            txtcname.Hide();
            txtcproblem.Hide();
            cmdfeedback.Hide();
            cmdrepair.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmfeedback frm = frmfeedback.get_instance();
            this.Hide();
            frm.Show();
            txtcaddress.Hide();
            txtccell.Hide();
            txtcdevice.Hide();
            txtcmail.Hide();
            txtcname.Hide();
            txtcproblem.Hide();
            cmdfeedback.Hide();
            cmdrepair.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdclogin_Click(object sender, EventArgs e)
        {
            Myserver.Service1 server = new Myserver.Service1();
            bool isvalid;
            bool passed;
            bool specified=true;
            int id= int.Parse(txtcid.Text);
            server.is_login(id,specified, out isvalid,out passed);
            txtcid.Text = id.ToString();
            if(isvalid == true)
            {
                MessageBox.Show("Login Successful!");
                List<Myserver.client> list = server.Get_client_list().ToList<Myserver.client>();
                foreach(Myserver.client c in list)
                {
                    if(c.Id_client == id)
                    {
                        Utility.curr_login_client = c;
                        break;
                    }
                }
                txtcname.Text= Utility.curr_login_client.Name_client;
                txtcaddress.Text = Utility.curr_login_client.Address;
                txtccell.Text = Utility.curr_login_client.Cell_client;
                txtcmail.Text = Utility.curr_login_client.Mail;
                txtcproblem.Show();
                txtcdevice.Show();
                cmdfeedback.Show();
                txtcname.Show();
                txtcaddress.Show();
                txtccell.Show();
                txtcmail.Show();
                cmdrepair.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login!");
            }
        }

        private void txtcdevice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcproblem_TextChanged(object sender, EventArgs e)
        {
                   }

        private void txtcid_Click(object sender, EventArgs e)
        {
            txtcid.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtcproblem.Text == "Enter Problem" || txtcdevice.Text == "Enter Device")
            {
                MessageBox.Show("Enter Problem and Device first!");
            }
            else
            {
                Myserver.Service1 server = new Myserver.Service1();
                bool done;
                bool pass;
                Myserver.client edi = new Myserver.client();
                edi = Utility.curr_login_client;
                edi.Device = txtcdevice.Text;
                edi.Problem = txtcproblem.Text;
                Utility.curr_login_client = edi;
                server.Assign_client(Utility.curr_login_client, out done, out pass);
                if (done == true)
                {
                    MessageBox.Show("Your Request has been sent!");
                }
                else
                {
                    MessageBox.Show("System Failure!");
                }
            }
            /*Myserver.client c = new Myserver.client();
            Myserver.Service1 server = new Myserver.Service1();
            List<Myserver.client> list = server.Get_clients_list().ToList<Myserver.client>();*/
        }

        private void txtcdevice_Click(object sender, EventArgs e)
        {
            txtcdevice.Clear();
        }

        private void txtcproblem_Click(object sender, EventArgs e)
        {
            txtcproblem.Clear();
        }

        private void frmregister_user_Click(object sender, EventArgs e)
        {

        }

        private void txtacountnmbr_Click(object sender, EventArgs e)
        {
            
        }

        private void txtamount_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdbank_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnlineBank frm = new OnlineBank();
            this.Hide();
            frm.Show();
        }

        private void txtccell_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
