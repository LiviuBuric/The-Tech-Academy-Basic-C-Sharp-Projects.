using System;

namespace Constructor
{
    public class Chain
    {
        // Constructor if one parameter (a float) is provided
        public Chain(float num1) : this(num1, "Bob")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }

        // Constructor if one parameter (a string) is provided
        public Chain(string name) : this(42, name)
        {
            Console.WriteLine(name + " and your default favorite number is " + Num);
        }

        // Constructor if both parameters (a string and a float) are provided
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }

        public string Name { get; set; }
        public float Num { get; set; }
    }
}
