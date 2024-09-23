using System;

namespace PranishDotNetLab
{
    class Person
    {
        public string fullName;

        public Person(string fullName)
        {
            this.fullName = fullName;
            Console.WriteLine("Person class constructor called");
        }
    }

    class Employees : Person
    {
        public Employees(string fullName) : base(fullName) // Calling the base class constructor
        {
            Console.WriteLine("Employee class constructor called");
        }
    }

    internal class BaseClassConstructor
    {
        static void Main(string[] args)
        {
            Employees emps = new Employees("John Doe");
            Console.WriteLine("Employee's full name: " + emps.fullName);
            Console.WriteLine("Lab_work 14(c)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
