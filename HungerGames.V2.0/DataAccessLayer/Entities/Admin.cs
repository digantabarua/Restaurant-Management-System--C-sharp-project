using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer.Entities
{
    class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public int AdminPhone { get; set; }
        public int AdminNid { get; set; }
        public string AdminGender { get; set; }
        public string AdminBloodGroup { get; set; }
        public string AdminAddress { get; set; }
        public string AdminDoB { get; set; }
        public string AdminStatus { get; set; }
    }
}
