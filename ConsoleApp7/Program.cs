using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)

        {
            int age = 31;
            bool hasTicket = true;
            bool hasPassport = true;
            bool canFly = (age >= 18 && hasTicket && hasPassport);
            Console.WriteLine(canFly);
            Console.ReadLine();
        }
    }
}
