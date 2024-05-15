using QuanlyShopGiayDep.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLMain
    {
        MainDAL maindal = new MainDAL();
        public string GetChucVuByUsername(string username)
        {
            return maindal.GetChucVuByUsername(username); 
        }
        public string GetNameStaffByUsername(string username)
        {
            return maindal.GetNameStaffByUsername(username);
        }
    }
}
