using System;

namespace MainMethodAssignment
{
    public class MathMethods2Cs
    {
        // First method that takes an integer
        public int MathOp(int number)
        {
            return number + 7;
        }

        // Second method that takes a decimal (commented out)
        // public int MathOp(decimal number)
        // {
        //     return newnum = Convert.ToInt32(number * 20);
        // }

        // Third method that takes a string
        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 3;
        }
    }
}
