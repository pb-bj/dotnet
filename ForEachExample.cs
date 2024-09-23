using System;
namespace PranishDotNetLab
{
    internal class ForEachExample
    {
        static void Main(string[] args)
        {
            string[] names = { "Pranish", "Sujal", "Ronil", "Veerin" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Lab_work 7(f)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
