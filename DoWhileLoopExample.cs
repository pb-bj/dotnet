using System;

namespace PranishDotNetLab
{
    internal class DoWhileLoopExample
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            string input;

            do
            {
                Console.Write("Enter a number (or type 'stop' to finish): ");
                input = Console.ReadLine();

                if (input.ToLower() != "stop")
                {
                    int number;
                    if (int.TryParse(input, out number))
                    {
                        sum += number;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number or 'stop'.");
                    }
                }

            } while (input.ToLower() != "stop");

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("The average of the entered numbers is: " + average);
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }

            Console.WriteLine("Lab_work 7(c)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
