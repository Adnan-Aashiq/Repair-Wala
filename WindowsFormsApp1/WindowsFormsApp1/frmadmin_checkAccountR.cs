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
    public partial class frmadmin_checkAccountR : Form
    {
        public frmadmin_checkAccountR()
        {
            InitializeComponent();
        }
        private static frmadmin_checkAccountR admin_chk;

        public static frmadmin_checkAccountR get_instance()
        {
            if (admin_chk == null)
            {
                admin_chk = new frmadmin_checkAccountR();
                return admin_chk;
            }
            else
                return admin_chk;
        }

        private void frmadmin_checkAccountR_Load(object sender, EventArgs e)
        {
            BindingSource S = new BindingSource();
            S.DataSource = Utility.selected_repairer;
            dataGridView1.DataSource = S;
            //dataGridView1.Columns.Remove("Account Specified");
            dataGridView1.Columns.RemoveAt(5);
            dataGridView1.Columns.RemoveAt(1);
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            frmadmin frm = frmadmin.get_instance();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //dataGridView1.Columns["Id Specified"].Visible = false;
            //dataGridView1.Columns.RemoveAt(5);
            
        }
    }
}
