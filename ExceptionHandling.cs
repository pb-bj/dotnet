using System;

namespace PranishDotNetLab
{

class ExceptionHandling
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the index of the array to access (0-4):");
            int index = Convert.ToInt32(Console.ReadLine());

            // Attempt to access the array element at the given index
            Console.WriteLine("Value at index {0}: {1}", index, numbers[index]);
        }
        catch (IndexOutOfRangeException ex)
        {
            // Handle the case where the index is out of bounds
            Console.WriteLine("Error: Index is out of bounds. Please enter a valid index.");
        }
        finally
        {
            // This block always runs
            Console.WriteLine("End of array index handling demo.");
            Console.WriteLine("Lab 24(a)/Pranish Bajracharya/Roll no.: 13");
        }

            Console.ReadKey();
    }
}
}
