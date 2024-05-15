using QuanlyShopGiayDep.DTO;
using QuanlyShopGiayDep.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DAL
{
    public class StaffDAL
    {
        ShopGiayDep _dbcontext = new ShopGiayDep();
        Provider provider = new Provider();
        public async Task<List<Staff>> GetDataStaff()
        {
            return await _dbcontext.Staffs.ToListAsync();
        }

        public async Task<int> InsertStaff(StaffModel staff)
        {
            Staff newStaff = new Staff();
            newStaff.Name = staff.Name;
            newStaff.Phone = staff.Phone;
            newStaff.BirthDate = staff.BirthDate;
            newStaff.Gender = staff.Gender;
            newStaff.Salary = staff.Salary;
            _dbcontext.Staffs.Add(newStaff);
            return await _dbcontext.SaveChangesAsync();
        }

        public async Task<int> RemoveStaff(int id)
        {
            var oneStaff = await _dbcontext.Staffs.FirstOrDefaultAsync(st => st.ID == id);
            _dbcontext.Staffs.Remove(oneStaff);
            return await _dbcontext.SaveChangesAsync();
        }

        public async Task<int> UpdateStaff(StaffModel staff)
        {
            var exitstaff = await _dbcontext.Staffs.FirstOrDefaultAsync(st => st.ID == staff.ID);
            if (exitstaff != null)
            {
                exitstaff.ID = staff.ID;
                exitstaff.Name = staff.Name;
                exitstaff.Phone = staff.Phone;
                exitstaff.BirthDate = staff.BirthDate;
                exitstaff.Gender = staff.Gender;
                exitstaff.Salary = staff.Salary;
                return await _dbcontext.SaveChangesAsync();
            }
            return -1; 
        }

        public async Task<List<Staff>> SearchByType(string type, string input)
        {
            input= input.ToLower(); 
            if(type.ToLower() == "id")
            {
                return await _dbcontext.Staffs.Where(st=>st.ID.ToString().ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "tên nhân viên")
            {
                return await _dbcontext.Staffs.Where(st => st.Name.ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "số điện thoại")
            {
                return await _dbcontext.Staffs.Where(st => st.Phone.ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "ngày sinh")
            {
                return await _dbcontext.Staffs.Where(st => st.BirthDate.Value.Day.ToString().ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "tháng sinh")
            {
                return await _dbcontext.Staffs.Where(st => st.BirthDate.Value.Month.ToString().ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "năm sinh")
            {
                return await _dbcontext.Staffs.Where(st => st.BirthDate.Value.Year.ToString().ToLower().Contains(input)).ToListAsync();
            }else if(type.ToLower() == "giới tính")
            {
                return await _dbcontext.Staffs.Where(st => st.Gender.ToLower().Contains(input)).ToListAsync();
            }
            return await _dbcontext.Staffs.Where(st => st.Salary.ToString().ToLower().Contains(input)).ToListAsync();
        }

        public string GetNameStaffByIDInvoice(int id)
        {
            string query = "select staffs.Name from staffs inner join invoices on staffs.ID = invoices.ID_staff where invoices.ID = @id ";
            DataTable dt = provider.ExcuteQuery(query, new object[] {id});
            return dt.Rows[0]["Name"].ToString();
        }

        public DataTable GetDataStaffNoAccount()
        {
            string query = "select * from staffs where ID_Account is NULL";
            DataTable dt = provider.ExcuteQuery(query);
            return dt;
        }

        public int UpdateAccountStaff(int id_account, int id_staff)
        {
            string query = "update staffs set ID_account = @id where ID = @id_staff ";
            int dt = provider.ExcuteNonQuery(query, new object[] {id_account, id_staff});
            return dt;
        }
    }
}
