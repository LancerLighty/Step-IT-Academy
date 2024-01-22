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
    internal class CustomerServiceService : ICustomerService
    {
        private List<CustomerService> customerService = new List<CustomerService>();
        public List<CustomerService> Create(CustomerService employee)
        {
            customerService.Add(employee);
            return customerService;
        }

        public List<CustomerService> Delete(int employeeId)
        {
            CustomerService? _customerService = customerService.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (_customerService == null)
            {
                throw new Exception("employee not found");
            }
            customerService.Remove(_customerService);
            return customerService;
        }

        public CustomerService Get(int employeeId)
        {
            CustomerService? _customerService = customerService.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (_customerService == null)
            {
                throw new Exception("employee not found");
            }
            return _customerService;
        }

        public List<CustomerService> GetAll()
        {
            return customerService;
        }

        public List<CustomerService> Update(CustomerService employee)
        {
            CustomerService? _customerService = customerService.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (_customerService != null)
            {
                _customerService.FirstName = employee.FirstName;
                _customerService.LastName = employee.LastName;
                _customerService.Salary = employee.Salary;
                _customerService.WorkDesc = employee.WorkDesc;
            }
            return customerService;
        }
    }
}
