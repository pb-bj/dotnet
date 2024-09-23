using System;

namespace PranishDotNetLab
{
    internal class CalculatorDemo
    {
        public static void Main(string[] args)
        {
            double result;

            Console.WriteLine("Enter 1st number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator 1:+ /t 2:- /t 3: * /t 4:/ ");
            char c = char.Parse(Console.ReadLine());


            switch (c)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine($"The sum is {result}");
                    break;

                case '-':
                    result = a - b;
                    Console.WriteLine($"The diff is {result}");
                    break;

                case '*':
                    result = a * b;
                    Console.WriteLine($"The product is {result}");
                    break;
                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine($"The division is {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by 0 error");
                    }
                    break;

            }
            Console.WriteLine("Lab_work 6(d)/Pranish Bajracharya/Roll no.: 13");



        }
    }
}
