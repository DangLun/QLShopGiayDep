using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DTO;
using QuanlyShopGiayDep.Forms.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms
{
    public partial class FrmAddOrder : Form
    {
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        BLLInvoice invoicebll = new BLLInvoice();
        BLLProduct productbll = new BLLProduct();   
        private bool isInitializing = true;
        private int curSTT = 1;
        private int current_row = -1;
        private string Username = "";
        public FrmAddOrder(string _username)
        {
            InitializeComponent();
            Username = _username;
        }
        private DataTable GetTableStaffsByUsername(string username)
        {
            return invoicebll.GetTableStaffsByUsername(username);
        }


        private int GetIDNVByUsername(string username)
        {
            DataTable dt = new DataTable();
            dt = GetTableStaffsByUsername(username);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private string GetNameStaffByUserName(string username)
        {
            DataTable dt = new DataTable();
            dt = GetTableStaffsByUsername(username);
            return dt.Rows[0]["Name"].ToString();
        }
        private void LoadDataComboBox()
        {
            DataTable dt = new DataTable();
            dt = invoicebll.LoadDataOnAddOrder();
            cmbListProduct.DataSource = dt;
            cmbListProduct.ValueMember = "ID";
            cmbListProduct.DisplayMember = "Name";
        }

        private void LoadSizeByID(int id)
        {
            DataTable dt = new DataTable();
            dt = invoicebll.LoadSizeByID(id);
            cmbSize.DataSource = dt;
            cmbSize.ValueMember = "Size";
            cmbSize.DisplayMember = "Size";
        }
        private void LoadSizeAndCheck(int id)
        {
            int idtype = invoicebll.GetTypeProductByID(id);
            if (idtype == -1 || idtype == 3)
            {
                cmbSize.Enabled = false;
                return;
            }
            LoadSizeByID(id);
        }

        private void LoadData()
        {
            lbDayNow.Text = DateTime.Now.ToString();
            lbNamestaff.Text = GetNameStaffByUserName(Username);
        }
        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            LoadDataComboBox();
            LoadData();
            isInitializing = false;
            cmbListProduct.SelectedIndex = 0;
            if (cmbListProduct.Items.Count == 0)
            {
                cmbSize.Enabled = false;
            }
            else
            {
                cmbSize.Enabled = true;
                int id = int.Parse(cmbListProduct.SelectedValue.ToString());
                LoadSizeAndCheck(id);
            }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                cmbSize.DataSource = null;
                if (cmbListProduct.Items.Count == 0)
                {
                    cmbSize.Enabled = false;
                }
                else
                {
                    cmbSize.Enabled = true;
                    int id = int.Parse(cmbListProduct.SelectedValue.ToString());
                    LoadSizeAndCheck(id);
                    if (cmbSize.Items.Count == 0) cmbSize.Enabled = false;
                }
            }

        }

        private int GetPriceByIDProduct(int id)
        {
            return invoicebll.GetPriceByIDProduct(id);
        }

        private int GetQuanTityBySizeAndIDProduct(int id, int size)
        {
            DataTable dt = new DataTable();
            dt = invoicebll.GetQuanTityBySizeAndIDProduct(id, size);
            return int.Parse(dt.Rows[0]["Quantity"].ToString());
        }

        private int GetQuantityPhuKien(int id)
        {
            return invoicebll.GetQuantityPhuKienByIDProduct(id);
        }

        private int CheckValidProduct(int idProduct, int size)
        {
            if (size == -1)
            {
                foreach (DataGridViewRow item in dgvInvoice.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        int id = int.Parse(item.Cells[0].Value.ToString());
                        if (id == idProduct) return int.Parse(item.Cells[4].Value.ToString());
                    }
                }
            }else
            {
                foreach (DataGridViewRow item in dgvInvoice.Rows)
                {
                    if (item.Cells[0].Value != null && item.Cells[1].Value != null)
                    {
                        int id = int.Parse(item.Cells[0].Value.ToString());
                        int Size = int.Parse(item.Cells[1].Value.ToString());
                        if (id == idProduct && Size == size) return int.Parse(item.Cells[4].Value.ToString());
                    }
                }
            }
            return -1;
        }
        private void UpdateRowInvoice(InvoiceAddModel invoice)
        {
            int id_product = invoice.ID;
            int CurSize = invoice.SizeProduct;
            int Price = invoice.Price;
            int quantity = invoice.Quantity;
            int discount = invoice.Discount;
            int sumPrice = quantity * (Price - (Price * discount / 100));

            if(CurSize == -1)
            {
                foreach (DataGridViewRow item in dgvInvoice.Rows)
                {
                    if (int.Parse(item.Cells[0].Value.ToString()) == id_product)
                    {
                        item.Cells[1].Value = CurSize;
                        item.Cells[4].Value = quantity;
                        item.Cells[7].Value = sumPrice;
                        return;
                    }
                }
            }else
            {
                foreach (DataGridViewRow item in dgvInvoice.Rows)
                {
                    if (int.Parse(item.Cells[0].Value.ToString()) == id_product && int.Parse(item.Cells[1].Value.ToString()) == CurSize)
                    {
                        item.Cells[4].Value = quantity;
                        item.Cells[7].Value = sumPrice;
                        return;
                    }
                }
            }
        }
        private void InsertRowInvoice(InvoiceAddModel invoice)
        {
            int id_product = invoice.ID;
            int stt = invoice.STT;
            int size = invoice.SizeProduct;
            int Price = invoice.Price;
            string name_product = invoice.NameProduct;
            int quantity = invoice.Quantity;
            int discount = invoice.Discount;
            int sumPrice = quantity * (Price - (Price * discount / 100));
            if (!cmbSize.Enabled)
            {
                if (GetQuantityPhuKien(id_product) < quantity)
                {
                    MessageBox.Show("Số lượng hiện tại trong kho không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (GetQuanTityBySizeAndIDProduct(id_product, size) < quantity)
                {
                    MessageBox.Show("Số lượng hiện tại trong kho không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvInvoice);
            row.Cells[0].Value = id_product;
            row.Cells[1].Value = size;
            row.Cells[2].Value = stt;
            row.Cells[3].Value = name_product;
            row.Cells[4].Value = quantity;
            row.Cells[5].Value = Price;
            row.Cells[6].Value = discount;
            row.Cells[7].Value = sumPrice;
            dgvInvoice.Rows.Add(row);
        }
        private void PushToInvoice()
        {
            int id_product = int.Parse(cmbListProduct.SelectedValue.ToString());
            int Price = GetPriceByIDProduct(id_product);
            string name_product = ((DataRowView)cmbListProduct.SelectedItem)["Name"].ToString();
            int quantity = int.Parse(nbrQuantity.Value.ToString());
            int size = -1;
            if (cmbSize.Enabled)
            {
                size = int.Parse(cmbSize.SelectedValue.ToString());
                name_product += ", S: " + size.ToString();
            }
            else
            {
                name_product += " (Phụ Kiện)";
            }
            int cur_quantity = CheckValidProduct(id_product, size);
            int discount = invoicebll.GetDiscountByIDProduct(id_product);
            InvoiceAddModel invoice = new InvoiceAddModel();
            invoice.ID = id_product;
            invoice.STT = curSTT;
            invoice.SizeProduct = size;
            invoice.NameProduct = name_product;
            invoice.Price = Price;
            invoice.Discount = discount;
            invoice.Quantity = quantity;
            if (cur_quantity != -1)
            {
                invoice.Quantity += cur_quantity;
                UpdateRowInvoice(invoice);
                return;
            }
            InsertRowInvoice(invoice);
            curSTT++;
        }
        private int GetPriceTotal()
        {
            int tongtien = 0;
            foreach (DataGridViewRow item in dgvInvoice.Rows)
            {
                if (item.Cells[7].Value != null)
                    tongtien += int.Parse(item.Cells[7].Value.ToString());
            }
            return tongtien;
        }
        private void setSTTWhenDeleteRow()
        {
            curSTT--;
            int t = 1;
            for(int i = 0; i< dgvInvoice.Rows.Count - 1; i++) {
                dgvInvoice[2, i].Value = t++;
            }
        }
        private void SetPriceTotal()
        {
            int tongtien = GetPriceTotal();
            txtSumPrice.Text = tongtien.ToString("N0", new CultureInfo("vi-VN"));
        }
        private void btnAddItemOrder_Click(object sender, EventArgs e)
        {
            PushToInvoice();
            SetPriceTotal();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_row = e.RowIndex;
            btnDeleteInvoice.Enabled = true;
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (current_row == -1)
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn vẫn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                dgvInvoice.Rows.RemoveAt(current_row);
                SetPriceTotal();
                setSTTWhenDeleteRow();
            }
        }


        private void ThanhToan()
        {
            int IDNV = GetIDNVByUsername(Username);
            List<object[]> ListInfoProduct = new List<object[]>();
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                object[] item = new object[3];
                item[0] = row.Cells[0].Value;
                item[1] = row.Cells[4].Value;
                item[2] = row.Cells[1].Value;
                ListInfoProduct.Add(item);
            }
            int sumPrice = GetPriceTotal();
            FrmThanhToan frmThanhToan = new FrmThanhToan(IDNV, sumPrice, ListInfoProduct);
            frmThanhToan.ShowDialog();
            bool is_thanhtoan = frmThanhToan.IsThanhtoan();
            if (is_thanhtoan)
            {
                this.Close();
            }
        }
        private bool checkRowInvoice()
        {
            return dgvInvoice.Rows.Count > 1;
        }

        //private bool checkQuantity(int id, int value)
        //{
        //    int quantity = 0;
        //    if(!cmbSize.Enabled)
        //    {
        //        quantity = productbll.getQuantityProductByID(id);
        //        return quantity >= value;
        //    }
        //    int size = int.Parse(cmbSize.SelectedValue.ToString());
        //    quantity = productbll.getQuantityProductByIDAndSize(id, size);
        //    return quantity >= value;
        //}
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //int id  = int.Parse(cmbListProduct.SelectedValue.ToString());
            //int value = int.Parse(nbrQuantity.Value.ToString());
            if (!checkRowInvoice())
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm vào hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThanhToan();
            
        }
    }
}
