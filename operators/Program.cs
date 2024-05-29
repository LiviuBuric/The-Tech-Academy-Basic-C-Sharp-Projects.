using System;

namespace EmployeeApp
{
    // Define the Employee class
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the equality operator (==)
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null or reference the same object
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either object is null, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id property for equality
            return emp1.Id == emp2.Id;
        }

        // Overload the inequality operator (!=)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the negation of the equality operator
            return !(emp1 == emp2);
        }

        // Override the Equals method (optional but recommended)
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
                return this.Id == otherEmployee.Id;
            return false;
        }

        // Override GetHashCode for consistency (optional but recommended)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects
            var emp1 = new Employee(1, "John", "Doe");
            var emp2 = new Employee(1, "Jane", "Smith");

            // Check equality using overloaded operator
            Console.WriteLine($"Are emp1 and emp2 equal? {emp1 == emp2}");

            // Check inequality using overloaded operator
            Console.WriteLine($"Are emp1 and emp2 not equal? {emp1 != emp2}");
        }
    }
}
