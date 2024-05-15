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

namespace QuanlyShopGiayDep.Forms.Product
{
    public partial class FrmViewDetailProduct : Form
    {
        public FrmViewDetailProduct()
        {
            InitializeComponent();
        }
        int id;
        string name;
        BLLProduct productbll = new BLLProduct();
        public FrmViewDetailProduct(int _id, string _name)
        {
            id = _id;
            name = _name;
            InitializeComponent();
        }

        private void SetSTT(int startSTT = 1)
        {
            for(int i = 0; i< dgvDetailProducts.Rows.Count-1; i++) {
                dgvDetailProducts.Rows[i].Cells[0].Value = startSTT++;
            }
        }
        private void LoadData()
        {
            lbID.Text = id.ToString();
            lbName.Text = name;
            dgvDetailProducts.AutoGenerateColumns = false;
            dgvDetailProducts.DataSource = productbll.LoadDetailProduct(id);
            SetSTT();
        }
        private void FrmViewDetailProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
