using System;


namespace PranishDotNetLab
{
    internal class Parameters
    {
     // ref
     static void Addition(ref  int number)
        {
            number += 1; 
        }

        // out param
    static void InitializeName(out string name)
        {
            name = "Pranish";
        }

        // in param
        static void DisplayNumber(in int num)
        {
            Console.WriteLine("In parameter value: " + num);
        }

        // optional/default param
        static void Greet(string name = "Guest")
        {
            Console.WriteLine("Hello, " + name);
        }

        // name agrument
        static void DisplayDetails(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // param modifier 
        static void DisplayAllNumbers(params int[] num)
        {
            Console.WriteLine("Using params modifier");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + " ");
            }
            Console.WriteLine(); // Add a new line after printing all numbers
        }

        static void Main(string[] args)
        {
            // pass by reference parameter
            int number = 5;
            Console.WriteLine(number);
            Addition(ref number); 
            Console.WriteLine(number);

            // out parameter
            string name;
            InitializeName(out name);
            Console.WriteLine("Using out parameter: " + name);

            // in parameter 
            int inNumber = 20;
            DisplayNumber(in inNumber);

            // Optional/Default parameters 
            Greet("Alice");
            Greet();

            // Named arguments
            DisplayDetails(name: "Alice", age: 30);
            DisplayDetails(age: 25, name: "Bob");

            // params modifier
            DisplayAllNumbers(1, 2, 3, 4);
            Console.WriteLine("Lab_work 4/Pranish Bajracharya/Roll no.: 13");
        }

    }
}
