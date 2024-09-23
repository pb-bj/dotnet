using System;

namespace PranishDotNetLab
{
    class College
    {
        public string name;
        public int establishedYear;

        // Constructor with two parameters
        public College(string name, int establishedYear)
        {
            this.name = name;
            this.establishedYear = establishedYear;
        }

        // Constructor with one parameter that calls the constructor with two parameters
        public College(string name) : this(name, 2002)  // Assuming default year is 18
        {
        }

        public void Display()
        {
            Console.WriteLine("Name: " + this.name + ", Established Year: " + this.establishedYear);
        }
    }

    internal class ThisKeywordSecondDemo
    {
        static void Main(string[] args)
        {
            College clz = new College("Nagarjuna Coolege of IT");
            clz.Display();

            College clz2 = new College("Kathford College", 2005);
            clz2.Display();
            Console.WriteLine("Lab_work 11(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
