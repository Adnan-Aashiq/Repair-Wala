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
    public partial class OnlineBank : Form
    {
        public OnlineBank()
        {
            InitializeComponent();
        }

        private void OnlineBank_Load(object sender, EventArgs e)
        {

        }

        private void cmdbank_Click(object sender, EventArgs e)
        {

        }

        private void txtacountnmbr_Click(object sender, EventArgs e)
        {
            txtacountnmbr.Clear();
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdpay_Click(object sender, EventArgs e)
        {
            bool asd=false;
            bool x, id = true;
            Myserver.Service1 server = new Myserver.Service1();
            if (txtacountnmbr.Text.Any(Char.IsLetter) || txtamount.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Account & Amount Number be Digits!");
            }
            else
            {

                /*List<Myserver.Repairer> list = server.Get_repairers_list().ToList<Myserver.Repairer>();
                foreach(Myserver.Repairer r in list)
                {
                    if(r.Appointment == Utility.curr_login_client)
                    {
                        asd = true;
                        int a = int.Parse(txtamount.Text);
                        r.Account = r.Account + a;
                        server.edit_repairer(r, out x, out id);
                        txtamount.Text = a.ToString();
                        
                    }
                }*/
                bool l=true;
                int a = int.Parse(txtamount.Text);
                server.pay(Utility.curr_login_client, a, l, out asd, out id);
                txtamount.Text = a.ToString();
            }
            if (asd == false)
            {
                MessageBox.Show("You are not Appointed by any repirer yet!");
            }
            this.Hide();
            frmregister_user frm = new frmregister_user();
            frm.Show();
            
        }

        private void txtamount_Click(object sender, EventArgs e)
        {
            txtamount.Clear();
        }
    }
}
