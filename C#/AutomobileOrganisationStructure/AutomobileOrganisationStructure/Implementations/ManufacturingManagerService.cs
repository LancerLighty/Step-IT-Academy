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
    internal class ManufacturingManagerService : IManufacturingManager
    {
        private List<ManufacturingManager> manufacturingManager = new List<ManufacturingManager>();
        public List<ManufacturingManager> Create(ManufacturingManager employee)
        {
            manufacturingManager.Add(employee);
            return manufacturingManager;
        }

        public List<ManufacturingManager> Delete(int employeeId)
        {
            ManufacturingManager? employee = manufacturingManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            manufacturingManager.Remove(employee);
            return manufacturingManager;
        }

        public ManufacturingManager Get(int employeeId)
        {
            ManufacturingManager? employee = manufacturingManager.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<ManufacturingManager> GetAll()
        {
            return manufacturingManager;
        }

        public List<ManufacturingManager> Update(ManufacturingManager employee)
        {
            ManufacturingManager? _manufacturingManager = manufacturingManager.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_manufacturingManager != null)
            {
                _manufacturingManager.FirstName = employee.FirstName;
                _manufacturingManager.LastName = employee.LastName;
                _manufacturingManager.Salary = employee.Salary;
                _manufacturingManager.WorkDesc = employee.WorkDesc;
            }
            return manufacturingManager;
        }
    }
}
