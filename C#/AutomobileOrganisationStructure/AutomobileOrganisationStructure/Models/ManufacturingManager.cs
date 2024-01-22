using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class ManufacturingManager : Employee
    {
        public static string Desc = "oversees and coordinates production processes, ensuring efficiency, quality, and adherence to production schedules within a manufacturing facility";
        public ManufacturingManager(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
