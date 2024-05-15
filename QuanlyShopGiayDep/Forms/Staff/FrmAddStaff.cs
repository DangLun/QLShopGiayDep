using OfficeOpenXml;
using OfficeOpenXml.Filter;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms.Staff
{
    public partial class FrmAddStaff : Form
    {
        StaffDAL staffdal = new StaffDAL();
        public FrmAddStaff()
        {
            InitializeComponent();
        }
        public void resetForm()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            rdbNam.Checked = true;
            dtpBirthDate.Value = DateTime.Now;
            txtName.Focus();
        }
        public void SetUpStartForm()
        {
            txtName.Focus();
        }
        private void FrmAddStaff_Load(object sender, EventArgs e)
        {
            SetUpStartForm();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        public bool CheckNull(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                return true;
            }
            return false;
        }
        private void btnExitFrmAddStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetError(Control control, string message = "")
        {
            ErrorIcon.SetError(control, message);
        }

        private bool CheckSDT(string sdt)
        {
            string phonePattern = @"^\d{3}[-.\s]?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(sdt, phonePattern);
        }

        private bool CheckBirthDate(DateTimePicker datepk)
        {
            DateTime datetime = datepk.Value;
            int year = datetime.Year;
            int month = datetime.Month;
            int day = datetime.Day;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            if (year < currentYear)
            {
                return true;
            }
            else if (year == currentYear)
            {
                if (month < currentMonth)
                {
                    return true;
                }
                else if (month == currentMonth)
                {
                    if (day <= currentDay)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string getGender()
        {
            string gender = "Nam";
            if (rdbNu.Checked)
            {
                gender = "Nữ";
            }else if(rdbKhac.Checked)
            {
                gender = "Khác";
            }
            return gender;
        }
        private bool CheckDigit(string integer)
        {
            string integerPattern = @"^(?!0\d)\d+$";
            return Regex.IsMatch(integer, integerPattern);
        }
        
        private async void btnAddAccep_Click(object sender, EventArgs e)
        {
            if (CheckNull(txtName))
            {
                SetError(txtName, "Không được bỏ trống Tên nhân viên");
                return;
            }else
            {
                SetError(txtName);
            }
            if (CheckNull(txtPhone))
            {
                SetError(txtPhone, "Không được bỏ trống Số điện thoại");
                return;
            }
            else
            {
                SetError(txtPhone);
            }
            if (CheckNull(txtSalary))
            {
                SetError(txtSalary, "Không được bỏ trống Lương");
                return;
            }
            else
            {
                SetError(txtSalary);
            }

            // check sdt

            if (!CheckSDT(txtPhone.Text))
            {
                SetError(txtPhone, "Định dạng số điện thoại sai");
                return;
            }else
            {
                SetError(txtPhone);
            }

            // check birthDate

            if(!CheckBirthDate(dtpBirthDate))
            {
                SetError(dtpBirthDate, "Ngày sinh không hợp lệ");
                return;
            }else
            {
                SetError(dtpBirthDate);
            }

            // check Luong

            if (!CheckDigit(txtSalary.Text))
            {
                SetError(txtSalary, "Lương không hợp lệ");
                return;
            }
            else
            {
                SetError(txtSalary);
            }

            StaffModel staff = new StaffModel();
            staff.Name = txtName.Text;
            staff.Phone = txtPhone.Text;
            staff.BirthDate = dtpBirthDate.Value;
            staff.Gender = getGender();
            staff.Salary = int.Parse(txtSalary.Text);
            if (await staffdal.InsertStaff(staff) > 0)
            {
                MessageBox.Show("Thêm Nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
