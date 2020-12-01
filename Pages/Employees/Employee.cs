using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Pages.Employees
{
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        public string PhotoPath { get; set; }


    }
}
