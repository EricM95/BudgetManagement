using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicatonDbContext.Data;
using ApplicatonDbContext.Models;

namespace ApplicatonDbContext.Pages.Accounts
{
    public class EditModel : PageModel
    {
        private readonly ApplicatonDbContext.Data.ApplicationDbContext _context;

        public EditModel(ApplicatonDbContext.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ledger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LedgerExists(Ledger.ItemID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LedgerExists(int id)
        {
            return _context.Ledger.Any(e => e.ItemID == id);
        }
    }
}
