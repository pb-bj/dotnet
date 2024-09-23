using System;

namespace PranishDotNetLab
{
   abstract class Vehicle
    {
        public abstract void brand();
        public void model()
        {
            Console.WriteLine("Model is Civic 2017");
        }
    }

    class Display : Vehicle
    {
        public override void brand()
        {
            Console.WriteLine("The Brand is Honda");
        }
    }

    internal class AbstractDemo
    {
        static void Main(string[] args)
        {
            Display obj = new Display();
            obj.brand();
            obj.model();
            Console.WriteLine("Lab_work 16(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
