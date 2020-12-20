using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Data;
using BudgetManagement.Models;

namespace BudgetManagement.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly BudgetManagementContext _context;

        public IndexModel(BudgetManagementContext context)
        {
            _context = context;
        }

        public IList<Ledger> Ledger { get;set; }

        public async Task OnGetAsync()
        {
            Ledger = await _context.Ledger.ToListAsync();
        }
    }
}
