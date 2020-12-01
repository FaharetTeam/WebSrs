using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSRS.Models;

namespace WebSRS.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly WebSRS.Contexts.MyDbContext _context;

        public PrivacyModel(WebSRS.Contexts.MyDbContext context)
        {
            _context = context;
        }

        public AboutU AboutU { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            AboutU = await _context.AboutUs.FirstOrDefaultAsync(m => m.Id == 1);

            if (AboutU == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
