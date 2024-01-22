using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface ILineSupervisors
    {
        LineSupervisors Get(int employeeId);
        List<LineSupervisors> GetAll();
        List<LineSupervisors> Create(LineSupervisors lineSupervisors);
        List<LineSupervisors> Delete(int employeeId);
        List<LineSupervisors> Update(LineSupervisors lineSupervisors);
    }
}
