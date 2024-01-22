using ConsoleApp9.Interfaces;
using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Implemetations
{
    class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public List<Employee> Create(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> Delete(int id)
        {
            Employee? employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                throw new Exception("client not found");
            }
            employees.Remove(employee);
            return employees;
        }

        public Employee Get(int id)
        {
            Employee? employee = employees.FirstOrDefault(x => x.Id == id);
            if(employee == null)
            {
                throw new Exception("not found");
            }
            return employee;
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public List<Employee> Update(Employee employee)
        {
            Employee? employeeq = employees.FirstOrDefault(x => x.Id == employee.id);
            if (employeeq != null)
            {
                employeeq.FirstName = employee.FirstName;
                employeeq.LastName = employee.LastName;
            }
                return employees;
        }
    }
}
