using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IProductionTeams
    {
        ProductionTeams Get(int employeeId);
        List<ProductionTeams> GetAll();
        List<ProductionTeams> Create(ProductionTeams productionTeams);
        List<ProductionTeams> Delete(int employeeId);
        List<ProductionTeams> Update(ProductionTeams productionTeams);
    }
}
