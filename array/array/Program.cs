using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Array of strings
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            Console.WriteLine("Select a number between 0 and 9");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;
            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                catch
                {
                    Console.WriteLine("Sorry your number selected is invalid. Please select a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // List of strings
            List<string> occupationsList = new List<string>();
            occupationsList.Add("lawyer");
            occupationsList.Add("doctor");
            occupationsList.Add("nurse");
            occupationsList.Add("plumber");
            occupationsList.Add("electrician");
            occupationsList.Add("teacher");
            occupationsList.Add("writer");
            occupationsList.Add("student");
            occupationsList.Add("retired");
            occupationsList.Add("Stay-at-home parent");
            occupationsList.Add("accountant");
            occupationsList.Add("police officer");
            occupationsList.Add("firefighter");

            // Ask the user for a number to display the string at that index
            Console.WriteLine("Pick another number between 0 and 9");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool inList = false;
            while (!inList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationsList[listSelect]);
                    inList = true;
                }
                catch
                {
                    Console.WriteLine("Your selected number is invalid. Select a number between 0 and 9");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Array of integers
            int[] intArray = { 1, 2, 3, 67, 5, 9, 11, 42, 3, 6 };

            // Ask the user for a number to display the string at that index
            Console.WriteLine("Select a third number between 0 and 9");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                catch
                {
                    // Add a message to display if the user picks an index that doesn't exist
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}



