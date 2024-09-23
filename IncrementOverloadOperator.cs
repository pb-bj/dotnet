using System;

namespace PranishDotNetLab
{
    class CounterIncrement
    {
        private int count;

        // Constructor
        public CounterIncrement()
        {
            count = 0;
        }

        // Overloading the ++ operator
        public static CounterIncrement operator ++(CounterIncrement c)
        {
            c.count++;
            return c;
        }

        // Method to display the count
        public void Display()
        {
            Console.WriteLine("Count: " + count);
        }
    }
    internal class IncrementOverloadOperator
    {
        static void Main()
        {
            CounterIncrement counter = new CounterIncrement();

            // Increment using overloaded ++
            counter++;
            counter.Display(); // Output: Count: 1

            counter++;
            counter.Display(); // Output: Count: 2
            Console.WriteLine("Lab 19(a)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
