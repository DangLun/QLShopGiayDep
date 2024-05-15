using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms
{
    public partial class FrmAddProduct : Form
    {
        BLLBrand DataBrand = new BLLBrand();
        BLLTypeProduct DataTypeProduct = new BLLTypeProduct();
        BLLProduct DataProduct = new BLLProduct();
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void btnExitFrmAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            LoadBrandComboBox();
            LoadTypeComboBox();
        }
        public void resetForm()
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
        public bool CheckNull(TextBox obj, string title)
        {
            if (string.IsNullOrEmpty(obj.Text)){
                MessageBox.Show("Không được để trống "+title+" sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                obj.Focus();
                return true;
            }
            return false;
        }
        public bool CheckDigit(TextBox obj, string title)
        {
            for(int i = 0; i< obj.Text.Length; i++)
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
            if(CheckNull(txtPriceProduct, "Giá")) return false;
            if(CheckNull(txtDiscountProduct, "Khuyến mãi")) return false;
            if (CheckDigit(txtPriceProduct, "Giá")) return false;
            if (CheckDigit(txtDiscountProduct, "Khuyến mãi")) return false;
            return true;
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

        private void btnAddAccep_Click(object sender, EventArgs e)
        {
            if (FrmValidate())
            {
                ProductModel product = new ProductModel();
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

                if(s33 != null) infoSize.Add(s33);
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

                int row_effected = DataProduct.AddProduct(product);
                if (row_effected > 0)
                {
                    MessageBox.Show("Thêm Sản Phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnAddByQR_Click(object sender, EventArgs e)
        {
            FrmScanQR frmScanQR = new FrmScanQR();
            frmScanQR.ShowDialog();
        }

        private void cmbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTypeProduct.SelectedIndex == 2)
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
            }else
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
    }
}
