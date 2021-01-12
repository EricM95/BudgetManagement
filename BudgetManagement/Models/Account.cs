using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.IdentityModel;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagement.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public DateTime Created { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal InitialBalance { get; set; }
    }
}
