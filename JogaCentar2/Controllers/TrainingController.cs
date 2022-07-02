using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YogaDBLibrary;
using YogaDBLibrary.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace JogaCentar.Controllers
{
    public class TrainingController
    {
        public static List<ScheduleTime> GetScheduleHours()
        {
            List<ScheduleTime> hours = new List<ScheduleTime>();

            hours.Add(new ScheduleTime(8, "08:00"));
            hours.Add(new ScheduleTime(9, "09:00"));
            hours.Add(new ScheduleTime(10, "10:00"));
            hours.Add(new ScheduleTime(11, "11:00"));
            hours.Add(new ScheduleTime(12, "12:00"));
            hours.Add(new ScheduleTime(13, "13:00"));
            hours.Add(new ScheduleTime(14, "14:00"));
            hours.Add(new ScheduleTime(15, "15:00"));
            hours.Add(new ScheduleTime(16, "16:00"));
            hours.Add(new ScheduleTime(17, "17:00"));
            hours.Add(new ScheduleTime(18, "18:00"));

            return hours;
        }
        public static List<Training_Statuses> Get_Training_Statuses()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Training_Statuses.ToList();
            }
        }
        public static List<Training> GetTrainings()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Trainings.Include(x => x.Employee)
                    .Include(x => x.Treatment)
                    .Include(x => x.Training_Statuses)
                    .Include(r => r.Employee.Account)
                    .ToList();
            }
        }

        public static void AddTraining(int treatmentId, int trainerId, DateTime dateTime, int time)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                try
                {
                    Training training = new Training()
                    {
                        TreatmentId = treatmentId,
                        TrainerId = trainerId,
                        TrainingDate = dateTime.Date,
                        TrainingTime = time,
                        TrainingStatusId = (int)TrainingStatus_Enum.Scheduled
                    };
                    db.Trainings.Add(training);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex2)
                {
                    var newException = new FormattedDbEntityValidationException(ex2);


 
                }
                catch (Exception ex1)
                {

                }

            }
        }

        public static void AddTraining(Training training)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                try
                {
                    db.Trainings.Add(training);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex2)
                {
                    var newException = new FormattedDbEntityValidationException(ex2);



                }
                catch (Exception ex1)
                {

                }
            }
        }

        public static void UpdateTraining(int id, int treatmentId, int trainerId, DateTime dateTime, int time, int status)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                var training = db.Trainings.SingleOrDefault(x => x.TrainingId == id);

                if (training != null)
                {
                    training.TreatmentId = treatmentId;
                    training.TrainerId = trainerId;
                    training.TrainingDate = dateTime;
                    training.TrainingTime = time;
                    training.TrainingStatusId = status;

                    db.SaveChanges();
                }
            }
        }

        public static void UpdateTraining(Training training)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                var tmpTraining = db.Trainings.Where(x => x.TrainingId == training.TrainingId).SingleOrDefault();

                if (tmpTraining != null)
                {
                    tmpTraining.TreatmentId = training.TreatmentId;
                    tmpTraining.TrainerId = training.TrainerId;
                    tmpTraining.TrainingDate = training.TrainingDate;
                    tmpTraining.TrainingTime = training.TrainingTime;
                    tmpTraining.TrainingStatusId = training.TrainingStatusId;
                    tmpTraining.Comment = training.Comment;

                    db.SaveChanges();
                }
            }
        }

        public static void DeleteTraining(int id)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                var training = db.Trainings.SingleOrDefault(x => x.TrainingId == id);

                if (training != null)
                {
                    db.Trainings.Remove(training);

                    db.SaveChanges();
                }
            }
        }
    }
}
