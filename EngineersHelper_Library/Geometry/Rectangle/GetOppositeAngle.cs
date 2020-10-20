using System;

namespace Geometry.Rectangle
{
    public class GetOppositeAngle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="side">Opposite side to the angle</param>
        /// <param name="diagonal">Diagonal of the rectangle</param>
        /// <returns>Opposite angle related to specified side</returns>
        public double BySideAndDiagonal(double side, double diagonal)
        {
            return Math.Asin(side / diagonal).ToDegrees();
            
        }
    }
}