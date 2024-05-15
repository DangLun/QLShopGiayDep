namespace QuanlyShopGiayDep.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductDetail
    {
        public int ID { get; set; }

        public long? Quantity { get; set; }

        public int? Size { get; set; }

        public int? ID_Product { get; set; }

        public virtual Product Product { get; set; }
    }
}
