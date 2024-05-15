using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyShopGiayDep.DTO
{
    public class StaffModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }   
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int? ID_Account { get; set; }
        public int? Salary { get; set; }
    }
}
