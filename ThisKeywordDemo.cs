using System;

namespace PranishDotNetLab
{
    class Office
    {
        public string staffName;

        public Office(string staffName)
        {
            this.staffName = staffName;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + this.staffName);
        }
    }

    internal class ThisKeywordDemo

    {
        static void Main(string[] args)
        {
            Office obj = new Office("Pranish Bajracharya");
            obj.Display();
            Console.WriteLine("Lab_work 11(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
    
}
