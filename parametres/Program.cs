using System;
using System.Collections.Generic;

namespace GenericEmployeeApp
{
    // Define the Employee class with a generic type parameter
    public class Employee<T>
    {
        // Properties
        public List<T> Things { get; set; } // A generic list to store "things"

        // Constructor initializes the list
        public Employee()
        {
            Things = new List<T>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string"
            var stringEmployee = new Employee<string>();
            stringEmployee.Things.Add("Laptop");
            stringEmployee.Things.Add("Notebook");
            stringEmployee.Things.Add("Pen");

            // Instantiate an Employee object with type "int"
            var intEmployee = new Employee<int>();
            intEmployee.Things.Add(42);
            intEmployee.Things.Add(123);
            intEmployee.Things.Add(987);

            // Print all "things" for the stringEmployee
            Console.WriteLine("String Employee's Things:");
            foreach (var item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            // Print all "things" for the intEmployee
            Console.WriteLine("\nInt Employee's Things:");
            foreach (var item in intEmployee.Things)
            {
                Console.WriteLine(item);
            }
        }
    }
}
