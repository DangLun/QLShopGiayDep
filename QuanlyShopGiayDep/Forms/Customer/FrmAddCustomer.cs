using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms.Customer
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }
        BLLCustomer customerbll = new BLLCustomer();    
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            txtNameCustomer.Focus();
        }
        private void AddCustomer()
        {
            string name = txtNameCustomer.Text;
            string phone = txtSDT.Text;
            string gender = "Nam";
            if (rdbNu.Checked)
            {
                gender = "Nữ";
            }
            int score = 0;
            CustomerModel customer = new CustomerModel();
            customer.Name = name;
            customer.Phone = phone;
            customer.Gender = gender;
            customer.Score = score;
            customer.Created = DateTime.Now;    
            int r = customerbll.AddCustomerNoScore(customer);
            if(r > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public bool CheckNull(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                return true;
            }
            return false;
        }
        private void SetError(Control control, string message = "")
        {
            epCheck.SetError(control, message);
        }
        private bool CheckSDT(string sdt)
        {
            string phonePattern = @"^\d{3}[-.\s]?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(sdt, phonePattern);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (CheckNull(txtNameCustomer))
            {
                SetError(txtNameCustomer, "Không được để trống Tên khách hàng");
                return;
            } else SetError(txtNameCustomer);
            if (CheckNull(txtSDT))
            {
                SetError(txtSDT, "Không được để trống Số điện thoại khách hàng");
                return;
            }else SetError(txtSDT);
            if (!CheckSDT(txtSDT.Text))
            {
                SetError(txtSDT, "Định dạng số điện thoại sai");
                return;
            }
            else SetError(txtSDT);
            AddCustomer();
        }
    }
}
