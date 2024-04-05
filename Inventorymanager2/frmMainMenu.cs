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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private ucAccount ucAcc;

        private void btnObject_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Contains(ucAcc) == false)
            {
                ucAcc = new ucAccount();
                ucAcc.Dock = DockStyle.Fill;
                panel2.Controls.Add(ucAcc);
                ucAcc.BringToFront();
            }
            else
            { 
                ucAcc.BringToFront();

            }
        }
    }
}
