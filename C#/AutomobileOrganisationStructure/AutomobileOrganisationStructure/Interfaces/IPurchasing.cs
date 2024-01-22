using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IPurchasing
    {
        Purchasing Get(int employeeId);
        List<Purchasing> GetAll();
        List<Purchasing> Create(Purchasing purchasing);
        List<Purchasing> Delete(int employeeId);
        List<Purchasing> Update(Purchasing purchasing);
    }
}
