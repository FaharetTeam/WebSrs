using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Pages.Story;

namespace WebSRS.Pages
{
    public class KazakhstanModel : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public KazakhstanModel(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        public IList<KZClass> KZClass { get; set; }

        public async Task OnGetAsync()
        {
            KZClass = await _context.KZ.ToListAsync();
        }
    }
}
