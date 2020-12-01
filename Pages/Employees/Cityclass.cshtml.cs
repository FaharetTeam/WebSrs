using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSRS.Pages.Employees
{
    public class AlmatyModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public Employee Employ { get; private set; }

        public AlmatyModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult OnGet(int id)
        {
            Employ = _employeeRepository.GetEmployee(id);

            if (id == 0)
                return RedirectToPage("/Almaty");
            else if(id==1)
                return RedirectToPage("/Nursultan");
            else if (id == 2)
                return RedirectToPage("/Aktobe");
            else if (id == 3)
                return RedirectToPage("/Aktau");
            else if (id == 4)
                return RedirectToPage("/Atyrau");
            else if (id == 5)
                return RedirectToPage("/Karaganda");
            else if (id == 6)
                return RedirectToPage("/Kyzylorda");
            else if (id == 7)
                return RedirectToPage("/Pavlodar");
            else if (id == 8)
                return RedirectToPage("/Petropavl");
            else if (id == 9)
                return RedirectToPage("/Taldykorgan");
            else if (id == 10)
                return RedirectToPage("/Taraz");
            else if (id == 11)
                return RedirectToPage("/Uskemen");
            else if (id == 12)
                return RedirectToPage("/Ural");
            else if (id == 13)
                return RedirectToPage("/Shymkent");
            return Page();
        }
    }
}