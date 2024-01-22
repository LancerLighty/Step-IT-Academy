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
    internal class AccountantService : IAccountant
    {
        private List<Accountant> accountant = new List<Accountant>()
        {
                new Accountant(1, "John", "Doe", 50000),
        };
        public List<Accountant> Create(Accountant _accountant)
        {
            accountant.Add(_accountant);
            return accountant;
        }

        public List<Accountant> Delete(int employeeId)
        {
            Accountant? employee = accountant.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            accountant.Remove(employee);
            return accountant;
        }

        public Accountant Get(int employeeId)
        {
            Accountant? _accountant = accountant.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (_accountant == null)
            {
                throw new Exception("employee not found");
            }
            return _accountant;
        }

        public List<Accountant> GetAll()
        {
            return accountant;
        }

        public List<Accountant> Update(Accountant _accountant)
        {
            Accountant? employee = accountant.FirstOrDefault(x => x.EmployeeId == _accountant.EmployeeId);
            if (employee != null)
            {
                employee.FirstName = _accountant.FirstName;
                employee.LastName = _accountant.LastName;
                employee.Salary = _accountant.Salary;
                employee.WorkDesc = _accountant.WorkDesc;
            }
            return accountant;
        }
    }
}
