namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            
            Subscriptions = new HashSet<Subscription>();
        }

        public int UserId { get; set; }

        public int AccountId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(500)]
        public string Info { get; set; }

        public string Comment { get; set; }

        public virtual Account Account { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
