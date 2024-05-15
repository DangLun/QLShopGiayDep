using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanlyShopGiayDep.DAL;
using System.Security.Cryptography;
using System.Windows.Markup;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
//using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuanlyShopGiayDep.BLL;
namespace QuanlyShopGiayDep
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void RoundCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RoundCorners(this, 25);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        public void Login()
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(Username))
            {
                MessageBox.Show("Vui lòng không để trống tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT * FROM Accounts where username = @username and password = @password";
                Provider provider = new Provider();
                object[] Params = new object[] { Username, Password };
                DataTable Data = provider.ExcuteQuery(query, Params);
                int active = Data.Rows.Count;
                if (active == 0)
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BLLMain mainbll = new BLLMain();
                    if(mainbll.GetNameStaffByUsername(Username) != "-1")
                    {
                        MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        FrmMain main = new FrmMain(Username, Password);
                        main.ShowDialog();
                    }else
                    {
                        MessageBox.Show("Hiện tại tài khoản chưa có nhân viên sở hữu !", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnInfoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
