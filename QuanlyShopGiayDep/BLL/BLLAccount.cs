using QuanlyShopGiayDep.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLAccount
    {
        AccountDAL accountdal = new AccountDAL();
        public DataTable GetAccountNoStaff()
        {
            return accountdal.GetAccountNoStaff();
        }
    }
}
