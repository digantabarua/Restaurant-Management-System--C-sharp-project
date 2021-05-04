using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer.Entities
{
    class Order
    {
        public int OrderNumber { set; get; }
        public string Month { set; get; }
        public int Price { set; get; }
        public string EmployeeName { set; get; }
        public int EmployeeId { set; get; }
    }
}
