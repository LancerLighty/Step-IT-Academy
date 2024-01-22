using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class Sales : Employee
    {
        public static string Desc = "sell products or services, aiming to meet revenue targets through prospecting, presenting, negotiating, and closing deals";
        public Sales(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
