using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            double weight;
            double width;
            double height;
            double length;

        StartOver:

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight (in pounds): ");

            // Validate weight input (loop until valid numeric value is entered)
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for weight.");
            }

            // Check if the package is too heavy to be shipped
            if (weight > 50)
            {
                // Display the error message and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt the user for the package dimensions
            Console.Write("Please enter the package width (in inches): ");

            // Validate width input (similar loop as for weight)
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for width.");
            }

            Console.Write("Please enter the package height (in inches): ");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for height.");
            }

            Console.Write("Please enter the package length (in inches): ");
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for length.");
            }

            // Calculate the overall dimensions
            double dimensions = width + height + length;

            // Check if the package is too big to be shipped
            if (dimensions > 50)
            {
                // Display the error message and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the shipping quote
            double quote = (weight * (width * height * length)) / 100;

            // Display the shipping quote to the user with explanation
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:C2} (based on weight and package volume).");
            Console.WriteLine("Thank you!");
        }
    }
}
