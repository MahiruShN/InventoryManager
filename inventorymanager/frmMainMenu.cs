using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanager
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(string TenDangNhap)
        {
            InitializeComponent();
            this.Text = "User: " + TenDangNhap + " | " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy");

        }

        private UCAccountManager AccountsManager;
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (mainPanel.Contains(AccountsManager) == false)
            {
                AccountsManager = new UCAccountManager();
                AccountsManager.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(AccountsManager);
                AccountsManager.BringToFront();

            }
            else
            {
                AccountsManager.BringToFront();
            }
        }

        private UCProductsManager ProductsManager;

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (mainPanel.Contains(ProductsManager) == false)
            {
                ProductsManager = new UCProductsManager();
                ProductsManager.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(ProductsManager);
                ProductsManager.BringToFront();

            }
            else
            {
                ProductsManager.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
