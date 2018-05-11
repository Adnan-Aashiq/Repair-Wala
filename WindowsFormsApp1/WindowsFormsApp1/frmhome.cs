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
            Utility.curr_repairer = null;
            int x;
            bool id = true, start;
            Myserver.Service1 server = new Myserver.Service1();
            server.start(out start,out id);
            if(start == true)
            {

                server.Add_Clients("Junaid Ali", "LCD damage", "Johar Town Lahore", "03216964902", "Laptop", "Johhny424@gmail", out x, out id);
                server.Add_Clients("Adnan Ashiq", "Charging Jeck", "Mumtaz hall UET Lahore", "03022149193", "Mobile", "AdnanAashiq457@gmail", out x, out id);
                server.Add_Clients("Rafay", "Battery Dead", "Garden Town Lahore", "03217353212", "IPhone", "Rafay420@gmail", out x, out id);
                server.Add_Repairer("Sohaib Arif", "Mumtaz HAll UET lahore", "03054238171", "352027362810662", 1, id);
                server.Add_Repairer("Bilal Sheikh", "Muslim Town Lahore", "032198761234", "35202312009662", 2, id);

            }

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
            bool valid = false;
            Myserver.Service1 server = new Myserver.Service1();
            List<Myserver.Repairer> list = server.Get_repairers_list().ToList<Myserver.Repairer>();
            foreach (Myserver.Repairer r in list)
            {
                if (txtrepair.Text == r.Id.ToString())
                {
                    {
                        valid = true;
                        Utility.curr_repairer = r;
                        break;
                    }
                }
            }
            if(valid== true)
            {
                MessageBox.Show("Login Successful!");
                frmrepairPortal frm = new frmrepairPortal();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid!");
                
            }
            txtrepair.Hide();
            txtrepair.Text = "Enter Passcode!";
            cmdrepairid.Hide();
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Myserver.Service1 server = new Myserver.Service1();
            if(txtadmin.Text== server.get_admin_id())
            {
                txtadmin.Hide();
                txtadmin.Text = "Enter Passcode!";
                cmdadminId.Hide();
                frmadmin frm = new frmadmin();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid!");
            }
            txtadmin.Hide();
            txtadmin.Text = "Enter Passcode!";
            cmdadminId.Hide();
        }
    }
}
