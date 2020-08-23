using System;

namespace Geometry.Rectangle
{
    public sealed class GetDiagonal
    {
        /// <summary>
        /// Calculate diagonal of rectangle when both side are known
        /// </summary>
        /// <param name="sideA">Side of rectangle</param>
        /// <param name="sideB">Side of rectangle</param>
        /// <returns>Diagonal of rectangle</returns>
        public  double BySide(double sideA, double sideB)
        {
            if (sideA > 0 && sideB > 0)
            {
                return Math.Sqrt((sideA * sideA) + (sideB * sideB));
            }
            else return 0;
        }

        /// <summary>
        /// Calculate diagonal of rectangle when area and side are known
        /// </summary>
        /// <param name="area">Area of rectangle</param>
        /// <param name="side">Side of rectangle</param>
        /// <returns>Perimeter of rectangle</returns>
        public double ByAreaAndSide(double area, double side)
        {
            if (side>0 && area >0 && side<area)
            {
                return Math.Sqrt((Math.Pow(area,2) + Math.Pow(side, 4))) / side;
            }
            return 0;
        }

        /// <summary>
        /// Calculate Diagonal of rectangle when perimeter and side are known
        /// </summary>
        /// <param name="perimeter">perimeter of rectangle</param>
        /// <param name="side">side of rectangle</param>
        /// <returns>Diagonal of rectangle</returns>
        public double ByPerimeterAndSide(double perimeter, double side)
        {
            if (perimeter > 0 && side > 0)
            {
                return Math.Sqrt((perimeter * perimeter) - (4 * perimeter * side) + (8 * side * side)) / 2;

            }
            else return 0;
        }

        /// <summary>
        /// Calculate diagonal of rectangle when circumscribedradius is known
        /// </summary>
        /// <param name="outradius">Circums scribed raius of rectangle</param>
        /// <returns>Diagonal of recnagle</returns>
        public double ByOutRadius(double outradius)
        {
            return outradius > 0 ? outradius * 2 : 0;
        }

        /// <summary>
        /// Calculate diagonal of rectangle using  adjacent angle to diagonal and opposite side
        /// </summary>
        /// <param name="angle">Angle of rectangle that adjacent to diagonal</param>
        /// <param name="opposisteSide">Opposite side of the angle</param>
        /// <returns>Returns diagonal of rectangle</returns>
        public double ByAngleAndOppositeSide(double angle, double opposisteSide)
        {
            return angle > 0 && opposisteSide > 0 ? opposisteSide / Math.Sin(angle*(Math.PI/180)) : 0;
        }

        /// <summary>
        /// Calculate diagonal of rectangle using  adjacent angle to diagonal and adjacent side
        /// </summary>
        /// <param name="angle">Angle of rectangle that adjacent to diagonal</param>
        /// <param name="adjacentSide">Adjacent side to the angle</param>
        /// <returns>Returns diagonal of rectangle</returns>
        public double ByAngleAndAdjacentSide(double angle, double adjacentSide)
        {
            return angle > 0 && adjacentSide > 0 ? adjacentSide / Math.Cos(angle*(Math.PI/180)) : 0;
        }

        //ToDO: Fix this method tests failed 
        /// <summary>
        /// Calculate diagonal of rectangle using acute angle between two diagonals and area of rectangle.
        /// Acute angle it is angle that less then 90 degrees
        /// </summary>
        /// <param name="acuteAngle">Angle between to diagonals and less then 90 degrees</param>
        /// <param name="area">Area of rectangle</param>
        /// <returns>Diagona of rectangle</returns>
        public double ByAcuteAngleAndArea(double acuteAngle, double area)
        {
            double sinAcuteAngle = Math.Sin(acuteAngle*(Math.PI/180));
            double result = (area * 2)/sinAcuteAngle;
            result = Math.Sqrt(result);
            return (area > 0 && acuteAngle > 0) ? result : 0;
        }

    }
}