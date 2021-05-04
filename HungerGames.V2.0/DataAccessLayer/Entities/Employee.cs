using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer.Entities
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePassword { get; set; }
        public int EmployeePhone { get; set; }
        public string EmployeeNid { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeBloodGroup { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeDoB { get; set; }
        public string EmployeeStatus { get; set; }
        public int OrderNumber { get; set; }
    }
}
