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
        /// <returns>Unknown side of the rectangle</returns>
        public double BySideAndDIagonal(double side, double diagonal)
        {
            if (side > 0 && diagonal > 0)
            {
                return Math.Sqrt((diagonal * diagonal) - (side * side));
            }
            else
                return 0;
        }

        /// <summary>
        /// Calculate Side of rectangle, when  area and other side are known
        /// </summary>
        /// <param name="side">Known side of the  Rectangle</param>
        /// <param name="area">Area of the Rectangle</param>
        /// <returns>Unknown side of the rectangle</returns>
        public double BySideAndArea(double side, double area)
        {
            if (area>0 && side>0)
            {
                return area / side;
            }
            
            else 
                return 0;
        }

        /// <summary>
        /// Calculate Side of rectangle, when other Side and Perimeter of the rectangle are known
        /// </summary>
        /// <param name="side">Known side of the Rectangle</param>
        /// <param name="perimeter">Perimeter of Rectangle</param>
        /// <returns>Unknown side of the rectangle</returns>
        public double BySideAndPerimeter(double side, double perimeter)
        {
            if (side > 0 && perimeter > 0)
            {
                return (perimeter - 2 * side) / 2;
            }
            else
                return 0;
        }

        /// <summary>
        /// Calculate side of the rectangle, where diagonal and opposite angle are known
        /// </summary>
        /// <param name="diagonal">Diagonal of the Rectangle</param>
        /// <param name="angle">Opposite angle to unknown side</param>
        /// <returns>Opposite Side to known angle</returns>
        public double ByDiagonalAndOppositeAngle(double diagonal, double angle)
        {
            if (diagonal > 0 && (angle > 0 && angle < 90))
            {
                return diagonal * Math.Sin(angle.ToRadian());
            }
            else
                return 0;
        }

        /// <summary>
        /// Calculate side of the rectangle, where diagonal and adjacent angle are known
        /// </summary>
        /// <param name="diagonal">Diagonal of the Rectangle</param>
        /// <param name="angle">Adjacent angle to unknown side</param>
        /// <returns>Adjacent Side to known angle</returns>
        public double ByDiagonalAndAdjacentAngle(double diagonal, double angle)
        {
            if (diagonal > 0 && (angle > 0 && angle < 90))
            {
                return diagonal * Math.Cos(angle.ToRadian());
            }
            else
                return 0;
        }
    }
}