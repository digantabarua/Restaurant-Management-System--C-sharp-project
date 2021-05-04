using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer.Entities
{
    class Storage
    {
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public string StorageMonth { set; get; }
        public int Quantity { set; get; }
        public int Price { set; get; }
    }
}
