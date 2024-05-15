using QuanlyShopGiayDep.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class CustomerDAL
    {
        Provider provider = new Provider();
        public DataTable GetData()
        {
            string query = "Select * from Customers";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query);
            return dt;
        }

        public DataTable GetDatabySDT(string sdt)
        {
            string query = "exec GetDataBySDT @sdt ";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query, new object[] {sdt});
            return dt;
        }
        public DataTable GetDataCustomerByID(int id)
        {
            string query = "select * from customers where id = @id ";
            DataTable dt = new DataTable();
            dt = provider.ExcuteQuery(query, new object[] { id });
            return dt;
        }
        public int AddCustomerNoScore(CustomerModel customer)
        {
            string name = customer.Name;
            string phone = customer.Phone;
            string gender = customer.Gender;
            int score = customer.Score;
            DateTime created = customer.Created;
            string query = "exec AddCustomer @name , @phone , @gender , @score , @craedate";
            int r = provider.ExcuteNonQuery(query, new object[] { name, phone, gender, score, created });
            return r;
        }

        public void UpdateScoreCustomer(int id, int score, char type)
        {
            string query = "exec UpdateScoreCustomer @id , @score , @type ";
            provider.ExcuteNonQuery(query, new object[] { id, score, type });
        }
    }
}
