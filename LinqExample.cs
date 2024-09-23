using System;
using System.Linq;

namespace PranishDotNetLab
{
class LinqExample
{
    static void Main(string[] args)
    {
        // Array of numbers
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Use LINQ to find even numbers
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Lab 22/Pranish Bajracharya/Roll no.: 13");
        Console.ReadKey();
    }
}

}
