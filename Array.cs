using System;


namespace PranishDotNetLab
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] naturalNumbers = new int[15];
            int i;
            for( i = 0; i < naturalNumbers.Length; i++)
            {
                naturalNumbers[i] = i + 1;
            }

            int thirdElement = naturalNumbers[2];
            Console.WriteLine("Third element: " + thirdElement);

            int lastElement = naturalNumbers[naturalNumbers.Length - 1];
            Console.WriteLine("Last element: " + lastElement);

            int result = thirdElement + lastElement;
            Console.WriteLine("Result : " + result);
            Console.WriteLine("Lab_work 5(a)/Pranish Bajracharya/Roll no.: 13");

        }

    }

}
