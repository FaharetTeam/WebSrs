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
    public class Index3Model : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public Index3Model(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        public IList<IStory> IStory { get;set; }

        public async Task OnGetAsync()
        {
            IStory = await _context.Storyes.ToListAsync();
        }
    }
}
