using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface ICustomerService
    {
        CustomerService Get(int employeeId);
        List<CustomerService> GetAll();
        List<CustomerService> Create(CustomerService employee);
        List<CustomerService> Delete(int employeeId);
        List<CustomerService> Update(CustomerService employee);
    }
}
