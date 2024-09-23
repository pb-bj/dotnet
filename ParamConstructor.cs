using System;

namespace PranishDotNetLab
{
    class Students
    {
        public string name;
        public int age;
        public bool isFromNagarjuna;

        public Students(string name, int age, bool isFromNagarjuna)
        {
            this.name = name;
            this.age = age;
            this.isFromNagarjuna = isFromNagarjuna;
        }

        public void showStudentInfo()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age + ", From Nagarjuna: " + isFromNagarjuna);
        }
    }

    internal class ParamConstructor
    {
        static void Main(string[] args)
        {
            Students std = new Students("Pranish Bajracharya", 22, true);
            std.showStudentInfo();
            Console.WriteLine("Lab_work 8/Pranish Bajracharya/Roll no.: 13");
        }
    }
}
