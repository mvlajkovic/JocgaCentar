namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        public int ReservationId { get; set; }

        public int SubscriptionId { get; set; }

        public int TrainingId { get; set; }

        public int ReservationStatusId { get; set; }


        [StringLength(1000)]
        public string Comment { get; set; }

        public virtual Reservation_Statuses Reservation_Statuses { get; set; }

        public virtual Training Training { get; set; }

        public virtual Subscription Subscription { get; set; }

        
    }
}
