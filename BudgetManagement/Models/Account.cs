using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagement.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public DateTime Created { get; set; }
        public decimal InitialBalance { get; set; }
    }
}
