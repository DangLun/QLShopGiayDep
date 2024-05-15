using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int ID_Brand { get; set; }
        public int ID_Type { get; set; }
        public int Quantity { get; set; }
        public List<object[]> Sizes { get; set; }
    }
}
