using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class MainDAL
    {
        Provider provider = new Provider();
        public string GetChucVuByUsername(string username)
        {
            DataTable dt = new DataTable();
            string query = "select TypeAccount.Name from Accounts inner join TypeAccount on Accounts.ID_TypeAccount = TypeAccount.ID where username = @username ";
            dt = provider.ExcuteQuery(query, new object[] {username});
            return dt.Rows[0]["Name"].ToString();
        }

        public string GetNameStaffByUsername(string username)
        {
            DataTable dt = new DataTable();
            string query = "select * from accounts inner join staffs on accounts.ID = staffs.ID_Account where username = @username ";
            dt = provider.ExcuteQuery(query, new object[] { username });
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Name"].ToString();
            }
            return "-1";
        }
    }
}
