using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicatonDbContext.Data;
using ApplicatonDbContext.Models;

namespace ApplicatonDbContext.Pages.Accounts
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicatonDbContext.Data.ApplicationDbContext _context;

        public DeleteModel(ApplicatonDbContext.Data.ApplicationDbContext context)
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
