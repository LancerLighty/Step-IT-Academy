using AutomobileOrganisationStructure.Implementations;
using AutomobileOrganisationStructure.Interfaces;
using AutomobileOrganisationStructure.Models;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hi there!");
                Console.WriteLine("Who would you like to search?");
                Console.WriteLine("accountant,customerservice,distributon,financemanager, linesupervisors, " +
                    "manufacturingmanager, marketingmanager,productionteams, purchasing or sales?");
                string employee = Console.ReadLine().ToLower();
                while(employee != "accountant" && employee != "customerservice" && employee != "distributon" && employee != "financemanager" &&
                     employee != "linesupervisors" && employee != "manufacturingmanager" && employee != "marketingmanager" && employee != "productionteams" &&
                     employee != "purchasing" && employee != "sales")
                {
                    Console.WriteLine(" Please Enter: accountant,customerservice,distributon,financemanager, linesupervisors, " +
                    "manufacturingmanager, marketingmanager,productionteams, purchasing or sales");
                    employee = Console.ReadLine().ToLower();
                }
                var makeEmployee = CreateEmployeeService(employee);
                if(makeEmployee == null)
                {
                    Console.WriteLine("Something went wrong-");
                } else
                {
                    Console.WriteLine($"enter {employee}'s Id to search employee!(numbers)");
                    int id = int.Parse(Console.ReadLine());
                    if (makeEmployee is AccountantService)
                    {
                        AccountantService accountantService = (AccountantService)makeEmployee;
                        var findEmployee = accountantService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is CustomerServiceService)
                    {
                        CustomerServiceService customerService = (CustomerServiceService)makeEmployee;
                        var findEmployee = customerService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is DistributionService)
                    {
                        DistributionService distributionService = (DistributionService)makeEmployee;
                        var findEmployee = distributionService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is FinanceManagerService)
                    {
                        FinanceManagerService financeManagerService = (FinanceManagerService)makeEmployee;
                        var findEmployee = financeManagerService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is LineSupervisorsService)
                    {
                        LineSupervisorsService lineSupervisorsService = (LineSupervisorsService)makeEmployee;
                        var findEmployee = lineSupervisorsService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is ManufacturingManagerService)
                    {
                        ManufacturingManagerService manufacturingManagerService = (ManufacturingManagerService)makeEmployee;
                        var findEmployee = manufacturingManagerService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is MarketingManagerService)
                    {
                        MarketingManagerService marketingManagerService = (MarketingManagerService)makeEmployee;
                        var findEmployee = marketingManagerService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is ProductionTeamsService)
                    {
                        ProductionTeamsService productionTeamsService = (ProductionTeamsService)makeEmployee;
                        var findEmployee = productionTeamsService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is PurchasingService)
                    {
                        PurchasingService purchasingService = (PurchasingService)makeEmployee;
                        var findEmployee = purchasingService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else if (makeEmployee is SalesService)
                    {
                        SalesService salesService = (SalesService)makeEmployee;
                        var findEmployee = salesService.Get(id);
                        Console.WriteLine($"id: {findEmployee.EmployeeId} FirstName : {findEmployee.FirstName} " +
                            $"LastName: {findEmployee.LastName} Salary: {findEmployee.Salary}GEL WorkDesc: {findEmployee.WorkDesc} ");
                    }
                    else
                    {
                        Console.WriteLine($"Get method not supported for {employee}");
                    }
                    Console.WriteLine("Task Complete.");
                }
            
            
        }
    }
    public static object CreateEmployeeService(string employee)
    {
            switch (employee)
            {
            case "accountant":
                return new AccountantService();
            case "customerservice":
                return new CustomerServiceService();
            case "distribution":
                return new DistributionService();
            case "financemanager":
                return new FinanceManagerService();
            case "linesupervisors":
                return new LineSupervisorsService();
            case "manufacturingmanager":
                return new ManufacturingManagerService();
            case "marketingmanager":
                return new MarketingManagerService();
            case "productionteams":
                return new ProductionTeamsService();
            case "purchasing":
                return new PurchasingService();
            case "sales":
                return new SalesService();
            default:
                return null;
        }
    }
    
}