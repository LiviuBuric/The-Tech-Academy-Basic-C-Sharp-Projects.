using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string firstName = "John";
            string lastName = "Doe";
            string greeting = "Hello, my name is ";
            string fullName = greeting + firstName + " " + lastName;
            Console.WriteLine(fullName);

            // Convert a string to uppercase
            string message = "This is a message.";
            string upperCaseMessage = message.ToUpper();
            Console.WriteLine(upperCaseMessage);

            // Create a StringBuilder and build a paragraph
            StringBuilder paragraph = new StringBuilder();
            paragraph.AppendLine("This is the first sentence of the paragraph.");
            paragraph.AppendLine("This is the second sentence. It can have multiple lines.");
            paragraph.Append("This is the last sentence, without a newline at the end.");
            string fullParagraph = paragraph.ToString();
            Console.WriteLine(fullParagraph);
        }
    }
}
