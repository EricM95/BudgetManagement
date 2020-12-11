using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class Ledger
    {
        public int Key { get; set; }
        public string TransType { get; set; }
        public decimal Amount { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Category> Category { get; set; }
    }
}
