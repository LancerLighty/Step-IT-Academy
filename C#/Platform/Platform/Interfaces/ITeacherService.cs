using Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Interfaces
{
    interface ITeacherService
    {
        Teacher Get(int teacherId);
        List<Teacher> GetAll();
        List<Teacher> Create(Teacher teacher);
        List<Teacher> Delete(int teacherId);
        List<Teacher> Update(Teacher teacher);
    }
}
