using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Bibliotek
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public string Role { get; set; }

        public Employee(int aId, string aName, int aAge, int aSalary, string aRole)
        {
            this.Id = aId;
            this.Name = aName;
            this.Age = aAge;
            this.Salary = aSalary;
            this.Role = aRole;
        }

        public void HelpCustomer(Customer CustomerObj)
        {
            CustomerObj.getsHelp(this);
        }

        public void getRaise(Employee EmployeeObj)
        {
            EmployeeObj.raiseSalary(this);
        }

        public void raiseSalary(Employee employeeObj)
        {
            Console.WriteLine($"{this.Name} höjer {employeeObj.Name}s lön med 1000 kronor från {employeeObj.Salary} till {employeeObj.Salary + 1000}");
        }
    }
}
