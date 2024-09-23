using System;

namespace PranishDotNetLab
{
    class Currency
    {
        public int Rupee;
        public int Paisa;

        // Constructor
        public Currency(int rupee, int paisa)
        {
            Rupee = rupee;
            Paisa = paisa;
        }

        // Overloading the + operator
        public static Currency operator +(Currency m1, Currency m2)
        {
            int totalPaisa = m1.Paisa + m2.Paisa;
            int carryRupee = totalPaisa / 100;
            int remainingPaisa = totalPaisa % 100;

            int totalRupee = m1.Rupee + m2.Rupee + carryRupee;

            return new Currency(totalRupee, remainingPaisa);
        }

        // Method to display the Money object
        public void Display()
        {
            Console.WriteLine("Rupee: " + Rupee + ", Paisa: " + Paisa);
        }
    }

    internal class MoneyOverloading
    {
        static void Main()
        {
            Currency m1 = new Currency(10, 50);
            Currency m2 = new Currency(5, 75);

            // Adding two Money objects using overloaded +
            Currency total = m1 + m2;
            total.Display(); // Output: Rupee: 16, Paisa: 25
            Console.WriteLine("Lab 19(b)/Pranish Bajracharya/Roll no.: 13");
        }
    }

}
