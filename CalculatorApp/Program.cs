using System;

namespace LinearOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line takes a string input from the user
            string input = Console.ReadLine();

            // This line converts the input to an integer
            int inputNumber;

            // This try-catch block will catch any exceptions that occur when trying to convert the input to an integer
            try
            {
                inputNumber = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Multiply the input by 50
            int multipliedNumber = inputNumber * 50;

            // Print the result to the console
            Console.WriteLine("The result of multiplying the input by 50 is: " + multipliedNumber);

            // Add 25 to the input
            int addedNumber = inputNumber + 25;

            // Print the result to the console
            Console.WriteLine("The result of adding 25 to the input is: " + addedNumber);

            // Divide the input by 12.5
            double dividedNumber = (double)inputNumber / 12.5;

            // Print the result to the console
            Console.WriteLine("The result of dividing the input by 12.5 is: " + dividedNumber);

            // Check if the input is greater than 50
            bool isGreater = inputNumber > 50;

            // Print the result to the console
            Console.WriteLine("The input is greater than 50: " + isGreater);

            // Divide the input by 7 and print the remainder
            int remainder = (int)(inputNumber % 7);

            // Print the remainder to the console
            Console.WriteLine("The remainder of the input divided by 7 is: " + remainder);

            // Keep the console window open to see the output
            Console.ReadLine();
        }
    }
}
