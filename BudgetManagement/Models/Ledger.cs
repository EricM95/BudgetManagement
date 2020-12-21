using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicatonDbContext.Models
{
    public class Ledger
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        public string TransType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(10, 2)")]
        public decimal Amount { get; set; }
        public ICollection<Account> Account { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
