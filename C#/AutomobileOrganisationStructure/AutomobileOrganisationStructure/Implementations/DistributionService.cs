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
    internal class DistributionService : IDistribution
    {
        private List<Distribution> distribution = new List<Distribution>();
        public List<Distribution> Create(Distribution employee)
        {
            distribution.Add(employee);
            return distribution;
        }

        public List<Distribution> Delete(int employeeId)
        {
            Distribution? employee = distribution.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            distribution.Remove(employee);
            return distribution;
        }

        public Distribution Get(int employeeId)
        {
            Distribution? employee = distribution.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<Distribution> GetAll()
        {
            return distribution;
        }

        public List<Distribution> Update(Distribution employee)
        {
            Distribution? _distribution = distribution.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_distribution != null)
            {
                _distribution.FirstName = employee.FirstName;
                _distribution.LastName = employee.LastName;
                _distribution.Salary = employee.Salary;
                _distribution.WorkDesc = employee.WorkDesc;
            }
            return distribution;
        }
    }
}
