using System;

namespace PranishDotNetLab
{
    internal class SubstringDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the starting substring: ");
            string startSubstring = Console.ReadLine();

            Console.Write("Enter the ending substring: ");
            string endSubstring = Console.ReadLine();

            bool startsWith = input.StartsWith(startSubstring);
            bool endsWith = input.EndsWith(endSubstring);

            Console.WriteLine($"The string starts with \"{startSubstring}\": {startsWith}");
            Console.WriteLine($"The string ends with \"{endSubstring}\": {endsWith}");
            Console.WriteLine("Lab_work 3(b)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
