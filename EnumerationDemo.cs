using System;

namespace PranishDotNetLab
{
    enum Weeks {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    internal class EnumerationDemo
    {
        static void Main(string[] args)
        {
            Weeks today = Weeks.Sunday;
            Console.WriteLine($"Today is {today}" );

            Console.WriteLine($"Tommorrow is {Weeks.Monday}");
            Console.WriteLine("Lab_work 17(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
