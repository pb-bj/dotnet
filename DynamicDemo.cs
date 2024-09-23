using System;

namespace PranishDotNetLab
{
    internal class DynamicDemo
    {
        static void Main()
        {
            dynamic value = 10; // value is of type int initially
            Console.WriteLine($"Initial value: {value}");

            value = "Hello, dynamic!"; // value now becomes a string
            Console.WriteLine($"Updated value: {value}");

            value = new { Name = "Ramu", Age = 19 }; // value now becomes an anonymous type
            Console.WriteLine($"Anonymous type value: {value.Name}, Age: {value.Age}");
            Console.WriteLine("Lab 18/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
