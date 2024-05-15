using QuanlyShopGiayDep.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLHome
    {
        HomeDAL homedal = new HomeDAL();
        public int GetQuantityInvoice()
        {
            return homedal.GetQuantityInvoice();    
        }

        public int GetQuantityInvoiceInMonth(int month)
        {
            return homedal.GetQuantityInvoiceInMonth(month);
        }

        public int GetQuantityBuyProduct()
        {
            return homedal.GetQuantityBuyProduct();
        }

        public int GetQuantityBuyProductInMonth(int month)
        {
            return homedal.GetQuantityBuyProductInMonth(month);
        }
        public int GetDoanhThu()
        {
            return homedal.GetDoanhThu();
        }

        public int GetDoanhThuInMonth(int month)
        {
            return homedal.GetDoanhThuInMonth(month);
        }
        public int GetQuanTityCustomer()
        {
            return homedal.GetQuanTityCustomer();
        }

        public int GetQuantityCustomerInMonth(int month)
        {
            return homedal.GetQuantityCustomerInMonth(month);
        }

        public int GetQuantityProductByType(string type)
        {
            return homedal.GetQuantityProductByType(type);
        }
        public int GetDoanhThuTheoNam(int year)
        {
            return homedal.GetDoanhThuTheoNam(year);
        }
    }
}
