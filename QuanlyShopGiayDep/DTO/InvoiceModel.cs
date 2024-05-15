using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public class InvoiceModel
    {
        public int ID { get; set; }
        public DateTime CreaDate { get; set; }
        public int BuyQuantity { get; set; }
        public string NameCustomer { get; set; }
        public string Phone {  get; set; }
        public string Gender { get; set; }
        public int Score { get; set; }
    }
}
