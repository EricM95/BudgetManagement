using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BudgetManagement.Models;

namespace BudgetManagement.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        private readonly BudgetManagement.Models.BudgetManagementContext _context;

        public DetailsModel(BudgetManagement.Models.BudgetManagementContext context)
        {
            _context = context;
        }

        public Ledger Ledger { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ledger = await _context.Ledger.FirstOrDefaultAsync(m => m.ItemID == id);

            if (Ledger == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
