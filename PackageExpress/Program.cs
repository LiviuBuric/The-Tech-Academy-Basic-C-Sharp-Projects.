using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting with the welcome message and instructions
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get the package weight from the user
            Console.Write("Please enter the package weight: ");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package weight is greater than 50
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine(); // Pause the program
                return; // Exit the method
            }

            // Get the package width from the user
            Console.Write("Please enter the package width: ");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            // Get the package height from the user
            Console.Write("Please enter the package height: ");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            // Get the package length from the user
            Console.Write("Please enter the package length: ");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions
            decimal totalDimensions = packageWidth * packageHeight * packageLength;

            // Check if the total dimensions are greater than 50
            if (totalDimensions > 100000)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine(); // Pause the program
                return; // Exit the method
            }

            // Calculate the shipping quote
            decimal shippingQuote = (packageWeight * totalDimensions) / 100;

            // Display the shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");
            Console.WriteLine("Thank you!");

            // Wait for user to press a key before exiting
            Console.ReadLine();
        }
    }
}
