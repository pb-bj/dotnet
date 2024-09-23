using System;

namespace PranishDotNetLab
{
    internal class MatrixOperations
    {
        static void Main(string[] args)
        {
            // Declare two 2x2 matrices
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] sumMatrix = new int[2, 2];
            int[,] productMatrix = new int[2, 2];

            // Input elements for the first matrix
            Console.WriteLine("Enter the elements of the first 2x2 matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input elements for the second matrix
            Console.WriteLine("Enter the elements of the second 2x2 matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate the sum of the matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Calculate the product of the matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    productMatrix[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the first matrix
            Console.WriteLine("\nFirst Matrix:");
            DisplayMatrix(matrix1);

            // Display the second matrix
            Console.WriteLine("\nSecond Matrix:");
            DisplayMatrix(matrix2);

            // Display the sum matrix
            Console.WriteLine("\nSum Matrix:");
            DisplayMatrix(sumMatrix);

            // Display the product matrix
            Console.WriteLine("\nProduct Matrix:");
            DisplayMatrix(productMatrix);

            Console.WriteLine("Lab_work 5(d)/Pranish Bajracharya/Roll no.: 13");
        }

        static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
