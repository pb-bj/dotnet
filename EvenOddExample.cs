using System;

namespace PranishDotNetLab
{
    internal class EvenOddExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            if (c < 0)
            {
                Console.WriteLine(" Non-negative value is not accepted");
            }
            else
            {
                Console.WriteLine($"The sum of {a} and {b} is {c}");
            }
            Console.WriteLine("Lab_work 6(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
