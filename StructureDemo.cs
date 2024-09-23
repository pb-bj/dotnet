using System;

namespace PranishDotNetLab
{

    struct Rectangle
    {
        public int Width;
        public int Height;

        // Constructor to initialize the struct
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Method to calculate the area of the rectangle
        public int CalculateArea()
        {
            return Width * Height;
        }

        // Method to display the rectangle's dimensions and area
        public void Display()
        {
            Console.WriteLine($"Rectangle dimensions: Width = {Width}, Height = {Height}");
            Console.WriteLine($"Area of the rectangle: {CalculateArea()}");
        }
    }

    internal class StructureDemo
    {
        static void Main(string[] args)
        {
            // Create an instance of the Rectangle struct
            Rectangle rect1 = new Rectangle(10, 20);

            // Display the rectangle's dimensions and area
            rect1.Display();

            Console.WriteLine("Lab_work 17(a)/Rectangle Struct Demo");
        }
    }
}
