using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    internal class Accountant : Employee
    {
        public static string Desc = "oversees financial records, analyzes reports, and ensures compliance with tax regulations";



        public Accountant(int employeeId, string firstName, string lastName, decimal salary) : base(employeeId, firstName, lastName, salary, Desc)
        {
        }
    }
}
