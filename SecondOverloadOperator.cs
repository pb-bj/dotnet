using System;

namespace PranishDotNetLab
{
    class Moneys
    {
        public int Rupee { get; set; }
        public int Paisa { get; set; }

        public Moneys(int rupee, int paisa)
        {
            Rupee = rupee;
            Paisa = paisa;
        }

        // Overloading + operator to add two Money objects
        public static Moneys operator +(Moneys m1, Moneys m2)
        {
            int totalPaisa = m1.Paisa + m2.Paisa;
            int carryRupee = totalPaisa / 100;
            int sumRupee = m1.Rupee + m2.Rupee + carryRupee;

            return new Moneys(sumRupee, totalPaisa % 100);
        }

        public void Display()
        {
            Console.WriteLine($"Rs. {Rupee} and {Paisa} Paisa");
        }
    }

    class SecondOverloadOperator
    {
        static void Main()
        {
            Moneys m1 = new Moneys(20, 75);
            Moneys m2 = new Moneys(10, 50);

            Console.WriteLine("Money 1:");
            m1.Display();

            Console.WriteLine("\nMoney 2:");
            m2.Display();

            Moneys total = m1 + m2;
            Console.WriteLine("\nTotal Money after addition:");
            total.Display();
            Console.WriteLine("Lab_work 19(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
