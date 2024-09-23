using System;

namespace PranishDotNetLab
{
    public class GreaterClass
    {
        public int Value { get; set; }

        public static bool operator >(GreaterClass obj1, GreaterClass obj2)
        {
            if (obj1 is null || obj2 is null)
                throw new ArgumentNullException("Operands cannot be null");
            return obj1.Value > obj2.Value;
        }

        public static bool operator <(GreaterClass obj1, GreaterClass obj2)
        {
            if (obj1 is null || obj2 is null)
                throw new ArgumentNullException("Operands cannot be null");
            return obj1.Value < obj2.Value;
        }
    }
    internal class GreaterOverloadOperator
    {
        static void Main(string[] args)
        {
            GreaterClass obj1 = new GreaterClass { Value = 10 };
            GreaterClass obj2 = new GreaterClass { Value = 20 };

            Console.WriteLine(obj1 > obj2); // Output: False
            Console.WriteLine(obj1 < obj2); // Output: True
            Console.WriteLine("Lab 19(d)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
