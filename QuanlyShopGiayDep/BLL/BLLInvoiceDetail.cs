using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLInvoiceDetail
    {
        InvoiceDetailDAL invoicedetailDAL = new InvoiceDetailDAL();
        public int InsertInvoiceDetail(InvoiceDetailModel invoicedetail)
        {
            return invoicedetailDAL.InsertInvoiceDetail(invoicedetail);
        }
    }
}
