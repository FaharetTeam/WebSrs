using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSRS.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IStudentRepository _studentsRepository;
        public DetailsModel(IStudentRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public Student Stud { get; private set; }

        public void OnGet(int Id)
        {
            Stud = _studentsRepository.GetStudent(Id);
        }
    }
}