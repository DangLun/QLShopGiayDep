
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class AccountDAL
    {
        Provider provider = new Provider();
        public DataTable GetAccountNoStaff()
        {
            string query = "select accounts.ID, username, password from accounts left join staffs on accounts.ID = staffs.ID_Account where staffs.ID is NULL\r\n";
            DataTable dt = provider.ExcuteQuery(query);
            return dt;
        }
    }
}
