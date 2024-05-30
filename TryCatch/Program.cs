using System;

namespace AgeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Validate input: Ensure age is positive
                if (age <= 0)
                {
                    Console.WriteLine("Age must be a positive number.");
                    return;
                }

                // Calculate birth year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the birth year
                Console.WriteLine($"You were born in {birthYear}.");

                // Additional logic or functionality can be added here

                // General message (optional)
                Console.WriteLine("Age calculation completed successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

