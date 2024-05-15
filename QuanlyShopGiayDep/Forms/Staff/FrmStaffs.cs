using OfficeOpenXml;
using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.Forms;
using QuanlyShopGiayDep.Forms.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanlyShopGiayDep
{
    public partial class FrmStaffs : Form
    {
        BLLStaff staffbll = new BLLStaff();
        int current_Row = -1;
        public FrmStaffs()
        {
            InitializeComponent();
        }
        private void CapQuyenExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        private void LoadComboBox()
        {
            foreach (DataGridViewColumn column in dgvStaffs.Columns)
            {
                if(column.HeaderText.ToLower() == "ngày sinh")
                {
                    cmbStaffType.Items.Add("Ngày Sinh");
                    cmbStaffType.Items.Add("Tháng Sinh");
                    cmbStaffType.Items.Add("Năm Sinh");
                }else
                {
                    cmbStaffType.Items.Add(column.HeaderText);
                }
            }
            cmbStaffType.SelectedIndex = 0;
        }
        private async Task LoadDataGridView()
        {
            //DataTable data = new DataTable();
            //data = staffbll.LoadData();
            //dgvStaffs.DataSource = data;
            dgvStaffs.AutoGenerateColumns = false;
            dgvStaffs.DataSource = await staffbll.LoadData();
        }
        public async Task LoadData()
        {
            await LoadDataGridView();
            LoadComboBox();
        }
        private async void FrmStaffs_Load(object sender, EventArgs e)
        {
            await LoadData();
            CapQuyenExcel();
        }

        private async void btnAddStaff_Click(object sender, EventArgs e)
        {
            FrmAddStaff frm = new FrmAddStaff();
            frm.ShowDialog();
            await LoadDataGridView();
        }

        private async void btnDropStaff_Click(object sender, EventArgs e)
        {
            if (current_Row == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(dgvStaffs.Rows[current_Row].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show($"Bạn thật sự muốn xóa nhân viên có mã: {id}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int row_effect = await staffbll.RemoveStaff(id);

                if (row_effect >= 0)
                {
                    MessageBox.Show($"Xóa thành công nhân viên có mã: {id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_Row = e.RowIndex;
        }
        private void ExportExcel(DataGridView data, string name)
        {
            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("Dữ liệu");
                for (int i = 0; i < data.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1].Value = data.Columns[i].HeaderText;
                }
                for (int i = 0; i < data.RowCount; i++)
                {
                    for (int j = 0; j < data.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = data.Rows[i].Cells[j].Value;
                    }
                }
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = name + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelPackage.SaveAs(new FileStream(saveFileDialog.FileName, FileMode.Create));
                    MessageBox.Show("Xuất file Excel thành công!");
                }
            }
        }
        private void btnExportExcelStaffs_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvStaffs, "Staffs");
        }

        private async void btnEditStaff_Click(object sender, EventArgs e)
        {
            if(current_Row == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(dgvStaffs.Rows[current_Row].Cells[0].Value.ToString());
            string name = dgvStaffs.Rows[current_Row].Cells[1].Value.ToString();
            string phone = dgvStaffs.Rows[current_Row].Cells[2].Value.ToString();
            DateTime birthdate = (DateTime)dgvStaffs.Rows[current_Row].Cells[3].Value;
            string gender = dgvStaffs.Rows[current_Row].Cells[4].Value.ToString();
            int salary = int.Parse(dgvStaffs.Rows[current_Row].Cells[5].Value.ToString());

            FrmUpdateStaff frmUpdateStaff = new FrmUpdateStaff(id, name, phone, birthdate, gender, salary);
            frmUpdateStaff.ShowDialog();
            await LoadDataGridView();
        }

        private async void txtInputSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string SearchInput = txtInputSearchStaff.Text;
            string tieuchi = cmbStaffType.SelectedItem.ToString();
            if (string.IsNullOrEmpty(SearchInput))
            {
                await LoadDataGridView();
                return;
            }
            dgvStaffs.AutoGenerateColumns = false;
            dgvStaffs.DataSource = await staffbll.SearchByType(tieuchi, SearchInput);
        }
    }
}
