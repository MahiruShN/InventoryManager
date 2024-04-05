using Inventorymanager2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventorymanager2
{
    public partial class ucAccount : UserControl
    {
        public ucAccount()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataProvider.Ins.DB.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();
            dataGridView1.Refresh();
        }
    }
}
