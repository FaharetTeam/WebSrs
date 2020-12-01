using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Models;

namespace WebSRS.Pages
{
    public class CitiesModel : PageModel
    {
        private readonly WebSRS.Contexts.MyDbContext _context;

        public CitiesModel(WebSRS.Contexts.MyDbContext context)
        {
            _context = context;
        }

        public IList<City> City { get; set; }

        public async Task OnGetAsync()
        {
            City = await _context.Cities.ToListAsync();
        }
    }
}
