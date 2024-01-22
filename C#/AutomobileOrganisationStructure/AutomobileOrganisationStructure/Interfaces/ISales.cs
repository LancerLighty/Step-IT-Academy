using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface ISales
    {
        Sales Get(int employeeId);
        List<Sales> GetAll();
        List<Sales> Create(Sales sales);
        List<Sales> Delete(int employeeId);
        List<Sales> Update(Sales sales);
    }
}
