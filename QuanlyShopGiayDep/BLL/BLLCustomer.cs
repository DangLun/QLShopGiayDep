using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLCustomer
    {
        CustomerDAL customerdal = new CustomerDAL();
        public DataTable GetData()
        {
            return customerdal.GetData();
        }

        public DataTable GetDatabySDT(string sdt)
        {
            return customerdal.GetDatabySDT(sdt);   
        }
        public DataTable GetDataCustomerByID(int id)
        {
            return customerdal.GetDataCustomerByID(id);
        }
        public int AddCustomerNoScore(CustomerModel customer)
        {
            return customerdal.AddCustomerNoScore(customer);
        }
        public void UpdateScoreCustomer(int id, int score, char type)
        {
            customerdal.UpdateScoreCustomer(id, score, type);
        }
    }
}
