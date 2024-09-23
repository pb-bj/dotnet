using System;

namespace PranishDotNetLab
{
    class BaseClass
    {
        // Method in the base class
        public void Display()
        {
            Console.WriteLine("Display method in BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        // Hiding the Display method in the base class
        public new void Display()
        {
            Console.WriteLine("Display method in DerivedClass");
        }
    }

    internal class MethodHidingExample
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Display();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display();

            BaseClass obj = new DerivedClass();
            obj.Display();
            Console.WriteLine("Lab_work 15(c)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
