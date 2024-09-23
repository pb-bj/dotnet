using System;
using System.Numerics;

namespace PranishDotNetLab
{
    class Distance
    {
        private int feet;
        private int inches;

        public Distance(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        public void Display()
        {
            Console.WriteLine("feet : " + feet, "inches :" + inches);
        }

        public static Distance operator +(Distance obj1, Distance obj2)
        {
           int totalFeet = obj1.feet + obj2.feet;
           int totalInches = obj1.inches + obj2.inches;
            return new Distance(totalFeet, totalInches);
        }
    }

    internal class Assignment
    {
        static void Main(string[] args)
        {
            Distance obj1 = new Distance(11, 2);
            obj1.Display();
           
            Distance obj2 = new Distance(7, 5);
            obj2.Display();

            Distance obj3 = obj2 + obj2;
            Console.WriteLine("The sum of two objects is: ");
            obj3.Display();


        }
    }
}
