using System;
using NugetDemo;

namespace NugetUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Add: " + calculator.Add(5, 3));
            Console.WriteLine("Subtract: " + calculator.Subtract(5, 3));
            Console.WriteLine("Multiply: " + calculator.Multiply(5, 3));
            Console.WriteLine("Divide: " + calculator.Divide(5, 3));
        }
    }
}
