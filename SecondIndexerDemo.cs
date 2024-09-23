using System;

namespace PranishDotNetLab
{
    class SimpleDictionary
    {
        private string[] _data = new string[2];

        // Indexer using string as the index
        public string this[string key]
        {
            get
            {
                if (key == "first") return _data[0];
                if (key == "second") return _data[1];
                return "Key not found";
            }
            set
            {
                if (key == "first") _data[0] = value;
                else if (key == "second") _data[1] = value;
            }
        }
    }

    internal class SecondIndexerDemo
    {
        static void Main(string[] args)
        {
            SimpleDictionary objDict = new SimpleDictionary();

            // Set values using the indexer
            objDict["first"] = "Alice";
            objDict["second"] = "Bob";

            // Get values using the indexer
            Console.WriteLine($"First: {objDict["first"]}");
            Console.WriteLine($"Second: {objDict["second"]}");
            Console.WriteLine($"Third: {objDict["third"]}"); // Key not found

            Console.WriteLine("Lab_work 13(b)/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
