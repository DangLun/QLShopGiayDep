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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanlyShopGiayDep
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        BLLHome homebll = new BLLHome();
        private void LoadChart()
        {
            charProducts.Series["ChartProducts"].Points.AddXY("Giày", homebll.GetQuantityProductByType("giày"));
            charProducts.Series["ChartProducts"].Points.AddXY("Dép", homebll.GetQuantityProductByType("dép"));
            charProducts.Series["ChartProducts"].Points.AddXY("Phụ kiện", homebll.GetQuantityProductByType("phụ kiện"));

            ChartPrices.Series["ChartPrices"].Points.AddXY("2016", homebll.GetDoanhThuTheoNam(2016));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2017", homebll.GetDoanhThuTheoNam(2017));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2018", homebll.GetDoanhThuTheoNam(2018));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2019", homebll.GetDoanhThuTheoNam(2019));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2020", homebll.GetDoanhThuTheoNam(2020));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2021", homebll.GetDoanhThuTheoNam(2021));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2022", homebll.GetDoanhThuTheoNam(2022));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2023", homebll.GetDoanhThuTheoNam(2023));
            ChartPrices.Series["ChartPrices"].Points.AddXY("2024", homebll.GetDoanhThuTheoNam(2024));
            ChartPrices.Legends[0].Docking = Docking.Top;
            ChartPrices.Legends[0].Alignment = StringAlignment.Center;
        }

        private void LoadDataOrder()
        {
            int monthNow = DateTime.Now.Month;
            lbTotalOrderInMonth.Text = homebll.GetQuantityInvoiceInMonth(monthNow).ToString();
            lbTotalOrder.Text = homebll.GetQuantityInvoice().ToString();
        }

        private void LoadDataProduct()
        {
            int monthNow = DateTime.Now.Month;
            lbTotalproductinMonth.Text = homebll.GetQuantityBuyProductInMonth(monthNow).ToString();
            lbTotalProduct.Text = homebll.GetQuantityBuyProduct().ToString();
        }
        private void LoadDoanhThu()
        {
            int monthNow = DateTime.Now.Month;
            int dolaTongDoanhThu = homebll.GetDoanhThu() / 24000;
            int dolaDoanhThuMonth = homebll.GetDoanhThuInMonth(monthNow) / 24000;
            lbTotalDoanhThu.Text = "$" + dolaTongDoanhThu.ToString();
            lbTotalDoanhThuInMonth.Text = "$" + dolaDoanhThuMonth.ToString();
        }

        private void LoadDataCustomer()
        {
            int monthNow = DateTime.Now.Month;
            lbTotalCustomerInMonth.Text = homebll.GetQuantityCustomerInMonth(monthNow).ToString();
            lbTotalCustomer.Text = homebll.GetQuanTityCustomer().ToString();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadDataOrder();
            LoadDataProduct();
            LoadDoanhThu();
            LoadDataCustomer();
        }
    }
}
