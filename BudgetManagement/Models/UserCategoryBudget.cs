using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class UserCategoryBudget
    {
        public int UserCategoryBudgetID { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<Category> Category { get; set; }
        public string Notes { get; set; }
        public string Colour { get; set; }
        public decimal Budget { get; set; }
    }
}
