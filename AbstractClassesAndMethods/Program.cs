using System;

namespace AbstractClassesAndMethods
{
    // Author: Clinton Tetteh (ID: 10894595)
    // Program Name: [Your Program Name]
    // Assignment: [Your Assignment Name]
    // Date: 3rd July 2024
    class Program
    {
        static void Main()
        {
            // Your C# code starts here
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}
