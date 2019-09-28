using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OT2.Models;

namespace OT2.Pages.OT
{
    public class EditModel : PageModel
    {
        private readonly OT2.Models.OT2Context _context;

        public EditModel(OT2.Models.OT2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Emp Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emp = await _context.Emp.FirstOrDefaultAsync(m => m.EmpID == id);

            if (Emp == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Emp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpExists(Emp.EmpID))
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

        private bool EmpExists(string id)
        {
            return _context.Emp.Any(e => e.EmpID == id);
        }
    }
}
