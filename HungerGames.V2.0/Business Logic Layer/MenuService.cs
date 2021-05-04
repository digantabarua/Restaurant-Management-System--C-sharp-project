using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.Business_Logic_Layer
{
    class MenuService
    {
        MenuDataAccess mda;
        public MenuService()
        {
            mda = new MenuDataAccess();
        }

        public int AddMenu(string mn, int p, int q, string t)
        {
            Menus m = new Menus() { MenuName = mn, Price = p, Quantity = q, Type = t };
            return mda.AddMenu(m);
        }

        public int DeleteMenu(int id)
        {
            return mda.DeleteMenu(id);
        }

        public int EditMenu(int mnm, string mn, float p, int q, string t)
        {
            return mda.EditMenu(mnm, mn, p, q, t);
        }

        public List<string> GetMenuName()
        {
            return mda.GetMenuName();
        }
    }
}
