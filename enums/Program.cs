using System;

namespace ParkingEnumsAssignment
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            bool isValid = false;

            while (!isValid)
            {
                try
                {
                    // Prompt the user to enter the current day of the week.
                    Console.WriteLine("Please enter an actual day of the week:");
                    // Assigning input to variable 'day'.
                    string input = Console.ReadLine();
                    // Parse/convert 'input' into 'DaysOfTheWeek' enum data type.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                    Console.WriteLine("Have a nice " +  day);
                    Console.ReadLine();
                    isValid = true; // Successful conversion sets isValid to true.

                }
                catch (ArgumentException ex)
                {
                    // Handle invalid input exception.
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }
    }
}
