using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritane.Classes
{
    internal class Square : Shape
    {
        double SideLength { get; set; }

        public Square()
        {

        }

        public Square(double sideLength)
        {
            SideLength = sideLength;
            DisplayArea();
        }
        protected override double CalculateArea()
        {
            return SideLength * SideLength;
        }

        protected void DisplayArea()
        {
            Console.WriteLine($"The area of the square with side length {SideLength} is: {CalculateArea()}");
        }

        protected override double CalculateCircumference()
        {
            return 4 * SideLength;
        }
    }
}
