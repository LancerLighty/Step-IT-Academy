using Platform.Interfaces;
using Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Implementations
{
    internal class StudentService : IStudentService
    {
        private List<Student> students = new List<Student>();
        public List<Student> Create(Student student)
        {
            students.Add(student);
            return students;
        }

        public List<Student> Delete(int studentId)
        {
            Student? student = students.FirstOrDefault(x => x.StudentId == studentId);
            if (student == null)
            {
                throw new Exception("client not found");
            }
            students.Remove(student);
            return students;
        }

        public Student Get(int studentId)
        {
            Student? student = students.FirstOrDefault(x => x.StudentId == studentId);
            if (student == null)
            {
                throw new Exception("client not found");
            }
            return student;
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public List<Student> Update(Student student)
        {
            Student? student1 = students.FirstOrDefault(x => x.StudentId == student.StudentId);
            if (student1 != null)
            {
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.StudentId = student.StudentId;
                student1.Grade = student.Grade;
            }
            return students;
        }
    }
}
