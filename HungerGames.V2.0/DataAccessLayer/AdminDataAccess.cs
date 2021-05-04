using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.DataAccessLayer
{
    class AdminDataAccess
    {
        DataAccess ada;
        public AdminDataAccess()
        {
            ada = new DataAccess();
        }

        public List<Admin> GetEmployeeData()
        {
            string sql = "SELECT * FROM Admins;";
            SqlDataReader reader = ada.GetData(sql);
            List<Admin> list = new List<Admin>();
            while (reader.Read())
            {
                Admin a = new Admin();
                a.AdminId = (int)reader["AdminId"];
                a.AdminName = reader["AdminName"].ToString();
                a.AdminPassword = reader["AdminPassword"].ToString();
                a.AdminPhone = (int)reader["AdminPhone"];
                a.AdminNid = (int)reader["AdminNid"];
                a.AdminGender = reader["AdminGender"].ToString();
                a.AdminBloodGroup = reader["AdminBloodGroup"].ToString();
                a.AdminAddress = reader["AdminAddress"].ToString();
                a.AdminDoB = reader["AdminDoB"].ToString();
                a.AdminStatus = reader["AdminStatus"].ToString();
                list.Add(a);
            }
            return list;
        }
        public int AddAdmin(Admin a)
        {
            string sql = "INSERT INTO Admins(AdminName,AdminPassword,AdminPhone,AdminNid,AdminGender,AdminBloodGroup,AdminAddress,AdminDoB,AdminStatus) VALUES('" + a.AdminPassword + "','" + a.AdminPhone + "','" + a.AdminNid + "','" + a.AdminGender + "','" + a.AdminBloodGroup + "','" + a.AdminAddress + "','" + a.AdminDoB + "','" + a.AdminStatus + "')";
            return ada.ExecuteQuery(sql);
        }

        public int DeleteAdmin(int ba)
        {
            string sql = "DELETE FROM Admins WHERE AdminId='" + ba;
            return ada.ExecuteQuery(sql);
        }

        public int EditAdmin(int aid, string an, string ap, string apn, int anid, string ag, string abg, string aa, string adob, string aas)
        {
            string sql = "UPDATE Admins SET AdminName='" + an + "',AdminPassword='" + ap + "',AdminPhone='" + apn + "',AdminNid='" + anid + "',AdminGender='" + ag + "',AdminBloodGroup='" + abg + ",AdminAddress='" + aa + "',AdminDoB='" + adob + "',AdminStatus='" + aas + " WHERE AdminId='" + aid + "'";
            return ada.ExecuteQuery(sql);
        }


        public int AddEmployee(Employee e)
        {
            string sql = "INSERT INTO Employees(EmployeeName,EmployeePassword,EmployeePhone,EmployeeNid,EmployeeGender,EmployeeBloodGroup,EmployeeAddress,EmployeeDoB,EmployeeStatus) VALUES('" + e.EmployeePassword + "','" + e.EmployeePhone + "','" + e.EmployeeNid + "','" + e.EmployeeGender + "','" + e.EmployeeBloodGroup + "','" + e.EmployeeAddress + "','" + e.EmployeeDoB + "','" + e.EmployeeStatus + "')";
            return ada.ExecuteQuery(sql);
        }

        public int DeleteEmployee(int ab)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId='" + ab;
            return ada.ExecuteQuery(sql);
        }

        public int EditEmployee(int eid, string en, string ep, string epn, int enid, string eg, string ebg, string ea, string edob, string es)
        {
            string sql = "UPDATE Employees SET EmployeeName='" + en + "',EmployeePassword='" + ep + "',EmployeePhone='" + epn + "',EmployeeNid='" + enid + "',EmployeeGender='" + eg + "',EmployeeBloodGroup='" + ebg + ",EmployeeAddress='" + ea + "',EmployeeDoB='" + edob + "',EmployeeStatus='" + es + "' WHERE EmployeeId='" + eid + "'";
            return ada.ExecuteQuery(sql);
        }
    }
}
