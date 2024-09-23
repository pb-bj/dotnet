using System;

namespace PranishDotNetLab
{
    interface Student
    {
        public void displayName();
        public void displayCollege();
    }

    class TestClass : Student
    {
        public void displayName()
        {
            Console.WriteLine("Hey this is Pranish from BCA");
        }

        public void displayCollege()
        {
            Console.WriteLine("From Nagarjuna college of IT");
        }
    }
    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass();
            obj.displayName();
            obj.displayCollege();
            Console.WriteLine("Lab_work 16(b)/Pranish Bajracharya/Roll no.: 13");

        }


    }
}
