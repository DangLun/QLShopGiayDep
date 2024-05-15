using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public class InvoiceDetailModel
    {
        public int IDInvoice { get; set; }
        public int IDProduct { get; set; }
        public int BuyQuantity { get; set; }
        public int Size { get; set; }   
    }
}
