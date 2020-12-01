using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Pages.Students
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudent(int Id);
        Student AppStudent(Student appdatedstudent);
    }
}
