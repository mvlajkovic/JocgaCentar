using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaDBLibrary;
using YogaDBLibrary.Models;


using System.Data.Entity;

namespace JogaCentar.Controllers
{
    public class EmployeeControler
    {
        public static List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (YogaDBContext db = new YogaDBContext())
            {
                roles = db.Roles.ToList();
            }

            return roles;

        }

        public static Employee GetEmployeeById(int id)
        {
            Employee employee = null;
            using (YogaDBContext db = new YogaDBContext())
            {
                employee = db.Employees.Where(x => x.EmployeeId == id)
                    .Include(i => i.Account)
                    .Include(x => x.Employees_Roles.Select(r => r.Role))
                    .FirstOrDefault();
            }
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (YogaDBContext db = new YogaDBContext())
            {
                employees = db.Employees
                    .Include(i => i.Account)
                    .Include(x => x.Employees_Roles.Select( r => r.Role))
                    .ToList();
            }

            return employees;

        }

        public static Employee UpdateEmployee(Employee empl)
        {
            Employee employee = new Employee(); 
            using (YogaDBContext db = new YogaDBContext())
            {

                employee =  db.Employees.Where(i => i.EmployeeId == empl.EmployeeId).FirstOrDefault();

                employee.Office = empl.Office;
                employee.Comment = empl.Comment;
                decimal salary = 0;

                if(empl.Salary!=null)
                {
                    employee.Salary = empl.Salary;
                }

                


                db.SaveChanges();
            }
            return employee;
        }
        public static Employees_Roles AddRole(int employeeId, int roleId, string comment = "")
        {
            Employees_Roles role = new Employees_Roles();
            role.EmployeeId = employeeId;
            role.RoleId = roleId;
            role.Comment = comment;

            using (YogaDBContext db = new YogaDBContext())
            {

                db.Employees_Roles.Add(role);
                db.SaveChanges();
            }

            return role;

        }

        public static List<Role> GetEmployee_Roles(int employeeId)
        {
            List<Employees_Roles> roles = new List<Employees_Roles>();
            List<Role> emplroles = new List<Role>();

            using (YogaDBContext db = new YogaDBContext())
            {

                roles = db.Employees_Roles.Where(r => r.EmployeeId == employeeId).Include( i => i.Role).ToList();
                
            }
;
            foreach (Employees_Roles role in roles)
            {
                emplroles.Add(role.Role);
            }

            return emplroles;

        }

        public static List<string> GetEmployee_RoleValues(int employeeId)
        {
            List<Employees_Roles> roles = new List<Employees_Roles>();
            List<string> emplroles = new List<string>();

            using (YogaDBContext db = new YogaDBContext())
            {

                roles = db.Employees_Roles.Where(r => r.EmployeeId == employeeId).Include(i => i.Role).ToList();

            }
;
            foreach (Employees_Roles role in roles)
            {
                emplroles.Add(role.Role.RoleName);
            }

            return emplroles;

        }
    }
}
