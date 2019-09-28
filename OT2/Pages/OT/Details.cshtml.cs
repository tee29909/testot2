using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OT2.Models;

namespace OT2.Pages.OT
{
    public class DetailsModel : PageModel
    {
        private readonly OT2.Models.OT2Context _context;

        public DetailsModel(OT2.Models.OT2Context context)
        {
            _context = context;
        }

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
    }
}
