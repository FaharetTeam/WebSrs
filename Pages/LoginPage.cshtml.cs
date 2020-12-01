using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSRS.Models;

namespace WebSRS.Pages
{
    public class LoginPageModel : PageModel
    {

        private readonly WebSRS.Contexts.MyDbContext _context;

        public LoginPageModel(WebSRS.Contexts.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public Account Account { get; set; }

        public async Task<IActionResult> OnPostAsync(string Login, string Password)
        {
            Account = await _context.Accounts.FirstOrDefaultAsync(m => m.Login == Login && m.Password==Password);
            if(Account==null)
            {
                HttpContext.Session.SetString("LoginState", "ERROR");
                return Page();
            }
            HttpContext.Session.SetString("LoginState", "OK");
            HttpContext.Session.SetInt32("ID", Account.Id);
            HttpContext.Session.SetString("Login", Account.Login);
            return Page();
        }

        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return Page();
        }
    }
}
