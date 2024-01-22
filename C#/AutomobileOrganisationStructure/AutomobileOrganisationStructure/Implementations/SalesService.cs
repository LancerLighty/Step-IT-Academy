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
    internal class SalesService : ISales
    {
        private List<Sales> sales = new List<Sales>();
        public List<Sales> Create(Sales employee)
        {
            sales.Add(employee);
            return sales;
        }

        public List<Sales> Delete(int employeeId)
        {
            Sales? employee = sales.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            sales.Remove(employee);
            return sales;
        }

        public Sales Get(int employeeId)
        {
            Sales? employee = sales.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (employee == null)
            {
                throw new Exception("employee not found");
            }
            return employee;
        }

        public List<Sales> GetAll()
        {
            return sales;
        }

        public List<Sales> Update(Sales employee)
        {
            Sales? _sales = sales.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_sales != null)
            {
                _sales.FirstName = employee.FirstName;
                _sales.LastName = employee.LastName;
                _sales.Salary = employee.Salary;
                _sales.WorkDesc = employee.WorkDesc;
            }
            return sales;
        }
    }
}
