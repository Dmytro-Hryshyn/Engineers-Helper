using Engineers_Helper.Controls.Geometry;
using System;

namespace Geometry.Rectangle
{

    /// <summary>
    /// Calculate Area of rectangle using deferent known properties of rectangle
    /// </summary>
    public sealed class GetArea
    {

        /// <summary>
        /// Calculate area of rectangle when sides are known SideA, SideB
        /// </summary>
        /// <param name="sideA">Side of rectangle</param>
        /// <param name="SideB">Side of rectangle</param>
        /// <returns>Area of rectangle</returns>
        public double BySides(double sideA, double SideB)
        {
            if (sideA > 0 && SideB > 0)
            {
                return sideA * SideB;
            }
            return 0;
        }

        /// <summary>
        /// Calculate area of rectangle when perimeter and side are known
        /// </summary>
        /// <param name="perimeter">perimeter of rectangle</param>
        /// <param name="side">side of rectangle</param>
        /// <returns>Area of rectangle</returns>
        public double ByPerimeterAndSide(double perimeter, double side)
        {
            if (side > 0 && perimeter > 0 && side < perimeter)
            {
                return ((perimeter * side) - (2 * side * side)) / 2;
            }
            return 0;
        }

        /// <summary>
        /// Calculate area of rectangle when diagonal and side are knwon
        /// </summary>
        /// <param name="diagonal">diagonal of rectangle</param>
        /// <param name="side">side of rectangle</param>
        /// <returns>Area of rectangle</returns>
        public double ByDiagonalAndSide(double diagonal, double side)
        {
            if (side > 0 && diagonal > 0 && side < diagonal)
            {
                return side * Math.Sqrt((diagonal * diagonal) - (side * side));
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Calculate area of rectangle when acute angle and diagonal are known
        /// </summary>
        /// <param name="angle">Angle between two diagonals and less  then 90 degrees</param>
        /// <param name="diagonal">Diagonal of rectangle</param>
        /// <returns>Area of rectangle</returns>
        public double ByAcuteAngleAndDiagonal(double angle, double diagonal)
        {
            if (angle > 0 && diagonal > 0)
            {
                return ((diagonal * diagonal) * Math.Sin(angle*(Math.PI/180)) / 2);
            }
            else
                return 0;
        }

        public double ByOutRadiusAndSide(double outRadius, double side)
        {
            if (side > 0 && outRadius > 0)
            {
                return side * Math.Sqrt(4 * (outRadius * outRadius) - (side * side));
            }

            else
            {
                return 0;
            }
        }

    }
}