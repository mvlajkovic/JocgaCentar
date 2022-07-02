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
    public class SubscriptionsController
    {
        public static List<Subscription> GetSubscriptions()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Subscriptions
                    .Include(x => x.Treatment)
                    .Include(x => x.User)
                    .Include(x=> x.Subscription_Statuses)
                    .ToList();
            }
        }

        public static List<User> GetUsers()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Users
                    .Include(x => x.Account)
                    .ToList();
            }
        }

        public static Subscription GetSubscriptionById(int id)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Subscriptions.Where(x => x.SubscriptionId == id)
                    .Include(x => x.Treatment)
                    .Include(x => x.User)
                    .Include(x => x.Subscription_Statuses)
                    .FirstOrDefault();
            }
        }

        public static void AddSubscription(int userId, int treatmentId, int subscriptionTreatmentNo)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Subscription subscripiton = new Subscription()
                {
                    UserId = userId,
                    TreatmentId = treatmentId,
                    Number_of_Trainings = subscriptionTreatmentNo,
                    Attended_Trainings = 0,
                    SubscriptionStatusId = (int) SubscriptionStatus_Enum.Active,
                    Comment = ""
                };

                db.Subscriptions.Add(subscripiton);
                db.SaveChanges();
            }
        }

        public static void AddSubscription(Subscription subscripiton)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                subscripiton.Attended_Trainings = 0;
                if (subscripiton.Comment == null) subscripiton.Comment = "";
                subscripiton.SubscriptionStatusId = (int)SubscriptionStatus_Enum.Active;

                db.Subscriptions.Add(subscripiton);
                db.SaveChanges();
            }
        }

        public static void UpdateSubscription(int id, int treatmentId, int subscriptionTreatmentNo, int status, string comment = null)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                var subscripiton = db.Subscriptions.Where(x => x.SubscriptionId == id).SingleOrDefault();

                subscripiton.TreatmentId = treatmentId;
                subscripiton.Number_of_Trainings = subscriptionTreatmentNo;
                subscripiton.SubscriptionStatusId = status;
                if(comment != null) subscripiton.Comment = comment;

                db.SaveChanges();
            }
        }

        public static void UpdateSubscription(Subscription sub)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                var subscripiton = db.Subscriptions.Where(x => x.SubscriptionId == sub.SubscriptionId).SingleOrDefault();

                subscripiton.TreatmentId = sub.TreatmentId;
                subscripiton.Number_of_Trainings = sub.Number_of_Trainings;
                subscripiton.SubscriptionStatusId = sub.SubscriptionStatusId;
                if (sub.Comment != null) subscripiton.Comment = sub.Comment;

                db.SaveChanges();
            }
        }

        public static List<Subscription_Statuses> Get_Subscription_Statuses()
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                return db.Subscription_Statuses.ToList();
            }
        }
    }
}
