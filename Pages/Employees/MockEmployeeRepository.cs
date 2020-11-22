using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webka.Pages.Employees;

namespace webka.Pages.Employees
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id=0, Name="Almaty", PhotoPath="ALA.jpg"
                },
                 new Employee()
                {
                    Id=1, Name="Nursultan",  PhotoPath="nursultan1.jpg"
                },
                  new Employee()
                {
                    Id=2, Name="Aktobe", PhotoPath="AKX2.jpg"
                },
                   new Employee()
                {
                    Id=3, Name="Aktau", PhotoPath="aktau.jpg"
                },
                    new Employee()
                {
                    Id=4, Name="Atyrau", PhotoPath="atyrau.jpg"
                },
                     new Employee()
                {
                    Id=5, Name="Karaganda", PhotoPath="karaganda.jpg"
                },
                 new Employee()
                {
                    Id=6, Name="Kyzylorda", PhotoPath="kyzylorda.jpg"
                },
                  new Employee()
                {
                    Id=7, Name="Pavlodar", PhotoPath="pavlodar1.jpg"
                },
                   new Employee()
                {
                    Id=8, Name="Petropavlsk", PhotoPath="petropavl.jpg"
                },
                    new Employee()
                {
                    Id=9, Name="Taldykorgan", PhotoPath="taldykorgan.jpg"
                },
                     new Employee()
                {
                    Id=10, Name="Taraz", PhotoPath="taraz.jpg"
                },
                 new Employee()
                {
                    Id=11, Name="Uskemen", PhotoPath="uskemen.jpg"
                },
                  new Employee()
                {
                    Id=12, Name="Ural", PhotoPath="ural1.jpg"
                },
                   new Employee()
                {
                    Id=13, Name="Shymkent", PhotoPath="shymkent1.jpg"
                }
            };
        }


       public  IEnumerable<Pages.Employees.Employee> AllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
