using QuanlyShopGiayDep.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms.Account
{
    public partial class FrmCapTK : Form
    {
        public FrmCapTK()
        {
            InitializeComponent();
        }
        BLLStaff staffbll = new BLLStaff(); 
        BLLAccount accountbll = new BLLAccount();

        private void LoadDataStaff()
        {
            DataTable dt = staffbll.GetDataStaffNoAccount();
            //foreach(DataRow dr in dt.Rows) {
            //    cmbInfoNhanVien.Items.Add(dr["Name"] + " - " + dr["Phone"]);
            //}
            //cmbInfoNhanVien.SelectedIndex = 0;
            cmbInfoNhanVien.DataSource = dt;
            cmbInfoNhanVien.DisplayMember = "Name";
            cmbInfoNhanVien.ValueMember = "ID";
        }
        private void LoadDataAccount()
        {
            DataTable dt = accountbll.GetAccountNoStaff();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    cmbInfoAccount.Items.Add(dr["username"] + " - " + dr["password"]);
            //}
            //cmbInfoAccount.SelectedIndex = 0;
            cmbInfoAccount.DataSource = dt;
            cmbInfoAccount.DisplayMember = "username";
            cmbInfoAccount.ValueMember = "ID";
        }
        private void FrmCapTK_Load(object sender, EventArgs e)
        {
            LoadDataStaff();
            LoadDataAccount();
        }

        private void btnCap_Click(object sender, EventArgs e)
        {

            if(cmbInfoNhanVien.SelectedValue != null && cmbInfoAccount.SelectedValue != null)
            {
                int id_staff = int.Parse(cmbInfoNhanVien.SelectedValue.ToString());
                int id_account = int.Parse(cmbInfoAccount.SelectedValue.ToString());
                int r = staffbll.UpdateAccountStaff(id_account, id_staff);
                if (r > 0)
                {
                    MessageBox.Show("Đã cấp tài khoản cho nhân viên " + cmbInfoNhanVien.SelectedText, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStaff();
                    LoadDataAccount();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình cấp tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
