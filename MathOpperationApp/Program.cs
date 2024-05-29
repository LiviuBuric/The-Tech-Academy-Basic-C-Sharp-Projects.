using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();
            mathOps.PerformMathOperation(10, 5);
            mathOps.PerformMathOperation(num1: 20, num2: 8);
        }
    }
}
