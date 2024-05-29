//Program.cs
using System;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            // Create an Employee object
            Employee employee = new Employee
            {
                firstName = "John",
                lastName = "Doe"
            };

            // Use polymorphism to call the Quit() method on the IQuittable object
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            Console.ReadLine();
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}