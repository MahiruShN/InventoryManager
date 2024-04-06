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
            gridViewAccoutList.DataSource = DataProvider.Ins.DB.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            AccountManager.UpdateGridView(gridViewAccoutList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridViewAccoutList.Rows.Clear();
            AccountManager.UpdateGridView(gridViewAccoutList);
        }
    }
}
