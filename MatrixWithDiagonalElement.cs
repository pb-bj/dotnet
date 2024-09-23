using System;

namespace PranishDotNetLab
{
    internal class MatrixWithDiagonalElement
    {
        static void Main(string[] args)
        {
            // Declare a 3x3 matrix
            int[,] matrix = new int[3, 3];

            // Take matrix elements as input from the user
            Console.WriteLine("Enter the elements of the 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display the matrix
            Console.WriteLine("\nThe matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Display the diagonal elements
            Console.WriteLine("\nThe diagonal elements are:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[i, i] + "\t"); // Main diagonal
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[i, 2 - i] + "\t"); // Secondary diagonal
            }

            Console.WriteLine("\nLab_work 5(c)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
