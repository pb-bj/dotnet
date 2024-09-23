using System;

namespace PranishDotNetLab
{
    internal class FiboExample
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms for the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.Write("Fibonacci Sequence: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("\nLab_work 7(e)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
