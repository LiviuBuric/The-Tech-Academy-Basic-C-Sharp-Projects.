using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> campus = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Rogue" },
                new Employee { Id = 4, FirstName = "Billy", LastName = "Al" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 7, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 8, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 10, FirstName = "George", LastName = "Jetson" }
            };

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in bigId)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
