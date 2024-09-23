using System;

namespace PranishDotNetLab
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    internal class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.MakeSound();

            Dog myDog = new Dog();
            myDog.MakeSound(); 

            Animal anotherDog = new Dog();
            anotherDog.MakeSound();
            Console.WriteLine("Lab_work 15(b)/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
