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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txbDisplayname.Text == "" || txbUsername.Text == "" || txbPassword.Text == "" || txbPassword.Text == "" || cbRoles.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            } else
            {
                string DisplayName = txbDisplayname.Text;
                string Username = txbUsername.Text;
                string Password = txbPassword.Text;
                int IdRole = cbRoles.SelectedIndex;
                AccountManager.AddAcount(DisplayName, Username, Password, IdRole);
                AccountManager.UpdateGridView();
                MessageBox.Show("Thêm tài khoản thành công");
                this.Close();
            }

            



        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            var UserIds = DataProvider.Ins.DB.UserRoles.Select(p => p.DisplayName).ToList();
            
            foreach (var User in UserIds) { cbRoles.Items.Add(User); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
