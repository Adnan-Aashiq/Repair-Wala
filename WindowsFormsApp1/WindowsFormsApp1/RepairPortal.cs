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
    public partial class frmrepairPortal : Form
    {
        
        public frmrepairPortal()
        {
            InitializeComponent();
        }
        private static frmrepairPortal repairer_form;

        public static frmrepairPortal get_instance()
        {
            if (repairer_form == null)
            {
                repairer_form = new frmrepairPortal();
                return repairer_form;
            }
            else
                return repairer_form;
        }

        private void txtcname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcname_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtid.Clear();
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
        }

        /*private void txtid_TextChanged(object sender, EventArgs e)
        {
            foreach (Clients cu in ClientsRecord.Clients_record)
            {
                if (cu.Id == txtid.Text)
                {
                    BindingSource S = new BindingSource();
                    S.DataSource = cu;
                    dataGridView2.DataSource = S;
                    r.Appointment = cu;
                }
            }
        }

        private void RepairPortal_Load(object sender, EventArgs e)
        {
            foreach (Clients cu in ClientsRecord.Clients_record)
            {
                BindingSource S = new BindingSource();
                S.DataSource = ClientsRecord.Clients_record;
                dataGridView1.DataSource = S;
            }
        }*/

        private void cmdcreg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("80% Amount is added to your account!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmrepairPortal_Load(object sender, EventArgs e)
        {
                BindingSource S = new BindingSource();
                S.DataSource = Utility.curr_repairer.Orders1;
                dataGridView1.DataSource = S;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {
            txtid.Clear();
        }

        private void cmdselect_Click(object sender, EventArgs e)
        {
            Myserver.Service1 server = new Myserver.Service1();
            List<Myserver.client> list = server.Get_client_list().ToList<Myserver.client>();
            foreach (Myserver.client c in list)
            {
                if (c.Id_client.ToString() == txtid.Text)
                {
                    BindingSource S = new BindingSource();
                    S.DataSource = c;
                    dataGridView2.DataSource = S;
                    Utility.selected_client = c;
                }
            }
        }

        private void cmddone_Click(object sender, EventArgs e)
        {
            bool x,id = true;
            Myserver.Service1 server = new Myserver.Service1();
            List<Myserver.client> list = server.Get_client_list().ToList<Myserver.client>();
            if (comboBox1.Text == "Completed")
            {
                bool stat = true;
                Utility.curr_repairer.Account = Utility.curr_repairer.Account + 300;
                
                server.remove_order(Utility.selected_client, Utility.curr_repairer.Id, stat);
                server.edit_repairer(Utility.curr_repairer, out x, out id);

                BindingSource S = new BindingSource();
                S.DataSource = null;
                dataGridView2.DataSource = S;
                MessageBox.Show("300Rs is added to your account!");
            }
            if(comboBox1.Text == "Delete")
            {
                /*foreach(Myserver.client c in Utility.curr_repairer.Orders1)
                {
                    if(txtid.Text == c.Id_client.ToString())
                    {
                        server.remove_order(c, Utility.curr_repairer.Id, id);
                    }
                }*/
                BindingSource S = new BindingSource();
                S.DataSource = null;
                dataGridView2.DataSource = S;

                MessageBox.Show("Client is removed from Record!");
            }
            if (comboBox1.Text == "Fix Appointment")
            {
                foreach (Myserver.client c in list)
                {
                    if (c.Id_client.ToString() == txtid.Text)
                    {
                        bool stat = true;
                        Utility.curr_repairer.Appointment = c;
                        MessageBox.Show("Appointment Fixed!");
                        server.fix_app(c, Utility.curr_repairer.Id, id);
                    }
                }
            }
        }

        private void cmdrefresh_Click(object sender, EventArgs e)
        {

            Myserver.Service1 server = new Myserver.Service1();
            List<Myserver.Repairer> list = server.Get_repairers_list().ToList<Myserver.Repairer>();
            if(txtid.Text == "" || txtid.Text == "Enter Id to select Order")
            {
                MessageBox.Show("Page can not be refreashed!");
            }
            else
            {
                foreach (Myserver.Repairer r in list)
                {
          
                    if (r.Id == Utility.curr_repairer.Id)
                    {
                        BindingSource S = new BindingSource();
                        S.DataSource = r.Orders1;
                        dataGridView1.DataSource = S;
                        break;
                    }
                }
            }
            
        }
    }
}
