﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public class InvoiceAddModel
    {
        public int ID { get; set; }
        public int STT { get; set; }
        public int SizeProduct { get; set; }
        public string NameProduct { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
