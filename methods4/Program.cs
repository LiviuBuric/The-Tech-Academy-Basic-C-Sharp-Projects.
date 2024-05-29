using System;

namespace ClassName
{
    class Program
    {
        static void Main(string[] arguments)
        {
            // Initialize the variables
            Console.WriteLine("Input a number:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another number:");
            int count = Convert.ToInt32(Console.ReadLine());

            // Do the math with those variables
            int added = value + count;
            Console.WriteLine("Output phrase:");
            string phrase = Console.ReadLine();

            // What would be the output?
            Console.WriteLine("Added would be: " + (value + count));

            // String related things
            int index = phrase.IndexOf("is");

            // Output some more stuff about strings
            Console.WriteLine("The input phrase was: " + phrase.Length + " characters long");

            // More string related things
            if (index >= 0)
            {
                Console.WriteLine("'is' is at index " + index);
            }

            int count_is = CountStringOccurrences(phrase, "is");
            Console.WriteLine("'is' in this instance has occurred " + count_is + " times.");

            Console.ReadLine();
        }

        // Helper method to count occurrences of a substring in a string
        static int CountStringOccurrences(string text, string substring)
        {
            return (text.Length - text.Replace(substring, "").Length) / substring.Length;
        }
    }
}
