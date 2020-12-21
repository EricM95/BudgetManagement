using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using ApplicatonDbContext.Data;
using ApplicatonDbContext.Models;

namespace ApplicatonDbContext.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> User { get; set; }
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
