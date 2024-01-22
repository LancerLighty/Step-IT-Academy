using AutomobileOrganisationStructure.Interfaces;
using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomobileOrganisationStructure.Implementations
{
    internal class LineSupervisorsService : ILineSupervisors
    {
        private List<LineSupervisors> lineSupervisors = new List<LineSupervisors>();
        public List<LineSupervisors> Create(LineSupervisors employee)
        {
            lineSupervisors.Add(employee);
            return lineSupervisors;
        }

        public List<LineSupervisors> Delete(int employeeId)
        {
            LineSupervisors? employee = lineSupervisors.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            lineSupervisors.Remove(employee);
            return lineSupervisors;
        }

        public LineSupervisors Get(int employeeId)
        {
            LineSupervisors? employee = lineSupervisors.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<LineSupervisors> GetAll()
        {
            return lineSupervisors;
        }

        public List<LineSupervisors> Update(LineSupervisors employee)
        {
            LineSupervisors? _lineSupervisors = lineSupervisors.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_lineSupervisors != null)
            {
                _lineSupervisors.FirstName = employee.FirstName;
                _lineSupervisors.LastName = employee.LastName;
                _lineSupervisors.Salary = employee.Salary;
                _lineSupervisors.WorkDesc = employee.WorkDesc;
            }
            return lineSupervisors;
        }
    }
}
