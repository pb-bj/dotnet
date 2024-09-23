using System;

namespace PranishDotNetLab
{
    class Counter
    {
        public static int count = 0;

        public Counter() {
            count ++;
        }
    }

    internal class StaticFieldDemo
    {
        static void Main(string[] args)
        {
            Counter count1 = new Counter();
            Counter count2 = new Counter();
            Counter count3 = new Counter();

            Console.WriteLine("Number of instances created: " + Counter.count);
            Console.WriteLine("Lab_work 10(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
