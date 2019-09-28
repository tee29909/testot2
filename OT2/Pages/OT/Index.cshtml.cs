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
    public class IndexModel : PageModel
    {
        private readonly OT2.Models.OT2Context _context;

        public IndexModel(OT2.Models.OT2Context context)
        {
            _context = context;
        }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList EmployeeTypeID { get; set; }
        [BindProperty(SupportsGet = true)]
        public string LastName { get; set; }
        public SelectList Gender { get; private set; }
        public IList<Emp> Emp { get;set; }

        public async Task OnGetAsync()
        {
            Emp = await _context.Emp.ToListAsync();

            var EnpID = from m in _context.Emp
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                EnpID = EnpID.Where(s => s.EmployeeTypeID.Contains(SearchString));
            }

            Emp = await EnpID.ToListAsync();
            IQueryable<string> genreQuery = from m in _context.Emp
                                            orderby m.Gender
                                            select m.Gender;

          

            if (!string.IsNullOrEmpty(SearchString))
            {
                EnpID = EnpID.Where(s => s.FirstName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(LastName))
            {
                EnpID = EnpID.Where(x => x.Gender == LastName);
            }
            Gender = new SelectList(await genreQuery.Distinct().ToListAsync());
            Emp = await EnpID.ToListAsync();
        }
    }
}
