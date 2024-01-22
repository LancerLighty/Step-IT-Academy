using AutomobileOrganisationStructure.Interfaces;
using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Implementations
{
    internal class FinanceManagerService : IFinanceManager
    {
        private List<FinanceManager> financeManager = new List<FinanceManager>();
        public List<FinanceManager> Create(FinanceManager employee)
        {
            financeManager.Add(employee);
            return financeManager;
        }

        public List<FinanceManager> Delete(int employeeId)
        {
            FinanceManager? employee = financeManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            financeManager.Remove(employee);
            return financeManager;
        }

        public FinanceManager Get(int employeeId)
        {
            FinanceManager? employee = financeManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<FinanceManager> GetAll()
        {
            return financeManager;
        }

        public List<FinanceManager> Update(FinanceManager employee)
        {
            FinanceManager? _financeManager = financeManager.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_financeManager != null)
            {
                _financeManager.FirstName = employee.FirstName;
                _financeManager.LastName = employee.LastName;
                _financeManager.Salary = employee.Salary;
                _financeManager.WorkDesc = employee.WorkDesc;
            }
            return financeManager;
        }
    }
}
