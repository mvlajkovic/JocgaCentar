namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Employees = new HashSet<Employee>();
            Users = new HashSet<User>();
        }

        public int AccountId { get; set; }

        public int StatusId { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public bool? ChangePassword { get; set; }

        public virtual Account_Statuses Account_Statuses { get; set; }

        public virtual Account_Types Account_Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return FirstName.ToString()+" " + LastName.ToString();
        }
    }
}
