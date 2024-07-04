using System;

namespace InheritanceAndMethodOverriding
{
    // Author: Clinton Tetteh (ID: 10894595)
    // Program Name: DCIT
    // Assignment: DCIT318 Assignment 2
    // Date: 3rd July 2024
    class Program
    {
        static void Main()
        {
            // Your C# code starts here
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal sounds:");
            genericAnimal.MakeSound();

            Console.WriteLine("\nDog sounds:");
            dog.MakeSound();

            Console.WriteLine("\nCat sounds:");
            cat.MakeSound();
        }
    }
}
