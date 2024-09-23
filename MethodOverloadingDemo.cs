using System;

namespace PranishDotNetLab
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    internal class MethodOverloadingDemo
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of 8 and 7: " + calc.Add(8, 7));
            Console.WriteLine("Sum of 25, 13, and 24: " + calc.Add(25, 13, 24));
            Console.WriteLine("Sum of 21.5 and 43.5: " + calc.Add(21.5, 43.5));
            Console.WriteLine("Lab_work 15(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
