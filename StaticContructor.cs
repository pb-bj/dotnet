using System;

namespace PranishDotNetLab
{
    internal class StaticConstructor
    {
        static int num;
        static StaticConstructor()
        {
            Console.WriteLine("This is from Static Constructor");
            num = 5;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("This is from Main ");
            StaticConstructor s1 = new StaticConstructor();
            Console.WriteLine("Lab_work 8/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
