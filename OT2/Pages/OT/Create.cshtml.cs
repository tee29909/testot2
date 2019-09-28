using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OT2.Models;

namespace OT2.Pages.OT
{
    public class CreateModel : PageModel
    {
        private readonly OT2.Models.OT2Context _context;

        public CreateModel(OT2.Models.OT2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Emp Emp { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Emp.Add(Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
