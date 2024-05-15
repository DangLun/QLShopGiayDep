using QuanlyShopGiayDep.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLBrand
    {
        Provider provider = new Provider();
        public DataTable LoadBrand()
        {
            string query = "SELECT * from Brands";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query);
            return data;
        }
    }
}
