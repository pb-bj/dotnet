using System;

namespace PranishDotNetLab
{
    internal class SumAndAverage
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            double avg;
            double[] num = new double[5];


            Console.WriteLine("Enter the numbers for 5 elements");
            for (int i = 0; i < 5; i++)
            {
                num[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + num[i];
            }

            avg = sum / num.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");
            Console.WriteLine("Lab_work 5(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }

}

