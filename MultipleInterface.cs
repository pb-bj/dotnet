using System;


namespace PranishDotNetLab
{
    interface DemoOne
    {
        public void demoMethod();
    }

    interface DemoTwo
    {
        public void demoMethod2();
    }
    
    class TestInterface : DemoOne, DemoTwo {
        public void demoMethod()
        {
            Console.WriteLine("This is the first interface method");
        }

        public void demoMethod2()
        {
            Console.WriteLine("This is second interface method");
        }
    }
    internal class MultipleInterface
    {
        static void Main(string[] args)
        {
            TestInterface obj = new TestInterface();
            obj.demoMethod();
            obj.demoMethod2();
            Console.WriteLine("Lab_work 16(c)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
