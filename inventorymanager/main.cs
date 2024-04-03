using System.Drawing.Printing;

namespace inventorymanager
{
    public partial class main : Form
    {
        private UCAccountManager AccountManager;
        private UCItemsManager ItemsManager;
        public main()
        {
            InitializeComponent();
            AccountManager = new UCAccountManager();
            ItemsManager = new UCItemsManager();
        }

        private void btnAccM_Click(object sender, EventArgs e)
        {
            if (!pnlApp.Contains(AccountManager))
            {
                pnlApp.Controls.Clear();
                pnlApp.Controls.Add(AccountManager);
            }
        }

        private void btnItemsM_Click(object sender, EventArgs e)
        {
            if (!pnlApp.Contains(ItemsManager))
            {
                pnlApp.Controls.Clear();
                pnlApp.Controls.Add(ItemsManager);
            }
        }
    }
}
