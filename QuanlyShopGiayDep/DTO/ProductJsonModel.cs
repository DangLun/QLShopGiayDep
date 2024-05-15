using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public  class ProductJsonModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public SizesDTO Sizes { get; set; }
    }
}
