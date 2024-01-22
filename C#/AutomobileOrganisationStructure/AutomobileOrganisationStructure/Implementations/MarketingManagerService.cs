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
    internal class MarketingManagerService : IMarketingManager
    {
        private List<MarketingManager> marketingManager = new List<MarketingManager>();
        public List<MarketingManager> Create(MarketingManager employee)
        {
            marketingManager.Add(employee);
            return marketingManager;
        }

        public List<MarketingManager> Delete(int employeeId)
        {
            MarketingManager? employee = marketingManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            marketingManager.Remove(employee);
            return marketingManager;
        }

        public MarketingManager Get(int employeeId)
        {
            MarketingManager? employee = marketingManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<MarketingManager> GetAll()
        {
            return marketingManager;
        }

        public List<MarketingManager> Update(MarketingManager employee)
        {
            MarketingManager? _marketingManager = marketingManager.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_marketingManager != null)
            {
                _marketingManager.FirstName = employee.FirstName;
                _marketingManager.LastName = employee.LastName;
                _marketingManager.Salary = employee.Salary;
                _marketingManager.WorkDesc = employee.WorkDesc;
            }
            return marketingManager;
        }
    }
}
