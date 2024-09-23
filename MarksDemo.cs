using System;

namespace PranishDotNetLab
{
    internal class MarksDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of a subject");
            int marks = int.Parse(Console.ReadLine());


            if (marks >= 90)
            {
                Console.WriteLine("Grada:A");
            }
            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("Grade:B");
            }
            else if (marks >= 60 && marks < 80)
            {
                Console.WriteLine("Grade:C");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("Grade:D");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.WriteLine("Grade:E");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
            Console.WriteLine("Lab_work 6(c)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
