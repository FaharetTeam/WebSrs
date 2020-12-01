using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSRS.Pages.Students
{
    public class StudentsModel : PageModel
    {
        private readonly IStudentRepository _st;
        public StudentsModel(IStudentRepository st)
        {
            _st = st;
        }

        public IEnumerable<Student> Students { get; set; }

        public void OnGet()
        {
            Students = _st.GetAllStudents();
        }
    }
}