using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class ProductionTeams : Employee
    {
        public static string Desc = "work together to efficiently manufacture products, ensuring quality, meeting deadlines, and maintaining safety";
        public ProductionTeams(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
