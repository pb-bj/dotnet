using System;

namespace PranishDotNetLab
{
    internal class WhileLoopExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for natural numbers: ");
            int userInput = int.Parse(Console.ReadLine());

            int i = 1;
            while(i < userInput)
            {
                Console.WriteLine("Natural number : " + i + "\t");
                i++;
            }
            Console.WriteLine("Lab_work 7(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
