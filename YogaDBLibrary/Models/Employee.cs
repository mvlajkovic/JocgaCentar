namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Trainings = new HashSet<Training>();
            Employees_Roles = new HashSet<Employees_Roles>();

        }

        public int EmployeeId { get; set; }

        public int AccountId { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(500)]
        public string Office { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public virtual Account Account { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Training> Trainings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees_Roles> Employees_Roles { get; set; }



        public override string ToString()
        {
            if (Account != null)
            {
                return EmployeeId.ToString()+"."+ Account.ToString();
            }
            else
            {
                return EmployeeId.ToString();
            }
        }
    }
}
