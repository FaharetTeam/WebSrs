using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webka.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly MockEmployeeRepository _db;
        public EmployeesModel(MockEmployeeRepository db)
        {
            _db=db;
        }


        public IEnumerable<Employee> Employees { get; set; }
        public void OnGet()
        {
           Employees = _db.AllEmployees();
        }
    }
}