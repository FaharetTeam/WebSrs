using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Pages.Students
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student()
                {
                    id=1, name="Farkhad",lastname="Mukhangaliyev", email="faharet@gmail.com", photo="fa.jpg",number="+7 707 768 2477"
                },
                 new Student()
                {
                    id=2, name="Dilnaz", lastname="Kalieva",email="9k2dil16@gmail.com", photo="didi.jpg",number="+7 747 121 5785"
                },
            };
        }

        public Student AppStudent(Student appdatedstudent)
        {
            Student studen = _studentList.FirstOrDefault(x => x.id == appdatedstudent.id);

            if (studen != null)
            {
                studen.lastname = appdatedstudent.lastname;
                studen.name = appdatedstudent.name;
                studen.email = appdatedstudent.email;
                studen.number = appdatedstudent.number;
                studen.photo = appdatedstudent.photo;
            }
            return studen;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(x => x.id == Id);
        }
    }
}
