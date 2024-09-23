using System;

namespace PranishDotNetLab
{
    class Vehicles
    {
        public void Start()
        {
            Console.WriteLine("Vehicle starts");
        }
    }

    class Car : Vehicles
    {
        public new void Start()
        {
            base.Start(); // Calling the base class method
            Console.WriteLine("Car starts with a roar");
        }
    }

    internal class BaseClassMethodExample
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();
            Console.WriteLine("Lab_work 14(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
