using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YogaDBLibrary.Models;
using YogaDBLibrary;

namespace JogaCentar.Controllers
{
    public class TrainerController
    {
        public static List<Employee> GetTrainers()
        {
            List<Employee> trainerList = new List<Employee>();

            using (YogaDBContext db = new YogaDBContext())
            {
                List <Trainer> trainers = new List<Trainer>();

                trainers = db.Trainers.ToList();

                foreach (var trainer in trainers)
                {
                    Employee tmpEmloyee = GetTrainerById(trainer.EmployeeId);
                    trainerList.Add(tmpEmloyee);
                }
            }
            return trainerList;
        }

        public static Employee GetTrainerById(int id)
        {
            Employee employee = null;
            using (YogaDBContext db = new YogaDBContext())
            {
                Trainer trainer = db.Trainers.Where(x => x.EmployeeId == id).FirstOrDefault();
                if(trainer != null)
                {
                    employee = db.Employees.Where(x => x.EmployeeId == trainer.EmployeeId)
                        .Include(i => i.Account)
                        .Include(x => x.Employees_Roles.Select(r => r.Role))
                        .FirstOrDefault();
                }

            }

            return employee;
        }

    }
}
