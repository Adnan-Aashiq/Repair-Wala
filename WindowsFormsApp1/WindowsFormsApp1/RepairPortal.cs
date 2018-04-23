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
            if(comboBox1.Text == "Completed")
            {
                MessageBox.Show("80% Amount is added to your account!");
            }
            if(comboBox1.Text == "Remove")
            {
                MessageBox.Show("Client is removed from Record!");
            }
            if (comboBox1.Text == "Fix Appointment")
            {
                MessageBox.Show("Appointment Fixed!");
            }

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
                    Utility.curr_repairer.Appointment = c;
                    MessageBox.Show("Order Selected!");
                    BindingSource S = new BindingSource();
                    S.DataSource = c;
                    dataGridView2.DataSource = S;
                }
            }
        }
    }
}
