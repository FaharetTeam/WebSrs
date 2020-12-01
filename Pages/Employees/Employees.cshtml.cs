using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSRS.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
       
        private readonly IEmployeeRepository _db;
        public EmployeesModel(IEmployeeRepository db)
        {
            _db=db;
        }

        [BindProperty(SupportsGet = true)]
        public IEnumerable<Employee> Employees { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }


        public void OnGet()
        {
           Employees = _db.Search(SearchTerm);
        }

    }
}