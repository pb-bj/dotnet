using System;

namespace PranishDotNetLab
{
    // Define a delegate for the event
    delegate void NotifyEventHandler(string message);

    class EventExample
    {
        // Declare an event using the delegate
        public static event NotifyEventHandler OnNotify;

        // Method to trigger the event
        public static void TriggerEvent(string message)
        {
            // Check if there are any subscribers
            OnNotify?.Invoke(message);
        }

        // Subscriber method
        public static void HandleNotification(string message)
        {
            Console.WriteLine("Event received: " + message);
        }

        static void Main(string[] args)
        {
            // Subscribe to the event
            OnNotify += HandleNotification;

            // Trigger the event
            TriggerEvent("Hello, event system!");

            Console.WriteLine("Lab 21(c)/Pranish Bajracharya/Roll no.: 13");

            Console.ReadKey();
        }
    }

}

