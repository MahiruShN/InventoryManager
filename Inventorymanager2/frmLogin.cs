using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Inventorymanager2.Model;
using System.Data.Entity;





namespace Inventorymanager2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void login(string username, string password)
        {
            if (txbUserName.Text != "" && txbPassword.Text != "")
            {
               
                var account = DataProvider.Ins.DB.Users.Where(p => p.UserName == username && p.Password == password).Count();
                if (account > 0)
                {
                    frmMainMenu p = new frmMainMenu();
                    this.Hide();

                    p.Show();

                }
                else
                {
                    MessageBox.Show("dang nhap khong thanh cong");
                };


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txbUserName.Text;
            String password = AccountManager.ConvertToSha256(txbPassword.Text);
            login( username, password);
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
