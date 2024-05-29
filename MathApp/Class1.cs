class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        Program mathOps = new MathOperations();

        // Call the method in the class, passing in two numbers
        mathOps.(10, 5);

        // Call the method in the class, specifying the parameters by name
        mathOps.PerformMathOperation(num1: 20, num2: 8);
    }
}
