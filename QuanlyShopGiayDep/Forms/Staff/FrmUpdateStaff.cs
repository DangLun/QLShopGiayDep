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

namespace QuanlyShopGiayDep.Forms.Staff
{
    public partial class FrmUpdateStaff : Form
    {
        public FrmUpdateStaff()
        {
            InitializeComponent();
        }
        int id = -1, luong = -1;
        string name = "", phone = "", gender = "";
        DateTime birthdate = new DateTime();
        BLLStaff staffbll = new BLLStaff();
        public FrmUpdateStaff(int _id, string _name, string _phone, DateTime _birthdate, string _gender, int _luong)
        {
            id = _id;
            name = _name;
            phone = _phone;
            gender = _gender;
            birthdate = _birthdate;
            luong = _luong;
            InitializeComponent();
        }

        private void LoadInfo()
        {
            lbID.Text = id.ToString();
            txtName.Text = name;
            txtPhone.Text = phone;
            dtpBirthDate.Value = birthdate;
            if (gender == "Nam") rdbNam.Checked = true;
            else if (gender == "Nữ") rdbNu.Checked = true;
            else rdbKhac.Checked = true;
            txtSalary.Text = luong.ToString();
        }
        private void FrmUpdateStaff_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
        public string getGender()
        {
            string gender1 = "Nam";
            if (rdbNu.Checked)
            {
                gender1 = "Nữ";
            }
            else if (rdbKhac.Checked)
            {
                gender1 = "Khác";
            }
            return gender1;
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
        public bool CheckNull(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                return true;
            }
            return false;
        }

        private bool CheckDigit(string integer)
        {
            string integerPattern = @"^(?!0\d)\d+$";
            return Regex.IsMatch(integer, integerPattern);
        }
        private async void btnUpdateAccep_Click(object sender, EventArgs e)
        {
            if (CheckNull(txtName))
            {
                SetError(txtName, "Không được bỏ trống Tên nhân viên");
                return;
            }
            else
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
            }
            else
            {
                SetError(txtPhone);
            }

            // check birthDate

            if (!CheckBirthDate(dtpBirthDate))
            {
                SetError(dtpBirthDate, "Ngày sinh không hợp lệ");
                return;
            }
            else
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
            staff.ID = int.Parse(lbID.Text);
            staff.Name = txtName.Text;
            staff.Phone = txtPhone.Text;
            staff.BirthDate = dtpBirthDate.Value;
            staff.Gender = getGender();
            staff.Salary = int.Parse(txtSalary.Text);
            int cnt = await staffbll.UpdateStaff(staff);
            if (cnt > 0)
            {
                MessageBox.Show("Update thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnExitFrm_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
