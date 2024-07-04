namespace AbstractClassesAndMethods
{
    // Author: Clinton Tetteh (ID: 10894595)
    // Program Name: [Your Program Name]
    // Assignment: [Your Assignment Name]
    // Date: 3rd July 2024
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }
}
