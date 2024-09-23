using System;

namespace PranishDotNetLab
{

// Define a custom exception by inheriting from Exception class
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class CustomException
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            // Handle the custom exception
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            // Handle format exceptions (e.g., invalid input)
            Console.WriteLine("Error: Please enter a valid number for age.");
        }
        finally
        {
            // This block always runs
            Console.WriteLine("End of custom exception handling demo.");
        }

        Console.ReadKey();
    }

    static void ValidateAge(int age)
    {
        // If the age is invalid, throw a custom exception
        if (age < 0 || age > 120)
        {
            throw new InvalidAgeException("Age must be between 0 and 120.");
        }

        Console.WriteLine("Your age is valid: " + age);
            Console.WriteLine("Lab 24(c)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
