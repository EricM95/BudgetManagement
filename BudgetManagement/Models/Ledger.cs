using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetManagement.Models
{
    public class Ledger
    {
        public int Key { get; set; }
        public string TransType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(10, 2)")]
        public decimal Amount { get; set; }
        public ICollection<Account> Account { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
