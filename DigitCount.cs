using System;

namespace PranishDotNetLab
{
    internal class DigitCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int digitnumber = num.ToString().Length;

            if (digitnumber == 0)
            {
                Console.WriteLine("please enter a number");
            }
            else if (digitnumber == 1)
            {
                Console.WriteLine("The number is single digit ");
            }
            else if (digitnumber == 2)
            {
                Console.WriteLine("The number is double digit ");
            }
            else if (digitnumber == 3)
            {
                Console.WriteLine("The number is triple digit ");
            }
            else
            {
                Console.WriteLine("The number is a multi digit number");
            }
            Console.WriteLine("Lab_work 6(e)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
