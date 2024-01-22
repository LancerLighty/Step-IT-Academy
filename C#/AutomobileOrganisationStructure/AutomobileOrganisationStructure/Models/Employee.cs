using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileOrganisationStructure.Models
{
    class Employee
    {
        public int EmployeeId {  get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public decimal Salary { get; set; }
        public string WorkDesc { get; set; }
        public Employee(int employeeId, string firstName, string lastName, decimal salary, string workDesc)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            WorkDesc = workDesc;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Salary: {Salary}GEL");
        }
    }
}
