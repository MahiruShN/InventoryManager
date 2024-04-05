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

        private static string ConvertToSha256(string text)
        {
            // Check if the text is null
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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
            String password = ConvertToSha256(txbPassword.Text);
            login( username, password);
        }
    }
}
