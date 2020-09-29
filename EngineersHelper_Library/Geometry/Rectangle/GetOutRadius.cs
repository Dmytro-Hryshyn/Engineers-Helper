using System;

namespace Geometry.Rectangle
{
    public class GetOutRadius
    {
        public double ByTwoSides(double sideA, double sideB)
        {
            if (sideA>0 && sideB>0)
            {
                return (Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2))) / 2;
            }
            return 0;
        }

        public double BySideAndPerimeter(double side, double perimeter)
        {
            if (side>0 && perimeter>0)
            {
                return (Math.Sqrt(Math.Pow(perimeter,2) - 4*perimeter*side + 8*Math.Pow(side,2)))/ 4;
            }
            return 0;
        }

        public double BySideAndArea(double side, double area)
        {
            if (side>0 && area >0)
            {
                return Math.Sqrt((area * area) + (Math.Pow(side, 4))) / (2*side);
            }
            return 0;
        }

        public double ByDiagonal(double diagonal)
        {
            if (diagonal>0)
            {
                return diagonal / 2;
            }
            return 0;
        }
    }
}