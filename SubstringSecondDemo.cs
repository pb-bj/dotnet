using System;

namespace PranishDotNetLab
{
    internal class SubstringSecondDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int commaIndex = input.IndexOf(',');
            if (commaIndex != -1)
            {
                string substring = input.Substring(0, commaIndex);
                string upperCaseSubstring = substring.ToUpper();
                Console.WriteLine("Substring before the first comma: " + upperCaseSubstring);
            }
            else
            {
                Console.WriteLine("No comma found in the input string.");
            }
            Console.WriteLine("Lab_work 3(c)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
