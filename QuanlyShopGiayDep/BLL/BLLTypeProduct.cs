using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLTypeProduct
    {
        Provider provider = new Provider();
        public DataTable LoadType()
        {
            string query = "SELECT * from TypeProducts";
            DataTable data = new DataTable();
            data = provider.ExcuteQuery(query);
            return data;
        }
    }
}
