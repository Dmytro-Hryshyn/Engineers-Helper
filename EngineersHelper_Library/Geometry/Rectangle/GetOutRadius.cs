using System;

namespace Geometry.Rectangle
{
    public class GetOutRadius
    {

        /// <summary>
        /// Claculate circumscribed radius of the rectangle, when two sides are known
        /// </summary>
        /// <param name="sideA">Known side of the rectangle</param>
        /// <param name="sideB">Known side of the rectangle</param>
        /// <returns>Circumscribed radius of the rectangle</returns>
        public double ByTwoSides(double sideA, double sideB)
        {
            if (sideA>0 && sideB>0)
            {
                return (Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2))) / 2;
            }
            return 0;
        }

        /// <summary>
        /// Claculate circumscribed radius of the rectanle, when  one  the sides and perimeter are known.
        /// </summary>
        /// <param name="side">Known side of the rectangle</param>
        /// <param name="perimeter">Perimeter of the rectangle</param>
        /// <returns>Circumscribed radius of the rectangle</returns>
        public double BySideAndPerimeter(double side, double perimeter)
        {
            if (side>0 && perimeter>0)
            {
                return (Math.Sqrt(Math.Pow(perimeter,2) - 4*perimeter*side + 8*Math.Pow(side,2)))/ 4;
            }
            return 0;
        }

        /// <summary>
        /// Calculate circumscribed radius of the rectangle, when one side and area are known
        /// </summary>
        /// <param name="side">Known side of the rectangle</param>
        /// <param name="area">Area of the renctangle</param>
        /// <returns>Circumscribed radius of the rectangle </returns>
        public double BySideAndArea(double side, double area)
        {
            if (side>0 && area >0)
            {
                return Math.Sqrt((area * area) + (Math.Pow(side, 4))) / (2*side);
            }
            return 0;
        }

        /// <summary>
        /// Calculate circumscribed radius of the rectangle, when two sides are known.
        /// </summary>
        /// <param name="diagonal">Diagonal of the rectangle</param>
        /// <returns>Circumscribed radius of the rectangle</returns>
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