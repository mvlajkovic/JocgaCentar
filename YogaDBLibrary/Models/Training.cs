namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Training
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Training()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int TrainingId { get; set; }

        public int TreatmentId { get; set; }

        public int TrainerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime TrainingDate { get; set; }

        public int TrainingTime { get; set; }

        public int TrainingStatusId { get; set; }


        [StringLength(1000)]
        public string Comment { get; set; }

        public virtual Employee Employee { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual Training_Statuses Training_Statuses { get; set; }

        public virtual Treatment Treatment { get; set; }

        public override string ToString()
        {
            return Treatment.ToString()+" on "+TrainingDate.ToString("yyyy.MM.dd");
        }
    }
}
