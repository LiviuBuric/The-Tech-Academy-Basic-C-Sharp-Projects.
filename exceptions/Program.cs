using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of integers
        List<int> InvalidList = new List<int> { 5, 99, 23, 18, 15, 22, 234, 1994 }; // Fixed the list initialization

        int Divide = 7000; // Corrected the value for division

        Console.WriteLine("Loop through the list dividing each number by 7000:");

        foreach (int num in InvalidList)
        {
            try
            {
                Console.WriteLine($"{num} / {Divide} = {num / (float)Divide}"); // Added casting to float for accurate division
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid input for dividing");
            }
        }

        try
        {
            Console.WriteLine("Enter a number to divide:");
            float userInput = float.Parse(Console.ReadLine());

            if (userInput <= 0) // Assumed user input should be greater than 0
                throw new Exception("Please enter a positive number.");

            // Additional logic based on user input can be added here

            Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
