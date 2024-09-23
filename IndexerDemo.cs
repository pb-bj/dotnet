using System;

namespace PranishDotNetLab
{
    class ArrayNumbers
    {
        private int[] _numbers = new int[2];

        public int this [int index]
        {
            get { return _numbers[index]; }

            set { _numbers[index] = value; }
        }

    }
    internal class IndexerDemo
    {
        static void Main(string[] args)
        {
        ArrayNumbers objArray = new ArrayNumbers();
            objArray[0] = 10;
            objArray[1] = 20;
            Console.WriteLine($"Element at index 0: {objArray[0]}");
            Console.WriteLine($"Element at index 1 : {objArray[1]}");
            Console.WriteLine("Lab_work 13(a)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
