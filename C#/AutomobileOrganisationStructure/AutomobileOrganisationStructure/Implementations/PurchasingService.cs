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
    internal class PurchasingService : IPurchasing
    {
        private List<Purchasing> purchasing = new List<Purchasing>();
        public List<Purchasing> Create(Purchasing employee)
        {
            purchasing.Add(employee);
            return purchasing;
        }

        public List<Purchasing> Delete(int employeeId)
        {
            Purchasing? employee = purchasing.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            purchasing.Remove(employee);
            return purchasing;
        }

        public Purchasing Get(int employeeId)
        {
            Purchasing? employee = purchasing.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<Purchasing> GetAll()
        {
            return purchasing;
        }

        public List<Purchasing> Update(Purchasing employee)
        {
            Purchasing? _purchasing = purchasing.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_purchasing != null)
            {
                _purchasing.FirstName = employee.FirstName;
                _purchasing.LastName = employee.LastName;
                _purchasing.Salary = employee.Salary;
                _purchasing.WorkDesc = employee.WorkDesc;
            }
            return purchasing;
        }
    }
}
