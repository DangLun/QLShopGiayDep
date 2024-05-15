using QuanlyShopGiayDep.BLL;
using QuanlyShopGiayDep.DTO;
using QuanlyShopGiayDep.Forms.Customer;
using QuanlyShopGiayDep.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyShopGiayDep.Forms.Order
{
    public partial class FrmThanhToan : Form
    {
        
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        private FrmTichDiem FrmTichDiem;
        private FrmDoiDiem FrmDoiDiem;
        private int IDNV = -1;
        private List<object[]> ListInfoProduct = new List<object[]>();
        private int sumPrice = 0;
        private string nameCustomer = "";
        private string sdtCustomer = "";
        BLLCustomer customerbll = new BLLCustomer();
        BLLInvoice invoicebll = new BLLInvoice();
        BLLInvoiceDetail invoicedetailbll = new BLLInvoiceDetail();
        private int IDCustomer = -1;
        private int currentscore = 0; 
        private bool is_tichdiem = true;
        private int sotienconlai = 0;
        private bool is_Thanhtoan = false;
        public FrmThanhToan(int idnv, int _sumPrice, List<object[]> _ListInfoProduct)
        {
            InitializeComponent();
            IDNV = idnv;
            ListInfoProduct = _ListInfoProduct;
            sumPrice = _sumPrice;
        }
        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            lbSumPrice.Text = sumPrice.ToString();
            lbNameCustomer.Text = nameCustomer.ToString();
            lbSDTCustomer.Text = sdtCustomer.ToString();
        }

        private void nbrTienNhan_ValueChanged(object sender, EventArgs e)
        {
            int tiennhan = 0;
            int tongtien = sumPrice;
            int tienthua = sumPrice;
            if(string.IsNullOrEmpty(nbrTienNhan.Value.ToString()))
            {
                tiennhan = 0;
            }
            else
            {
                tiennhan = int.Parse(nbrTienNhan.Value.ToString());
            }
            tienthua = tongtien - tiennhan;
            lbTienThua.Text = tienthua.ToString();
        }
        
        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            FrmTichDiem = new FrmTichDiem(sumPrice);
            FrmTichDiem.ShowDialog();
            is_tichdiem = true;
            int IDCurrentCustomer = FrmTichDiem.getIDCustomer();
            SetCustomer(IDCurrentCustomer);
        }

        private void SetCustomer(int id)
        {
            if (id == -1) return;
            DataTable dt = customerbll.GetDataCustomerByID(id);
            string name = dt.Rows[0]["Name"].ToString();
            string phone = dt.Rows[0]["Phone"].ToString();
            lbNameCustomer.Text = name;
            lbSDTCustomer.Text = phone;
            IDCustomer = id;
        }

        private void btnFinishInvoice_Click(object sender, EventArgs e)
        {
            DateTime CreaDate = DateTime.Now;
            int r = invoicebll.InsertInvoice(CreaDate, IDCustomer, IDNV);
            if (r > 0)
            {
                int idinvoice = invoicebll.GetIDInvoiceMax();
                foreach (object[] item in ListInfoProduct)
                {
                    if (item[0] != null && item[1] != null && item[2] != null)
                    {
                        InvoiceDetailModel invoiceDetailModel = new InvoiceDetailModel();
                        invoiceDetailModel.IDInvoice = idinvoice;
                        invoiceDetailModel.IDProduct = int.Parse(item[0].ToString());
                        invoiceDetailModel.BuyQuantity = int.Parse(item[1].ToString());
                        invoiceDetailModel.Size = int.Parse(item[2].ToString());
                        invoicedetailbll.InsertInvoiceDetail(invoiceDetailModel);
                    }
                }
                if (is_tichdiem)
                {
                    customerbll.UpdateScoreCustomer(IDCustomer, sumPrice/100000, 'C');
                }else
                {
                    customerbll.UpdateScoreCustomer(IDCustomer, currentscore, 'T');
                }
                MessageBox.Show("Thanh Toán thành công !", "Thông báo");
                is_Thanhtoan = true;
                this.Close();
            }
        }
        public bool IsThanhtoan()
        {
            return is_Thanhtoan;
        }
        private void btnDoiDiem_Click(object sender, EventArgs e)
        {
            FrmDoiDiem = new FrmDoiDiem(sumPrice);
            FrmDoiDiem.ShowDialog();
            is_tichdiem = false;
            bool is_doidiem = FrmDoiDiem.IsDoidiem();
            if (is_doidiem)
            {
                sotienconlai = FrmDoiDiem.getPriceConLai();
                currentscore = FrmDoiDiem.GetScoreCurrentScore();
                lbSumPrice.Text = sotienconlai.ToString();
                int IDCurrentCustomer = FrmDoiDiem.getIDCustomer();
                SetCustomer(IDCurrentCustomer);
            }
        }
    }
}
