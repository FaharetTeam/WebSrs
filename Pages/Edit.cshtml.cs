using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSRS.Pages;

namespace WebSRS.Pages
{
    public class Edit1Model : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public Edit1Model(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(IStory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IStoryExists(IStory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Create");
        }

        private bool IStoryExists(int id)
        {
            return _context.Storyes.Any(e => e.Id == id);
        }
    }
}
