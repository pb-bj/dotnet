using System;

namespace PranishDotNetLab
{
    public class MyClass
    {
        public int Value { get; set; }

        public static bool operator ==(MyClass obj1, MyClass obj2)
        {
            if (ReferenceEquals(obj1, obj2))
                return true;
            if (obj1 is null || obj2 is null)
                return false;
            return obj1.Value == obj2.Value;
        }

        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            return !(obj1 == obj2);
        }
    }
    internal class EqualsOverloading
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass { Value = 10 };
            MyClass obj2 = new MyClass { Value = 10 };
            MyClass obj3 = new MyClass { Value = 20 };

            Console.WriteLine(obj1 == obj2); // Output: True
            Console.WriteLine(obj1 != obj2); // Output: False
            Console.WriteLine(obj1 == obj3); // Output: False
            Console.WriteLine(obj1 != obj3); // Output: True
            Console.WriteLine("Lab 19(c)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
