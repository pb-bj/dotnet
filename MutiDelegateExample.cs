using System;

namespace PranishDotNetLab
{
    // Define a delegate that takes no parameters and returns void
    delegate void MyMulticastDelegate();

    class MultiDelegateExample
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 is called.");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 is called.");
        }

        static void Main(string[] args)
        {
            // Instantiate the multicast delegate and add methods
            MyMulticastDelegate multicastDel = Method1;
            multicastDel += Method2;

            // Invoke both methods in the multicast delegate
            multicastDel.Invoke();

            Console.WriteLine("Lab 21(b)/Pranish Bajracharya/Roll no.: 13");
            Console.ReadKey();

        }
    }
}

