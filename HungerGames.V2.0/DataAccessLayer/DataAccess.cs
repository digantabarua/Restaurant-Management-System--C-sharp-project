using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class DataAccess
    {
        SqlConnection connection;
        SqlCommand command;

        public DataAccess()
        {
            //try
            //{
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HungerGamesDb"].ConnectionString);
            this.connection.Open();
            // }
            //catch (Exception )
            //{
            //  Console.WriteLine("Opps!Something went wrong!");
            //}
        }
        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            // this.command.ExecuteReader();
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            //this.command.ExecuteReader();
            return this.command.ExecuteNonQuery();
        }

    }
}
