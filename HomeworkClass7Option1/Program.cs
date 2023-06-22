using System.Security.Cryptography.X509Certificates;

namespace HomeworkClass7Option1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Petar Petrovic",
                Age = 35,
                Department = "IT"
            };

            Employee employee2 = new Employee()
            {
                Name = "Marko Markovic",
                Age = 40,
                Department = "IT"
            };

            Contractor contractor = new Contractor()
            {
                Name = "Nenad Nenadic",
                Age= 27,
                Department = "Marketing",
                WorkHours = 40.5,
                PayPerHour = 25,
               
                Responsible = new Manager
                {
                    Name = "Milan Mitic",
                    Department = "HR"
                }
            };

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Employee 1: ");
            Console.ResetColor();
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Department: {employee.Department}");
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Employee 2: ");
            Console.ResetColor();
            Console.WriteLine($"Name: {employee2.Name}");
            Console.WriteLine($"Age: {employee2.Age}");
            Console.WriteLine($"Department: {employee2.Department}");
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Contractor: ");
            Console.ResetColor();
            Console.WriteLine($"Name: {contractor.Name}");
            Console.WriteLine($"Age: {contractor.Age}");
            Console.WriteLine($"Department: {contractor.Department}");
            Console.WriteLine($"Work Hours: {contractor.WorkHours}");
            Console.WriteLine($"Pay per Hours: {contractor.PayPerHour}");
            Console.WriteLine($"Salary: " + contractor.GetSalary());
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Responsible Manager: {contractor.Responsible.Name}");
            Console.WriteLine($"Manager's department: {contractor.Responsible.Department}");
            Console.ResetColor();
        }
    }
}