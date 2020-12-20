using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BudgetManagement.Models;

namespace BudgetManagement.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly BudgetManagement.Models.BudgetManagementContext _context;

        public CreateModel(BudgetManagement.Models.BudgetManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ledger Ledger { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ledger.Add(Ledger);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
