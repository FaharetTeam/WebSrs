using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Contexts;
using WebSRS.Models;

namespace WebSRS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebSRS.Contexts.MyDbContext _context;

        public IndexModel(WebSRS.Contexts.MyDbContext context)
        {
            _context = context;
        }

        public AboutS AboutS { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            AboutS = await _context.AboutSite.FirstOrDefaultAsync(m => m.Id == 1);

            if (AboutS == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
