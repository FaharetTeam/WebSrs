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
    public class Index2Model : PageModel
    {
        private readonly WebSRS.Pages.AppDbContext _context;

        public Index2Model(WebSRS.Pages.AppDbContext context)
        {
            _context = context;
        }
        
    }
}
