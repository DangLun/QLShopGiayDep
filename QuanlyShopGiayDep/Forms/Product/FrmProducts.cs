using OfficeOpenXml;
using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.Forms;
using QuanlyShopGiayDep.Forms.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanlyShopGiayDep
{
    public partial class FrmProducts : Form
    {

        int current_Row = -1;
        BLLProduct DataProduct = new BLLProduct();
        public FrmProducts()
        {
            InitializeComponent();
        }
        private void CapQuyenExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        public void LoadData()
        {
            DataTable data = new DataTable();
            data = DataProduct.LoadData();
            dgvProducts.DataSource = data;
            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                cmbProductType.Items.Add(column.HeaderText);
            }
            cmbProductType.SelectedIndex = 0;
        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadData();
            CapQuyenExcel();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog();
            LoadData();
        }
        public bool is_digit(string input)
        {
            foreach (var item in input)
            {
                if (item < '0' || item > '9') return false;
            }
            return true;
        }
        private void txtInputSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string SearchInput = txtInputSearchProduct.Text;
            string tieuchi = cmbProductType.SelectedItem.ToString();
            DataTable data;
            if (string.IsNullOrEmpty(SearchInput))
            {
                data = DataProduct.LoadData();
                dgvProducts.DataSource = data;
                return;
            }
            if (tieuchi == "ID" && !is_digit(SearchInput)) return;
            if (tieuchi == "Đơn Giá" && !is_digit(SearchInput)) return;
            if (tieuchi == "Khuyến Mãi" && !is_digit(SearchInput)) return;
            if (tieuchi == "Số lượng" && !is_digit(SearchInput)) return;
            data = DataProduct.SearchProductByTypesearch(tieuchi, SearchInput);
            dgvProducts.DataSource = data;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_Row = e.RowIndex;
        }
        
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(current_Row == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(dgvProducts.Rows[current_Row].Cells[0].Value.ToString());
            string name = dgvProducts.Rows[current_Row].Cells[1].Value.ToString();
            int price = int.Parse(dgvProducts.Rows[current_Row].Cells[2].Value.ToString());
            int discount = int.Parse(dgvProducts.Rows[current_Row].Cells[4].Value.ToString());
            int soluong = int.Parse(dgvProducts.Rows[current_Row].Cells[3].Value.ToString());
            string name_brand = dgvProducts.Rows[current_Row].Cells[6].Value.ToString();
            string name_type = dgvProducts.Rows[current_Row].Cells[5].Value.ToString();
            
            FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct(id, name, price, discount, name_brand, name_type);
            frmUpdateProduct.ShowDialog();
            LoadData();
        }

        private void btnDropProduct_Click(object sender, EventArgs e)
        {
            if (current_Row == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(dgvProducts.Rows[current_Row].Cells[0].Value.ToString());
            if(MessageBox.Show("Bạn thật sự muốn xóa " + id.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int row_effect = 0;
                row_effect = DataProduct.DeleteProductByID(id);
                if(row_effect > 0)
                {
                    MessageBox.Show("Xóa thành công " + id.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
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
        private void btnExportExcelProducts_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvProducts, "ListProduct");
        }

        private void btnViewDetailProduct_Click(object sender, EventArgs e)
        {
            if (current_Row == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(dgvProducts.Rows[current_Row].Cells[0].Value.ToString());
            string name = dgvProducts.Rows[current_Row].Cells[1].Value.ToString();
            FrmViewDetailProduct frmview = new FrmViewDetailProduct(id, name);
            frmview.ShowDialog();
        }
    }
}
