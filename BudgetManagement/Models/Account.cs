using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public DateTime Created { get; set; }
        public decimal InitialBalance { get; set; }
    }
}
