using System;

namespace PranishDotNetLab
{
    class Animals
    {
        protected string name;

        public Animals(string name)
        {
            this.name = name;
        }
    }

    class Dogs : Animals
    {
        public Dogs(string name) : base(name) { }

        public void getDisplay()
        {
            Console.WriteLine("Animal name (from base class): " + base.name);
        }
    }

    internal class BaseClassFieldExample
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs("Buddy");
            dog.getDisplay();
            Console.WriteLine("Lab_work 14(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
