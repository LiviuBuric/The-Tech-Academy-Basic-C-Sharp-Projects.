using System;

namespace TimeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Current date and time: {currentTime}");

            // Ask the user for a number
            Console.Write("Please enter a whole number (X): ");
            string userInput = Console.ReadLine();

            // Validate if the input is a valid integer
            if (int.TryParse(userInput, out int hoursToAdd))
            {
                // Calculate the future time by adding X hours
                DateTime futureTime = currentTime.AddHours(hoursToAdd);
                Console.WriteLine($"In {hoursToAdd} hours, it will be: {futureTime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
            }
        }
    }
}

