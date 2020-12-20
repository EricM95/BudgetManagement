using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Models;

namespace BudgetManagement.Data
{
    public class BudgetManagementContext : DbContext
    {
        public BudgetManagementContext (DbContextOptions<BudgetManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCategoryBudget> UserCategoryBudgets { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Ledger>().ToTable("Legder");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserCategoryBudget>().ToTable("UserCategoryBudget");
        }
    }
}
