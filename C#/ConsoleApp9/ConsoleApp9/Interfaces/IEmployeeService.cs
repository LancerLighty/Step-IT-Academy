using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Interfaces
{
    interface IEmployeeService
    {
        Employee Get(int id);
        List<Employee> GetAll();
        List<Employee> Create(Employee employee);
        List<Employee> Delete(int id);
        List<Employee> Update(Employee employee);

    }
}
