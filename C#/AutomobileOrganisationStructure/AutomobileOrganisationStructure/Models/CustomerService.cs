using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class CustomerService : Employee
    {
        public static string Desc = "assisting and addressing the needs of customers";

        public CustomerService(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
