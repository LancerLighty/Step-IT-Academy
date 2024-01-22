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
    internal class ProductionTeamsService : IProductionTeams
    {
        private List<ProductionTeams> productionTeams = new List<ProductionTeams>();
        public List<ProductionTeams> Create(ProductionTeams employee)
        {
            productionTeams.Add(employee);
            return productionTeams;
        }

        public List<ProductionTeams> Delete(int employeeId)
        {
            ProductionTeams? employee = productionTeams.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            productionTeams.Remove(employee);
            return productionTeams;
        }

        public ProductionTeams Get(int employeeId)
        {
            ProductionTeams? employee = productionTeams.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<ProductionTeams> GetAll()
        {
            return productionTeams;
        }

        public List<ProductionTeams> Update(ProductionTeams employee)
        {
            ProductionTeams? _productionTeams = productionTeams.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_productionTeams != null)
            {
                _productionTeams.FirstName = employee.FirstName;
                _productionTeams.LastName = employee.LastName;
                _productionTeams.Salary = employee.Salary;
                _productionTeams.WorkDesc = employee.WorkDesc;
            }
            return productionTeams;
        }
    }
}
