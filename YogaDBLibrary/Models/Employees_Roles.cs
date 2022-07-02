namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees_Roles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Role Role { get; set; }


        public override string ToString()
        {
            if(Role != null)
            {
                return Role.RoleName.ToString();
            }                
            else
            {
                return RoleId.ToString();
            }
        }
    }
}
