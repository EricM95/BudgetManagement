using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationDbContext.Models;

namespace ApplicationDbContext.Data
{
    public class BudgetManagementContext : DbContext
    {
        public BudgetManagementContext (DbContextOptions<BudgetManagementContext> options)
            : base(options)
        {
        }

       
    }
}
