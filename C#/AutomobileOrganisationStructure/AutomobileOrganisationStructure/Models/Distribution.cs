using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class Distribution : Employee
    {
        public static string Desc = "manages the efficient movement of products from manufacturers to end-users, ensuring timely and accurate delivery";
        public Distribution(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
