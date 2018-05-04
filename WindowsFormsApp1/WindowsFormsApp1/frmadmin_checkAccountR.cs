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
        }

        private void cmdhome_Click(object sender, EventArgs e)
        {
            frmhome frm = frmhome.get_instance();
            this.Hide();
            frm.Show();
        }
    }
}
