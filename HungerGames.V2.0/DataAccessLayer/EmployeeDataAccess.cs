using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class EmployeeDataAccess
    {
        DataAccess eda;
        public EmployeeDataAccess()
        {
            eda = new DataAccess();
        }

        public List<Employee> GetEmployeeData()
        {
            string sql = "SELECT * FROM Employees;";
            SqlDataReader reader = eda.GetData(sql);
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee e = new Employee();
                e.EmployeeId = (int)reader["EmployeeId"];
                e.EmployeeName = reader["EmployeeName"].ToString();
                e.EmployeePassword = reader["EmployeePassword"].ToString();
                e.EmployeePhone = (int)reader["EmployeePhone"];
                e.EmployeeNid = reader["EmployeeNid"].ToString();
                e.EmployeeGender = reader["EmployeeGender"].ToString();
                e.EmployeeBloodGroup = reader["EmployeeBloodGroup"].ToString();
                e.EmployeeAddress = reader["EmployeeAddress"].ToString();
                e.EmployeeDoB = reader["EmployeeDoB"].ToString();
                e.EmployeeStatus = reader["EmployeeStatus"].ToString();

                list.Add(e);
            }
            return list;
        }
        public int AddEmployee(Employee e)
        {
            string sql = "INSERT INTO Employees(EmployeeName,EmployeePassword,EmployeePhone,EmployeeNid,EmployeeGender,EmployeeBloodGroup,EmployeeAddress,EmployeeDoB,EmployeeStatus) VALUES('" + e.EmployeePassword + "','" + e.EmployeePhone + "','" + e.EmployeeNid + "','" + e.EmployeeGender + "','" + e.EmployeeBloodGroup + "','" + e.EmployeeAddress + "','" + e.EmployeeDoB + "','" + e.EmployeeStatus + "')";
            return eda.ExecuteQuery(sql);
        }

        public int DeleteEmployee(int ab)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId='" + ab + "';";
            return eda.ExecuteQuery(sql);
        }

        public int EditEmployee(int eid, string en, string ep, string epn, int enid, string eg, string ebg, string ea, string edob, string es)
        {
            string sql = "UPDATE Employee SET EmployeeName='" + en + "',EmployeePassword='" + ep + "',EmployeePhone='" + epn + "',EmployeeNid='" + enid + "',EmployeeGender='" + eg + "',EmployeeBloodGroup='" + ebg + ",EmployeeAddress='" + ea + "',EmployeeDoB='" + edob + "',EmployeeStatus='" + es + "' WHERE EmployeeId='" + eid + "'";
            return eda.ExecuteQuery(sql);
        }
    }
}
