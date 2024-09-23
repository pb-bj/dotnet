using System;

namespace PranishDotNetLab
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];

            jarray[0] = new int[3];
            jarray[1] = new int[2];
            jarray[2] = new int[1];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    jarray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The entered jagged array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(jarray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Lab_work 5(e)/Pranish Bajracharya/Roll no.: 13");
            ;

        }
    }
}
