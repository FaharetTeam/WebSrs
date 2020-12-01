using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Pages;

namespace WebSRS.Pages
{
    public class Details1Model : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public Details1Model(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        public IStory IStory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IStory = await _context.Storyes.FirstOrDefaultAsync(m => m.Id == id);

            if (IStory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
