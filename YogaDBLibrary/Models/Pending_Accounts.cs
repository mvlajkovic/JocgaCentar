namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pending_Accounts
    {
        [Key]
        [Column(Order = 0)]
        public int AccountId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string LastName { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        [NotMapped]
        public AccountStatus_Enum AccountStatus { get; set; }

        [NotMapped]
        public AccountType_Enum AccountType { get; set; }

        public override string ToString()
        {
            return FirstName.ToString() + " " + LastName.ToString()+ " => " + Email.ToString();
        }
    }
}
