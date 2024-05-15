using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLInvoice
    {
       InvoiceDAL invoiceDAL = new InvoiceDAL();
        //public List<InvoiceModel> LoadData()
        //{
        //    return invoiceDAL.LoadData();
        //}
        public DataTable LoadData()
        {
            return invoiceDAL.LoadData();
        }


        public List<InvoiceModel> SearchByType(string type, string input)
        {
            return invoiceDAL.SearchByType(type, input);
        }


        public int RemoveInvoice(int id)
        {
            return invoiceDAL.RemoveInvoice(id);
        }


        //public List<ProductModel> LoadDataOnAddOrder()
        //{
        //    return invoiceDAL.LoadDataOnAddOrder();
        //}

        public DataTable LoadDataOnAddOrder()
        {
            return invoiceDAL.LoadDataOnAddOrder();
        }

        public DataTable LoadSizeByID(int id) {
            return invoiceDAL.LoadSizeByID(id);
        }

        public int GetTypeProductByID(int id)
        {
            return invoiceDAL.GetTypeProductByID(id);
        }


        public int GetPriceByIDProduct(int id)
        {
            return invoiceDAL.GetPriceByIDProduct(id);
        }

        public DataTable GetQuanTityBySizeAndIDProduct(int id, int size)
        {
            DataTable dt = new DataTable();
            dt = invoiceDAL.GetQuanTityBySizeAndIDProduct(id, size);
            return dt;
        }

        public int GetQuantityPhuKienByIDProduct(int id)
        {
            return invoiceDAL.GetQuantityPhuKienByIDProduct(id);
        }

        public int GetDiscountByIDProduct(int id)
        {
            return invoiceDAL.GetDiscountByIDProduct(id);
        }
        public DataTable GetTableStaffsByUsername(string username)
        {
            return invoiceDAL.GetTableStaffsByUsername(username);
        }

        public int InsertInvoice(DateTime creadate, int idcustomer, int idstaff)
        {
            return invoiceDAL.InsertInvoice(creadate, idcustomer, idstaff);
        }

        public int GetIDInvoiceMax()
        {
            return invoiceDAL.GetIDInvoiceMax();
        }

        public DataTable GetDetailInvoie(int id)
        {
            return invoiceDAL.GetDetailInvoie(id);
        }
        public DataTable GetTimeByIDInvoice(int id)
        {
            return invoiceDAL.GetTimeByIDInvoice(id);
        }
        public DataTable GetInfoCustomerByIDInvoice(int id)
        {
            return invoiceDAL.GetInfoCustomerByIDInvoice(id);
        }
    }
}
