using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IDistribution
    {
        Distribution Get(int employeeId);
        List<Distribution> GetAll();
        List<Distribution> Create(Distribution employee);
        List<Distribution> Delete(int employeeId);
        List<Distribution> Update(Distribution employee);
    }
}
