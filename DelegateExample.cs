using System;


namespace PranishDotNetLab
{
    delegate void MyDelegate(string message);

    internal class DelegateExample
    {
        // Method that matches the delegate signature
        public static void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate and pass a method to it
            MyDelegate del = ShowMessage;

            // Invoke the delegate
            del("Hello from a delegate!");

            Console.WriteLine("Lab 21(a)/Pranish Bajracharya/Roll no.: 13");
            Console.ReadKey();
        }
    }
}
