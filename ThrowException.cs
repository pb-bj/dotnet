using System;

namespace PranishDotNetLab
{

class ThrowException
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a positive number:");
            int number = Convert.ToInt32(Console.ReadLine());
            ValidateNumber(number);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Handle the custom exception
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // This block always runs
            Console.WriteLine("End of validation demo.");
        }

        Console.ReadKey();
    }

    static void ValidateNumber(int number)
    {
        // If the number is negative, throw an exception
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("number", "Number must be positive.");
        }

        Console.WriteLine("You entered a valid number: " + number);
            Console.WriteLine("Lab 24(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
