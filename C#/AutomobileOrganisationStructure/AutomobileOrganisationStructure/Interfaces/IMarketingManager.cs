using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IMarketingManager
    {
        MarketingManager Get(int employeeId);
        List<MarketingManager> GetAll();
        List<MarketingManager> Create(MarketingManager marketingManager);
        List<MarketingManager> Delete(int employeeId);
        List<MarketingManager> Update(MarketingManager marketingManager);
    }
}
