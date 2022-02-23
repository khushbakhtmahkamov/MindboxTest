using Geometry;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMindbox.Repositorys
{
    public class GeometryRepository : IGeometryRepository
    {

        public double GetAteaCircle(double radius)
        {
            IGeometry circle = new Circle(radius);
            return circle.Atea();
        }

        public double GetAteaTriangle(double a, double b, double c)
        {
            IGeometry triangle = new Triangle(a,b,c);
            return triangle.Atea();
        }

        public bool IsRightTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            return triangle.IsRight;
        }
    }
}
