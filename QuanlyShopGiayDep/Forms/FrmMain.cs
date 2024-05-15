using FontAwesome.Sharp;
using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace QuanlyShopGiayDep
{
    public partial class FrmMain : Form
    {
        private IconButton CurrentButton = null;
        private Panel leftBorderBtn;
        private Form ChildForm = null;
        BLLMain mainbll = new BLLMain();
        public FrmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 65);
            pnLeft.Controls.Add(leftBorderBtn);
        }
        string username, password;
        public FrmMain(string _username, string _password)
        {
            InitializeComponent();
            username = _username;
            password = _password;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 65);
            pnLeft.Controls.Add(leftBorderBtn);
            
        }
        private struct RGBColors
        {
            public static Color BackColorClick = Color.FromArgb(37, 36, 81);
            public static Color DefaultColor = Color.FromArgb(98, 102, 244);
            public static Color colorIconHome = Color.FromArgb(172, 126, 241);
            public static Color colorIconOrders = Color.FromArgb(249, 118, 176);
            public static Color colorIconProducts = Color.FromArgb(253, 138, 114);
            public static Color colorIconCustomers = Color.FromArgb(95, 77, 221);
            public static Color colorIconStaffs = Color.FromArgb(249, 88, 155);
            public static Color colorIconAccounts = Color.FromArgb(6, 215, 157);
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn vẫn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public void SetColor(IconButton Button, Color color)
        {
            if(CurrentButton != null)
            {
                CurrentButton.BackColor = RGBColors.DefaultColor;
                CurrentButton.IconColor = Color.White;
                leftBorderBtn.Visible = false;
            }
            CurrentButton = Button;
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            leftBorderBtn.BackColor = color;
            CurrentButton.BackColor = RGBColors.BackColorClick;
            CurrentButton.IconColor = color;
        }
        public void SetTitle(Color color, string Name, IconChar Iconchar)
        {
            iconTitle.ForeColor = color;
            iconTitle.IconChar = Iconchar;
            lbTitle.Text = Name;
        }
        public void ShowChildForm(Form form)
        {
            if(ChildForm != null)
            {
                ChildForm.Close();
            }
            ChildForm = form;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
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

        private string GetNameStaffByUsername(string username) {
            return mainbll.GetNameStaffByUsername(username);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string chucvu = "[" + mainbll.GetChucVuByUsername(username) + "]";
            if(chucvu != "[Admin]") {
                btnAccounts.Visible = false;
                btnStaffs.Visible = false;
            }else
            {
                btnAccounts.Visible = true;
                btnStaffs.Visible = true;
            }
            lbChucVu.Text = chucvu;
            lbNameAdmin.Text = GetNameStaffByUsername(username);    
            SetColor(btnHome, RGBColors.colorIconHome);
            SetTitle(RGBColors.colorIconHome, btnHome.Text, btnHome.IconChar);
            ShowChildForm(new FrmHome());
            RoundCorners(this, 25);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            SetColor(btnAccounts, RGBColors.colorIconAccounts);
            SetTitle(RGBColors.colorIconAccounts, btnAccounts.Text, btnAccounts.IconChar);
            ShowChildForm(new FrmAccounts());
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            SetColor(btnStaffs, RGBColors.colorIconStaffs);
            SetTitle(RGBColors.colorIconStaffs, btnStaffs.Text, btnStaffs.IconChar);
            ShowChildForm(new FrmStaffs());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SetColor(btnCustomers, RGBColors.colorIconCustomers);
            SetTitle(RGBColors.colorIconCustomers, btnCustomers.Text, btnCustomers.IconChar);
            ShowChildForm(new FrmCustomers());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SetColor(btnProducts, RGBColors.colorIconProducts);
            SetTitle(RGBColors.colorIconProducts, btnProducts.Text, btnProducts.IconChar);
            ShowChildForm(new FrmProducts());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SetColor(btnOrders, RGBColors.colorIconOrders);
            SetTitle(RGBColors.colorIconOrders, btnOrders.Text, btnOrders.IconChar);
            ShowChildForm(new FrmOrders(username));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetColor(btnHome, RGBColors.colorIconHome);
            SetTitle(RGBColors.colorIconHome, btnHome.Text, btnHome.IconChar);
            ShowChildForm(new FrmHome());
        }

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
