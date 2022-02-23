using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMindbox.Repositorys
{
    public interface IGeometryRepository
    {
        double GetAteaCircle(double radius);
        double GetAteaTriangle(double a, double b, double c);
        bool IsRightTriangle(double a, double b, double c);
    }
}
