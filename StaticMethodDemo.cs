using System;

namespace PranishDotNetLab
{
    class AreaOfRectangle
    {
        public static int diplayArea(int length, int breadth)
        {
            return length * breadth;
        }
    }

    internal class StaticMethodDemo
    {
        static void Main(string[] args)
        {
            int result = AreaOfRectangle.diplayArea(5, 2);
            Console.WriteLine("Area of Rectangle is : " + result);
            Console.WriteLine("Lab_work 10(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
