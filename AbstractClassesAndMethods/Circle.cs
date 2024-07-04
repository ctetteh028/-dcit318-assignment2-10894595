using System;

namespace AbstractClassesAndMethods
{
    // Author: Clinton Tetteh (ID: 10894595)
    // Program Name: [Your Program Name]
    // Assignment: [Your Assignment Name]
    // Date: 3rd July 2024
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
