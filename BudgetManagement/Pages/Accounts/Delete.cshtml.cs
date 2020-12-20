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
    public class DeleteModel : PageModel
    {
        private readonly BudgetManagement.Data.BudgetManagementContext _context;

        public DeleteModel(BudgetManagement.Data.BudgetManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ledger = await _context.Ledger.FindAsync(id);

            if (Ledger != null)
            {
                _context.Ledger.Remove(Ledger);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
