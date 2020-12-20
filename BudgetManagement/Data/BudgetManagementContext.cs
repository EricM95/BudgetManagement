using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagement.Models
{
    public class BudgetManagementContext : DbContext
    {
        public BudgetManagementContext (DbContextOptions<BudgetManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserCategoryBudget> UserCategoryBudgets { get; set; }

        
    }
}
