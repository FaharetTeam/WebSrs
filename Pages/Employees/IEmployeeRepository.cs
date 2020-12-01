using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Pages.Employees
{
    public interface IEmployeeRepository
    {
        IEnumerable<Pages.Employees.Employee> AllEmployees();

        Employee GetEmployee(int id);
        IEnumerable<Pages.Employees.Employee> Search(string searchTerm);

    }
}
