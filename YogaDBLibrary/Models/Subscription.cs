namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscription()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int SubscriptionId { get; set; }

        public int UserId { get; set; }

        public int TreatmentId { get; set; }

        public int Number_of_Trainings { get; set; }

        public int Attended_Trainings { get; set; }

        public int SubscriptionStatusId { get; set; }


        [StringLength(1000)]
        public string Comment { get; set; }

        public virtual Subscription_Statuses Subscription_Statuses { get; set; }

        public virtual Treatment Treatment { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
