using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public interface IGeometry
    {
        /// <summary>
        /// Returns an area of enclosed shape.
        /// </summary>
        /// <returns> Area in square units </returns>
        double Atea();
    }
}
