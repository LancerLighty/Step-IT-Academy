using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class LineSupervisors : Employee
    {
        public static string Desc = "manage and oversee day-to-day operations on the production line, ensuring efficiency, quality, and adherence to safety protocols";

        public LineSupervisors(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
