using QuanlyShopGiayDep.DAL;
using QuanlyShopGiayDep.DTO;
using QuanlyShopGiayDep.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QuanlyShopGiayDep.BLL
{
    public class BLLStaff
    {
        StaffDAL staffDAL = new StaffDAL();

        public async Task<List<StaffModel>> LoadData()
        {
            var ListStaff = await staffDAL.GetDataStaff();
            return ListStaff.Select(st => new StaffModel()
            {
                ID = st.ID,
                Name = st.Name,
                Phone = st.Phone,
                BirthDate = (DateTime)st.BirthDate,
                Gender = st.Gender,
                Salary = (int)st.Salary
            }).ToList();
        }
        public async Task<int> InsertStaff(StaffModel staff)
        {
            return await staffDAL.InsertStaff(staff);
        }

        public async Task<int> RemoveStaff(int id)
        {
            return await staffDAL.RemoveStaff(id);
        }

        public async Task<int> UpdateStaff(StaffModel staff)
        {
            return await staffDAL.UpdateStaff(staff);
        }
        //public DataTable LoadData()
        //{
        //    Provider provider = new Provider();
        //    string query = "select ID, name, phone, birthdate, gender, salary from staffs";
        //    DataTable data = new DataTable();
        //    data = provider.ExcuteQuery(query);
        //    return data;
        //}

        public async Task<List<StaffModel>> SearchByType(string type, string input)
        {
            var staffList = await staffDAL.SearchByType(type, input);
            var staffModelList = staffList.Select(st => new StaffModel()
            {
                ID = st.ID,
                Name = st.Name,
                Phone = st.Phone,
                BirthDate = (DateTime)st.BirthDate,
                Gender = st.Gender,
                Salary = (int)st.Salary
            }).ToList();
            return staffModelList;
        }

        public string GetNameStaffByIDInvoice(int id)
        {
            return staffDAL.GetNameStaffByIDInvoice(id);
        }
        public DataTable GetDataStaffNoAccount()
        {
            return staffDAL.GetDataStaffNoAccount();
        }
        public int UpdateAccountStaff(int id_account, int id_staff)
        {
            return staffDAL.UpdateAccountStaff(id_account, id_staff);   
        }
    }
}
