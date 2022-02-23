using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle : IGeometry
    {
        double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("The radius cannot be negative");
            }
            this.radius = radius;
        }

        public double Atea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

    }
}
