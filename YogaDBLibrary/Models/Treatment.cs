namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Treatment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Treatment()
        {
            Subscriptions = new HashSet<Subscription>();
            Trainings = new HashSet<Training>();
        }

        public int TreatmentId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Training> Trainings { get; set; }

        public override string ToString()
        {
            if(TreatmentId!=null)
                return TreatmentId.ToString()+". "+Name.ToString();
            else
                return Name.ToString();
        }
    }
}
