using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the triangle:");
            double baseValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle:");
            double heightValue = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseValue * heightValue;

            Console.WriteLine("The area of the triangle is: " + area);

            Console.ReadLine();
        }
    }
}
