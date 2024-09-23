using System;

namespace PranishDotNetLab
{
    internal class CreatingStringObj
    {
        static void Main(string[] args)
        {
            // string literal and concatenation
            string firstName = "Pranish";
            string lastName = "Bajracharya";
            Console.WriteLine("First name: " + firstName + ", Last name: " + lastName);

            // using string constructor
            char[] firstNameChars = { 'P', 'r', 'a', 'n', 'i', 's', 'h' };
            string str = new string(firstNameChars);
            Console.WriteLine(str);

            // using string interpolation
            int salary = 25000;
            Console.WriteLine($"{salary} is my monthly salary");

            // formatting method to convert a value
            DateTime waiting = new DateTime(2024, 7, 8, 17, 58, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.WriteLine("Lab_work 2(a)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
