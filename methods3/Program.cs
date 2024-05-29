using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int results = MathOp(num1, num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + results);
        }

        public static int MathOp(int x, int y = 0)
        {
            return x + y;
        }

        public static int MathOp(int x)
        {
            return x * 10;
        }
    }
}
