using System;

namespace Geometry.Rectangle
{
    public class GetAdjacentAngle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="side">Adjacent side to the angle</param>
        /// <param name="diagonal">Diagonal of the rectangle</param>
        /// <returns>Adjacent angle related to specified side</returns>
        public double BySideAndDiagonal(double side, double diagonal)
        {
            return Math.Acos(side / diagonal).ToDegrees();
        }
    }
}