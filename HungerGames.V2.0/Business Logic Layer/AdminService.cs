using HungerGames.V2._0.DataAccessLayer;
using HungerGames.V2._0.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames.V2._0.Business_Logic_Layer
{
    class AdminService
    {
        AdminDataAccess ada;
        EmployeeDataAccess eda;

        public AdminService()
        {
            ada = new AdminDataAccess();
            eda = new EmployeeDataAccess();
        }
        public int AddAdmin(string an, string ap, int apn, int anid, string ag, string abg, string aa, string adob, string aas)
        {
            Admin a = new Admin() { AdminName = an, AdminPassword = ap, AdminPhone = apn, AdminNid = anid, AdminGender = ag, AdminBloodGroup = abg, AdminAddress = aa, AdminDoB = adob, AdminStatus = aas };
            return ada.AddAdmin(a);
        }

        public int DeleteAdmin(int ba)
        {
            return ada.DeleteEmployee(ba);
        }

        public int EditAdmin(int aid, string an, string ap, string apn, int anid, string ag, string abg, string aa, string adob, string aas)
        {
            return ada.EditAdmin(aid, an, ap, apn, anid, ag, abg, aa, adob, aas);
        }
        public int AddEmployee(string en, string ep, int epn, string enid, string eg, string ebg, string ea, string edob, string es)
        {
            Employee e = new Employee() { EmployeeName = en, EmployeePassword = ep, EmployeePhone = epn, EmployeeNid = enid, EmployeeGender = eg, EmployeeBloodGroup = ebg, EmployeeAddress = ea, EmployeeDoB = edob, EmployeeStatus = es };
            return eda.AddEmployee(e);
        }

        public int DeleteEmployee(int id)
        {
            return eda.DeleteEmployee(id);
        }

        public int EditEmployee(int eid, string en, string ep, string epn, int enid, string eg, string ebg, string ea, string edob, string es)
        {
            return eda.EditEmployee(eid, en, ep, epn, enid, eg, ebg, ea, edob, es);
        }
    }
}
