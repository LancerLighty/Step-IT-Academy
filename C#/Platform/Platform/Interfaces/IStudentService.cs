using Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Interfaces
{
     interface IStudentService
    {
        Student Get(int studentId);
        List<Student> GetAll();
        List<Student> Create(Student student);
        List<Student> Delete(int studentId);
        List<Student> Update(Student student);
    }
}
