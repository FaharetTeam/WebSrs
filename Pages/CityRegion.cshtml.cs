using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Pages.Employees;

namespace WebSRS.Pages
{
    public class CityRegionModel : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public CityRegionModel(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }

        public IList<Region> Region { get;set; }

        public async Task OnGetAsync()
        {
            Region = await _context.City.ToListAsync();
        }
    }
}
