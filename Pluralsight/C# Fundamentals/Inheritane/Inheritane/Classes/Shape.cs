using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritane.Classes
{
    internal abstract class Shape
    {
        protected abstract double CalculateArea();

        protected virtual double CalculateCircumference()
        {
            return 0;
        }
     
}
}
