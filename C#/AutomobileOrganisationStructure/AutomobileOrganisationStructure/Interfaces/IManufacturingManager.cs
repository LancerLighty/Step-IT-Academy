using AutomobileOrganisationStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Interfaces
{
    internal interface IManufacturingManager
    {
        ManufacturingManager Get(int employeeId);
        List<ManufacturingManager> GetAll();
        List<ManufacturingManager> Create(ManufacturingManager manufacturingManager);
        List<ManufacturingManager> Delete(int employeeId);
        List<ManufacturingManager> Update(ManufacturingManager manufacturingManager);
    }
}
