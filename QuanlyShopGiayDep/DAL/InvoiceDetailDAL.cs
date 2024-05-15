using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class InvoiceDetailDAL
    {
        Provider provider = new Provider();
        public int InsertInvoiceDetail(InvoiceDetailModel invoicedetail)
        {
            int idInvoice = invoicedetail.IDInvoice;
            int idProduct = invoicedetail.IDProduct;
            int BuyQuantity = invoicedetail.BuyQuantity;
            int size = invoicedetail.Size;  
            string query = "exec AddInvoiceDetail @idinvoice , @idproduct , @buyquantity , @size ";
            return provider.ExcuteNonQuery(query, new object[] { idInvoice, idProduct, BuyQuantity, size }); ;
        }
    }
}
