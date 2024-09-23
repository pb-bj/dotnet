using System;

namespace PranishDotNetLab
{
    class Circle
    {
        private double _radius = 20.85; // private filed with _ a good practice
        public double Radius // like a method but without () called property
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }
    }
    internal class PropertyDemo
    {
        static void Main(string[] args)
        {
            Circle cs = new Circle();
            Console.WriteLine("The original value of circle: " + cs.Radius);

            double newCircleValue = cs.Radius = 255.122;
                Console.WriteLine("The new circle value: " + newCircleValue);
            Console.WriteLine("Lab_work 12/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
