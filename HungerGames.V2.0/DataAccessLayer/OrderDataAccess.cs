using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class OrderDataAccess
    {
        DataAccess oda;
        public OrderDataAccess()
        {
            oda = new DataAccess();
        }

        public List<Order> GetOrderData()
        {
            string sql = "SELECT * FROM Orders;";
            SqlDataReader reader = oda.GetData(sql);
            List<Order> list = new List<Order>();
            while (reader.Read())
            {
                Order o = new Order();
                //  o.OrderNumber = (int)reader["OrderId"];
                o.Month = reader["Month"].ToString();
                o.Price = (int)reader["Price"];
                o.EmployeeName = reader["EmployeeName"].ToString();
                o.EmployeeId = (int)reader["EmployeeId"];
                list.Add(o);
            }
            return list;
        }


        public int AddOrder(Order o)
        {
            string sql = "INSERT INTO Orders(EmployeeName,EmployeeId,Month,Price) VALUES('" + o.EmployeeName + "','" + o.EmployeeId + "','" + o.Month + "','" + o.Price + "')";
            return oda.ExecuteQuery(sql);
        }

        public int DeleteOrder(int d)
        {
            string sql = "DELETE FROM Orders WHERE OrderNumber='" + d + "';";
            return oda.ExecuteQuery(sql);
        }
    }
}
