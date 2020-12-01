using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSRS.Pages;

namespace WebSRS.Pages
{
    public class Create1Model : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public Create1Model(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IStory IStory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Storyes.Add(IStory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}