using System;

namespace Geometry.Rectangle
{
    public class GetPerimeter
    {
        /// <summary>
        /// Calculate perimeter of rectangle using both side
        /// </summary>
        /// <param name="sideA">Side of rectangle</param>
        /// <param name="sideB">Side of rectangle</param>
        /// <returns></returns>
        public double BySides(double sideA, double sideB)
        {
            if (sideA > 0 && sideB > 0)
            {
                return (sideA + sideB) * 2;
            }
            else return 0;
        }
        /// <summary>
        /// Calculate perimeter of ractangle when two properties are known: Area and Side
        /// </summary>
        /// <param name="area">Area of rectangle</param>
        /// <param name="side">Side of ractangle</param>
        /// <returns>Perimeter of ractangle</returns>
        public double ByAreaAndSide(double area, double side)
        {
            if (area > 0 && side > 0)
            {
                return ((2 * area) + 2 * (side * side)) / side;
            }
            else return 0;
        }

        /// <summary>
        /// Calculate Perimeter of rectangle when
        /// </summary>
        /// <param name="diagonal">Diagonal of ractangle</param>
        /// <param name="side">Side of rectangle</param>
        /// <returns>Returns perimeter of rectanle</returns>
        public double ByDiagonalAndSide(double diagonal, double side)
        {
            if (diagonal > 0 && side > 0)
            {
                return 2 * (side + Math.Sqrt((diagonal * diagonal) - (side * side)));
            }
            else return 0;
        }

        public double ByOutRadiusAndSide(double outRadius, double side)
        {
            if (outRadius > 0 && side > 0)
            {
                return 2 * (side + (Math.Sqrt(4 * Math.Pow(outRadius, 2) - Math.Pow(side, 2))));
            }
            else return 0;
        }

    }
}