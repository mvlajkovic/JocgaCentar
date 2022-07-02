namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Owner
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string LastName { get; set; }
    }
}
