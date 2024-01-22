using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IAccountant
    {
        Accountant Get(int employeeId);
        List<Accountant> GetAll();
        List<Accountant> Create(Accountant employee);
        List<Accountant> Delete(int employeeId);
        List<Accountant> Update(Accountant employee);
    }
}
