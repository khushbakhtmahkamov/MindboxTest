using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry
{
    public class Triangle : IGeometry
    {
        double[] side;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("The side can not be negative");

            side = new double[3] { a, b, c };

        }
        public double Atea()
        {
            double p = side.Sum() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
        }

        public bool IsRight
        {
            get
            {
                Array.Sort(side);
                return Math.Pow(side[0], 2) + Math.Pow(side[1], 2) == Math.Pow(side[2], 2);
            }
        }
    }
}
