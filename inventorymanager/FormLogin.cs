using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace inventorymanager
{
    public partial class FormLogin : Form
    {



        public FormLogin()
        {
            InitializeComponent();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Kiem tra co nhap lieu vao textbox ko
            if (string.IsNullOrEmpty(txtUserName.Text) == true || string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                MessageBox.Show("Chua nhap ten dang nhap hoac mat khau!");
                return;
            }
            #endregion
            string connString = "Data Source=.;Initial Catalog=Learning_QLBH;Integrated Security=True";
            SqlConnection connect = null;
            try
            {
                //ket noi csdl
                connect = new SqlConnection(connString);
                connect.Open();
                //Xử lý truy van
                #region Xu ly du lieu
                string sql = "select tendaydu from TaiKhoan where TenDangNhap like '" + txtUserName.Text + "' and MatKhau like '" + txtPassword.Text + "'";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                object data = command.ExecuteScalar();

                if (data == null)
                {
                    MessageBox.Show("Loi tai khoan, dang nhap khong thanh cong");
                }
                else
                {
                    //MessageBox.Show("Dan nhap thanh cong, ten nguoi dang la: "+data.ToString());
                    clsCauHinhHeThong.TenDangNhap = txtUserName.Text;
                    clsCauHinhHeThong.TenDayDu = data.ToString();
                    frmMainMenu frm = new frmMainMenu(data.ToString());
                    frm.Show();
                    this.Hide();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi lôi: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }



        }
    }
}
