using System;

namespace PranishDotNetLab
{
    internal class VerbatimAndInterpolated
    {
        static void Main(string[] args)
        {
        //using verbatim string 
        string filePath = @"C:\Users\Pranish\Documents\DotNet.txt";
            Console.WriteLine(filePath);

        // using interpolated string
        string name = "Pranish";
        int age = 22;
        string message = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(message);
            Console.WriteLine("Lab_work 2(b)/Pranish Bajracharya/Roll no.: 13");

        }


    }
}
