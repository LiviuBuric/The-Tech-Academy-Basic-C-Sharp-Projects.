using System;
using System.IO;

namespace NumberLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Validate if the input is a valid number
            if (double.TryParse(userInput, out double number))
            {
                // Define the file path where we'll log the number
                string filePath = @"C:\Users\awkbk4\Projects\log.txt";

                try
                {
                    // Open the file for appending (true indicates append mode)
                    using (StreamWriter fileWriter = new StreamWriter(filePath, true))
                    {
                        // Write the number to the file
                        fileWriter.WriteLine(number);
                    }

                    // Read the contents of the file and print it back to the user
                    Console.WriteLine("Number logged successfully!");
                    Console.WriteLine("Contents of the log file:");
                    Console.WriteLine(File.ReadAllText(filePath));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
