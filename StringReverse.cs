using System;

namespace PranishDotNetLab
{
    internal class StringReverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Print characters in reverse order
            Console.Write("Reversed string: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + (i > 0 ? "," : ""));
            }
            Console.WriteLine();

            // Display the occurrence of individual characters
            Console.WriteLine("Character occurrences:");
            for (int i = 0; i < input.Length; i++)
            {
                if (input.IndexOf(input[i]) == i)  // Ensure the character is counted once
                {
                    int count = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{input[i]}: {count}");
                }
            }
        }
    }
}
