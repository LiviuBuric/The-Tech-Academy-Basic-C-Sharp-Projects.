using System;

namespace NumberApp
{
    // Define a struct called Number
    public struct Number
    {
        // Property: Amount (of data type decimal)
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number and initialize it
            Number myNumber = new Number();

            // Assign an amount (e.g., 123.45) to the Amount property
            myNumber.Amount = 123.45M; // M suffix indicates decimal literal

            // Print the amount to the console
            Console.WriteLine($"Amount: {myNumber.Amount}");
        }
    }
}