using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IFinanceManager
    {
        FinanceManager Get(int employeeId);
        List<FinanceManager> GetAll();
        List<FinanceManager> Create(FinanceManager financeManager);
        List<FinanceManager> Delete(int employeeId);
        List<FinanceManager> Update(FinanceManager financeManager);
    }

}
