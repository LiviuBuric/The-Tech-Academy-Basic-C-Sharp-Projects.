using System;

namespace AbstractClassesAssignment
{
    // Create an interface called IQuittable with a Quit() method
    public interface IQuittable
    {
        void Quit();
    }

    // Modify the Employee class to inherit from Person and implement IQuittable
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} is quitting the job.");
        }

        public override void SayName() // added because of employee error
        {
            throw new NotImplementedException();
        }

        // Other properties and methods specific to Employee can be added here
    }
}
