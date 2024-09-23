using System;

namespace PranishDotNetLab
{
    internal class LargAndSmallDemo
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());


            if (a > b && a > c)
            {
                Console.WriteLine($"{a} is the largest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} is the largest");
            }
            else
            {
                Console.WriteLine($"{c} is the largest");
            }


            if (a < b && a < c)
            {
                Console.WriteLine($"{a} is the smallest");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"{b} is the smallest");
            }
            else
            {
                Console.WriteLine($"{c} is the smallest");
            }
            Console.WriteLine("Lab_work 6(b)/Pranish Bajracharya/Roll no.: 13");


        }
    }
}
