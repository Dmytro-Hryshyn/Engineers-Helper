using System;

namespace Geometry.Rectangle
{
   
    public sealed class GetSide
    {
        /// <summary>
        /// Calculate side of the rectangle, when other side and diagonal are known
        /// </summary>
        /// <param name="side">Side of the Rectangle</param>
        /// <param name="diagonal">Diagonal of the Rectangle</param>
        /// <returns></returns>
        public double BySideAndDIagonal(double side, double diagonal)
        {
            if (side > 0 && diagonal > 0)
            {
                return Math.Sqrt((diagonal * diagonal) - (side * side));
            }
            else
            {
                return 0;
            }
        }

        public double BySideAndArea(double side, double area)
        {
            throw new NotImplementedException();
        }

        public double BySideAndPerimeter(double side, double perimeter)
        {
            throw new NotImplementedException();
        }
    }
}