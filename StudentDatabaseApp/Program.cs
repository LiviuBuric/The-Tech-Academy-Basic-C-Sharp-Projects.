using System;
using System.Data.Entity;
using System.Linq;
using StudentDatabaseApp.Models;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set database initialization strategy
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentContext>());

            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Age = 22
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                // Retrieve the student from the database
                var savedStudent = context.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
                if (savedStudent != null)
                {
                    Console.WriteLine($"Student saved: {savedStudent.FirstName} {savedStudent.LastName}, Age: {savedStudent.Age}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}