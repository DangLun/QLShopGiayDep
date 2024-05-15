using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanlyShopGiayDep.Forms
{
    public partial class FrmUpdateProduct : Form
    {
        private string NameProduct = "", NameBrand = "", NameType = "";
        private int Price = -1, Discount = -1;
        int id = -1;
        List<object[]> Sizes = new List<object[]>();
        BLLBrand DataBrand = new BLLBrand();
        BLLTypeProduct DataTypeProduct = new BLLTypeProduct();
        BLLProduct DataProduct = new BLLProduct();
        public FrmUpdateProduct()
        {
            InitializeComponent();
        }
        public FrmUpdateProduct(int _id, string _Name, int _Price, int _Discount, string _NameBrand, string _NameType)
        {
            id = _id;
            NameProduct = _Name;
            Price = _Price;
            Discount = _Discount;
            NameBrand = _NameBrand;
            NameType = _NameType;
            InitializeComponent();
        }

        private void ShowQuantity(CheckBox chb, NumericUpDown nbr, int value)
        {
            chb.Checked = true;
            nbr.Value = value;
        }

        private void ShowSize(int size, int quantity)
        {
            switch (size)
            {
                case 33:
                    ShowQuantity(chb33, nbr33, quantity);
                    break;
                case 34:
                    ShowQuantity(chb34, nbr34, quantity);
                    break;
                case 35:
                    ShowQuantity(chb35, nbr35, quantity);
                    break;
                case 36:
                    ShowQuantity(chb36, nbr36, quantity);
                    break;
                case 37:
                    ShowQuantity(chb37, nbr37, quantity);
                    break;
                case 38:
                    ShowQuantity(chb38, nbr38, quantity);
                    break;
                case 39:
                    ShowQuantity(chb39, nbr39, quantity);
                    break;
                case 40:
                    ShowQuantity(chb40, nbr40, quantity);
                    break;
                case 41:
                    ShowQuantity(chb41, nbr41, quantity);
                    break;
                case 42:
                    ShowQuantity(chb42, nbr42, quantity);
                    break;
                case 43:
                    ShowQuantity(chb43, nbr43, quantity);
                    break;
                case 44:
                    ShowQuantity(chb44, nbr44, quantity);
                    break;
            }
        }

        private void GetSizes()
        {
            if (NameType.ToLower() == "phụ kiện") return;
            DataTable dt = new DataTable();
            dt = DataProduct.LoadDetailProduct(id);
            foreach (DataRow row in dt.Rows)
            {
                int size = int.Parse(row[2].ToString());
                int soluong = int.Parse(row[1].ToString());
                object[] info = new object[2];
                info[0] = soluong;
                info[1] = size;
                Sizes.Add(info);
            }
        }
        
        private void LoadSizes()
        {
            foreach(object[] item in Sizes)
            {
                int soluong = int.Parse(item[0].ToString());
                int size = int.Parse(item[1].ToString());
                ShowSize(size, soluong);
            }
        }

        private void LoadBrandComboBox()
        {
            DataTable data = new DataTable();
            data = DataBrand.LoadBrand();
            cmbBrandProduct.DataSource = data;
            cmbBrandProduct.ValueMember = "ID";
            cmbBrandProduct.DisplayMember = "Name";
            cmbBrandProduct.SelectedIndex = 0;
        }
        private void LoadTypeComboBox()
        {
            DataTable data = new DataTable();
            data = DataTypeProduct.LoadType();
            cmbTypeProduct.DataSource = data;
            cmbTypeProduct.ValueMember = "ID";
            cmbTypeProduct.DisplayMember = "Name";
            cmbTypeProduct.SelectedIndex = 0;
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            Rotate();
        }
        private void resetForm()
        {
            txtNameProduct.Text = "";
            txtPriceProduct.Text = "";
            txtDiscountProduct.Text = "";
            cmbBrandProduct.SelectedIndex = 0;
            cmbTypeProduct.SelectedIndex = 0;
            chb33.Checked = false;
            chb34.Checked = false;
            chb35.Checked = false;
            chb36.Checked = false;
            chb37.Checked = false;
            chb38.Checked = false;
            chb39.Checked = false;
            chb40.Checked = false;
            chb41.Checked = false;
            chb42.Checked = false;
            chb43.Checked = false;
            chb44.Checked = false;
            nbr33.Value = 1;
            nbr34.Value = 1;
            nbr35.Value = 1;
            nbr36.Value = 1;
            nbr37.Value = 1;
            nbr38.Value = 1;
            nbr39.Value = 1;
            nbr40.Value = 1;
            nbr41.Value = 1;
            nbr42.Value = 1;
            nbr43.Value = 1;
            nbr44.Value = 1;
            txtNameProduct.Focus();
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void ThongBaoLuu()
        {
            MessageBox.Show("Lưu thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNameProduct.Focus();
        }
        private int getSize(CheckBox chb)
        {
            string name = chb.Text;
            int size = int.Parse(name);
            return size;
        }
        private object[] getSizeAndQuantityByCheckBox(CheckBox chb, NumericUpDown nbr)
        {
            object[] sizeQuantity = null;
            if (chb.Checked)
            {
                sizeQuantity = new object[2];
                sizeQuantity[0] = getSize(chb);
                sizeQuantity[1] = nbr.Value;
            }
            return sizeQuantity;
        }
        public bool CheckNull(TextBox obj, string title)
        {
            if (string.IsNullOrEmpty(obj.Text))
            {
                MessageBox.Show("Không được để trống " + title + " sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                obj.Focus();
                return true;
            }
            return false;
        }
        public bool CheckDigit(TextBox obj, string title)
        {
            for (int i = 0; i < obj.Text.Length; i++)
            {
                if (obj.Text[i] < '0' || obj.Text[i] > '9')
                {
                    MessageBox.Show(title + " không được chứa kí tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    obj.Focus();
                    return true;
                }
            }
            return false;
        }
        public bool FrmValidate()
        {
            if (CheckNull(txtNameProduct, "Tên")) return false;
            if (CheckNull(txtPriceProduct, "Giá")) return false;
            if (CheckNull(txtDiscountProduct, "Khuyến mãi")) return false;
            if (CheckDigit(txtPriceProduct, "Giá")) return false;
            if (CheckDigit(txtDiscountProduct, "Khuyến mãi")) return false;
            return true;
        }
        private bool SaveUpdate()
        {
            if (FrmValidate())
            {
                ProductModel product = new ProductModel();
                product.Id = id;
                product.Name = txtNameProduct.Text;
                product.Price = int.Parse(txtPriceProduct.Text);
                product.Discount = int.Parse(txtDiscountProduct.Text);
                product.ID_Brand = int.Parse(cmbBrandProduct.SelectedValue.ToString());
                product.ID_Type = int.Parse(cmbTypeProduct.SelectedValue.ToString());
                List<object[]> infoSize = new List<object[]>();
                object[] s33 = getSizeAndQuantityByCheckBox(chb33, nbr33);
                object[] s34 = getSizeAndQuantityByCheckBox(chb34, nbr34);
                object[] s35 = getSizeAndQuantityByCheckBox(chb35, nbr35);
                object[] s36 = getSizeAndQuantityByCheckBox(chb36, nbr36);
                object[] s37 = getSizeAndQuantityByCheckBox(chb37, nbr37);
                object[] s38 = getSizeAndQuantityByCheckBox(chb38, nbr38);
                object[] s39 = getSizeAndQuantityByCheckBox(chb39, nbr39);
                object[] s40 = getSizeAndQuantityByCheckBox(chb40, nbr40);
                object[] s41 = getSizeAndQuantityByCheckBox(chb41, nbr41);
                object[] s42 = getSizeAndQuantityByCheckBox(chb42, nbr42);
                object[] s43 = getSizeAndQuantityByCheckBox(chb43, nbr43);
                object[] s44 = getSizeAndQuantityByCheckBox(chb44, nbr44);

                if (s33 != null) infoSize.Add(s33);
                if (s34 != null) infoSize.Add(s34);
                if (s35 != null) infoSize.Add(s35);
                if (s36 != null) infoSize.Add(s36);
                if (s37 != null) infoSize.Add(s37);
                if (s38 != null) infoSize.Add(s38);
                if (s39 != null) infoSize.Add(s39);
                if (s40 != null) infoSize.Add(s40);
                if (s41 != null) infoSize.Add(s41);
                if (s42 != null) infoSize.Add(s42);
                if (s43 != null) infoSize.Add(s43);
                if (s44 != null) infoSize.Add(s44);
                product.Sizes = infoSize;
                int row_effect = DataProduct.UpdateProduct(product);
                ThongBaoLuu();
                return true;
            }
            return false;
        }
        private void btnUpdateAccep_Click(object sender, EventArgs e)
        {
            if (SaveUpdate()) this.Close();
        }
        private bool CheckNoDigit(TextBox obj)
        {
            for (int i = 0; i < obj.Text.Length; i++)
            {
                if (obj.Text[i] < '0' || obj.Text[i] > '9')
                {
                    return true;
                }
            }
            return false;
        }
        private bool EqualData()
        {
            DataTable data = new DataTable();
            data = DataProduct.SelectProductByID(id);
            string newName = txtNameProduct.Text;
            int newPrice = 0;
            if (txtPriceProduct.Text != "" && !CheckNoDigit(txtPriceProduct))
            {
                newPrice = int.Parse(txtPriceProduct.Text);
            }
            int newDiscount = 0;
            if (txtDiscountProduct.Text != "" && !CheckNoDigit(txtDiscountProduct))
            {
                newDiscount = int.Parse(txtDiscountProduct.Text);
            }
            int newID_Brand = 0;
            if (cmbBrandProduct.SelectedValue.ToString() != "")
            {
                newID_Brand = int.Parse(cmbBrandProduct.SelectedValue.ToString());
            }
            int newID_Type = 0;
            if (cmbTypeProduct.SelectedValue.ToString() != "")
            {
                newID_Type = int.Parse(cmbTypeProduct.SelectedValue.ToString());
            }
            DataRow row = data.Rows[0];
            return !(newName != row["Name"].ToString() || newPrice != int.Parse(row["Price"].ToString())
               || newDiscount != int.Parse(row["Discount"].ToString()) || newID_Brand != int.Parse(row["ID_Brand"].ToString())
               || newID_Type != int.Parse(row["ID_Type"].ToString())
            );
        }
        private void FrmUpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool equal = EqualData();
            if (!equal)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    SaveUpdate();
                    e.Cancel = false;
                } else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                } else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExitFrmUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cmbTypeProduct.GetItemText(cmbTypeProduct.SelectedItem);
            SetGroupBox(key);
        }

        private void SetGroupBox(string key)
        {
            if (key.ToLower() == "phụ kiện")
            {
                grbSize.Enabled = false;
            }else
            {
                grbSize.Enabled = true;
            }
        }
        private void SetSize(CheckBox chb, NumericUpDown nbr)
        {
            if (chb.Checked)
            {
                nbr.Enabled = true;
            }
            else
            {
                nbr.Enabled = false;
            }
        }
        private void chb37_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb37, nbr37);
        }

        private void chb34_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb34, nbr34);
        }

        private void chb35_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb35, nbr35);
        }

        private void chb36_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb36, nbr36);
        }

        private void chb33_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb33, nbr33);
        }

        private void chb38_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb38, nbr38);
        }

        private void chb39_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb39, nbr39);
        }

        private void chb40_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb40, nbr40);
        }

        private void chb41_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb41, nbr41);
        }

        private void chb42_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb42, nbr42);
        }

        private void chb43_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb43, nbr43);
        }

        private void chb44_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(chb44, nbr44);
        }

        private void Rotate()
        {
            lbID.Text = id.ToString();
            txtNameProduct.Text = NameProduct;
            txtPriceProduct.Text = Price.ToString();
            txtDiscountProduct.Text = Discount.ToString();
            cmbBrandProduct.Text = NameBrand;
            cmbTypeProduct.Text = NameType;
            LoadSizes();
        }
        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            LoadBrandComboBox();
            LoadTypeComboBox();
            GetSizes();
            Rotate();
            SetGroupBox(NameType);
        }
        
    }
}
