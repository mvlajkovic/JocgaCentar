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
    public class TreatmentController
    {
        public static List<Treatment> GetTreatments()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Treatments.ToList();
            }
        }

        public static Treatment GetTreatmentById(int id)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Treatments.Where(x => x.TreatmentId == id).FirstOrDefault();
            }
        }

        public static void AddTreatment(string name, string description, decimal price)
        {
            Treatment treatment = new Treatment()
            {
                Name = name,
                Description = description,
                Price = price
            };
            AddTreatment(treatment);
        }

        public static void AddTreatment(Treatment treatment)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                db.Treatments.Add(treatment);
                db.SaveChanges();
            }
        }

        public static void UpdateTreatment(int id, string name, string description, decimal price)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Treatment treatment = db.Treatments.Where(x => x.TreatmentId == id).SingleOrDefault();

                if (treatment != null)
                {
                    treatment.Name = name;
                    treatment.Description = description;
                    treatment.Price = price;

                    db.SaveChanges();
                }
            }
        }

        public static void UpdateTreatment(Treatment treatment)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Treatment tmpTreatment = db.Treatments.Where(x => x.TreatmentId == treatment.TreatmentId).SingleOrDefault();

                if (tmpTreatment != null)
                {
                    tmpTreatment.Name = treatment.Name;
                    tmpTreatment.Description = treatment.Description;
                    tmpTreatment.Price = treatment.Price;

                    db.SaveChanges();
                }
            }
        }

        public static void DeleteTreatment(int id)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Treatment treatment = db.Treatments.Where(x => x.TreatmentId == id).SingleOrDefault();

                if (treatment != null)
                {
                    db.Treatments.Remove(treatment);

                    db.SaveChanges();
                }
            }
        }
    }
}
