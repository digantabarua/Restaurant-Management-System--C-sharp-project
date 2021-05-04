using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer.Entities
{
    class Varriables
    {
        public static string id;
        public static int a = 0;
        public static int x, storage;
        public static int total(int i)
        {
            a = a + i;
            return a;
        }
    }
}
