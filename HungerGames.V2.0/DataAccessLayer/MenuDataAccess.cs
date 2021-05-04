using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class MenuDataAccess
    {
        DataAccess mda;
        public MenuDataAccess()
        {
            mda = new DataAccess();
        }

        public List<Menus> GetMenuData()
        {
            string sql = "SELECT * FROM Menu;";
            SqlDataReader reader = mda.GetData(sql);
            List<Menus> list = new List<Menus>();
            while (reader.Read())
            {
                Menus m = new Menus();
                m.MenuNo = (int)reader["MenuNo"];
                m.MenuName = reader["MenuName"].ToString();
                m.Price = (int)reader["Price"];
                m.Quantity = (int)reader["Quantity"];
                m.Type = reader["Type"].ToString();
                list.Add(m);
            }
            return list;
        }

        public List<string> GetMenuName()
        {
            string sql = "SELECT DISTINCT MenuName FROM Menu;";
            SqlDataReader reader = mda.GetData(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string sr = reader["MenuName"].ToString();
                list.Add(sr);
            }
            return list;
        }

        public int AddMenu(Menus m)
        {
            string sql = "INSERT INTO Menu(MenuName,Price,Quantity,Type) VALUES('" + m.MenuName + "','" + m.Price + "','" + m.Quantity + "','" + m.Type + "')";
            return mda.ExecuteQuery(sql);
        }

        public int EditMenu(int mnm, string mn, float p, int q, string t)
        {
            string sql = "UPDATE Menu SET MenuName='" + mn + "' , Price='" + p + "',Quantity='" + q + "', Type='" + t + "' WHERE MenuNo='" + mnm + "'";
            return mda.ExecuteQuery(sql);
        }

        public int DeleteMenu(int rm)
        {
            string sql = "DELETE FROM Menu WHERE MenuNo='" + rm + "'";
            return mda.ExecuteQuery(sql);
        }
    }
}
