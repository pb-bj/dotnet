using System;

namespace PranishDotNetLab
{
class LamdaExpression
{
    static void Main(string[] args)
    {
        // Expression Lambda: single expression (adds two numbers)
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine("Sum (Expression Lambda): " + add(3, 4));  // Output: 7

        // Statement Lambda: contains multiple statements (multiplies two numbers)
        Func<int, int, int> multiply = (x, y) =>
        {
            int result = x * y;
            return result;
        };
        Console.WriteLine("Product (Statement Lambda): " + multiply(5, 6));  // Output: 30
         Console.WriteLine("Lab 23(a)/Pranish Bajracharya/Roll no.: 13");

        }
    }

}
