using System;

namespace PranishDotNetLab
{
    internal class ThreeDimArray
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 3x3x3 3-dimensional array
            int[,,] array3D = new int[3, 3, 3];

            // Fill the array with values
            int value = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array3D[i, j, k] = value;
                        value++;
                    }
                }
            }

            // Display the array values
            Console.WriteLine("The elements of the 3x3x3 array are:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine($"array3D[{i},{j},{k}] = {array3D[i, j, k]}");
                    }
                }
            }

            Console.WriteLine("Lab_work 5(f)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
