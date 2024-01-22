using Platform.Interfaces;
using Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Implementations
{
    internal class TeacherService : ITeacherService
    {
        private List<Teacher> teachers = new List<Teacher>();
        public List<Teacher> Create(Teacher teacher)
        {
            teachers.Add(teacher);
            return teachers;
        }

        public List<Teacher> Delete(int teacherId)
        {
            Teacher? teacher = teachers.FirstOrDefault(x => x.TeacherId == teacherId);
            if (teacher == null)
            {
                throw new Exception("client not found");
            }
            teachers.Remove(teacher);
            return teachers;
        }

        public Teacher Get(int teacherId)
        {
            Teacher? teacher = teachers.FirstOrDefault(x => x.TeacherId == teacherId);
            if (teacher == null)
            {
                throw new Exception("client not found");
            }
            return teacher;
        }

        public List<Teacher> GetAll()
        {
            return teachers;
        }

        public List<Teacher> Update(Teacher teacher)
        {
            Teacher? teacher1 = teachers.FirstOrDefault(x => x.TeacherId == teacher.TeacherId);
            if (teacher1 != null)
            {
                teacher1.FirstName = teacher.FirstName;
                teacher1.LastName = teacher.LastName;
                teacher1.TeacherId = teacher.TeacherId;
                teacher1.Subject = teacher.Subject;
            }
            return teachers;
        }
    }
}
