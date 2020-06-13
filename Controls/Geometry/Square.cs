using System;

namespace ModernUiDesign.Controls.Geometry
{
    public  static class Square
    {
        #region Get Side
        /// <summary>
        /// Calculate side of square using perimeter.
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>Side of square</returns>
        public static double GetSideUsingPerimeter(double perimeter) => perimeter / 4;

        /// <summary>
        /// Calculate side of square using diagonal.
        /// </summary>
        /// <param name="diagonal"></param>
        /// <returns>Side of square</returns>
        public static double GetSideUsingDiagonal(double diagonal) => diagonal / Math.Sqrt(2);

        /// <summary>
        /// Calculate side of square using Area.
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Side of square</returns>
        public static double GetSideUsingArea(double area) => Math.Sqrt(area);

        /// <summary>
        /// Calculate side of square using inside radius.
        /// </summary>
        /// <param name="inRadius"></param>
        /// <returns>Side of square</returns>
        public static double GetSideUsingInRadius(double inRadius) => inRadius * 2;

        /// <summary>
        /// Calculate side of square using circumscribed radius.
        /// </summary>
        /// <param name="circumRadius"></param>
        /// <returns>Side of square</returns>
        public static double GetSideUsingCircumRadius(double circumRadius) => circumRadius / (Math.Sqrt(2) / 2);
        #endregion

        #region Get Diagonal

        /// <summary>
        /// Calculate diagonal using side of square
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Diagonal of square</returns>
        public static double GetDiagonalUsingSide(double side) => side * Math.Sqrt(2);

        /// <summary>
        /// Calculate area using perimeter of square
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>Diagonal of square</returns>
        public static double GetDiagonalUsingPerimeter(double perimeter) => perimeter / (2 * Math.Sqrt(2));

        /// <summary>
        /// Calculate area using area of square
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Diagonal of square</returns>
        public static double GetDiagonalUsingAre(double area) => Math.Sqrt(2 * area);

        /// <summary>
        /// Calculate area using circumradius of square
        /// </summary>
        /// <param name="outRadius"></param>
        /// <returns>Diagonal of square</returns>
        public static double GetDiagonalUsingOutRadius(double outRadius) => 2 * outRadius;

        /// <summary>
        /// Calculate area using inside radius of square
        /// </summary>
        /// <param name="inRadius"></param>
        /// <returns>Diagonal of square</returns>
        public static double GetDiagonalUsingInRadius(double inRadius) => 2 * inRadius * Math.Sqrt(2); 
        #endregion

        #region Get Perimeter
        /// <summary>
        /// Calculate perimeter using side of square
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Perimeter of square</returns>
        public static double GetPerimeterUsingSide(double side) => side * 4;

        /// <summary>
        /// Calculate perimeter using diagonal of square
        /// </summary>
        /// <param name="diagonal"></param>
        /// <returns>Perimeter of square</returns>
        public static double GetPerimeterUsingDiagonal(double diagonal) => diagonal * 2 * Math.Sqrt(2);

        /// <summary>
        /// Calculate perimeter using area of square
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Perimeter of square</returns>
        public static double GetPerimeterUsingArea(double area) => 4 * Math.Sqrt(area);

        /// <summary>
        /// Calculate perimeter using incribed radius of square
        /// </summary>
        /// <param name="inRadius"></param>
        /// <returns></returns>
        public static double GetPerimeterUsingInRadius(double inRadius) => 8 * inRadius;

        /// <summary>
        /// Calculate perimeter using circumscribed radius of square
        /// </summary>
        /// <param name="outRadius"></param>
        /// <returns>Perimeter of square</returns>
        public static double GetPerimeterUsingOutRadius(double outRadius) => 4 * outRadius * Math.Sqrt(2);

        #endregion

        #region Get Area
        /// <summary>
        /// Calculate area using side of square
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Area of square</returns>
        public static double GetAreaUsingSide(double side) => side * side;

        /// <summary>
        /// Calculate area using diagonal of square
        /// </summary>
        /// <param name="diagonal"></param>
        /// <returns>Area of square</returns>
        public static double GetAreaUsingDiagonal(double diagonal) => (diagonal * diagonal) / 2;

        /// <summary>
        /// Calculate area using perimeter of square
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>Area of square</returns>
        public static double GetAreaUsingPerimeter(double perimeter) => (perimeter * perimeter) / 16;

        /// <summary>
        /// Calculate area using inside radius of square
        /// </summary>
        /// <param name="inRadius"></param>
        /// <returns>Area of square</returns>
        public static double GetAreaUsingInRadius(double inRadius) => 4 * (inRadius * inRadius);

        /// <summary>
        /// Calculate area using circumscribed radius of square
        /// </summary>
        /// <param name="outRadius"></param>
        /// <returns>Area of square</returns>
        public static double GetAreaUsingOutRadius(double outRadius) => 2 * (outRadius * outRadius);

        #endregion

        #region Get InRadius

        /// <summary>
        /// Calculate inside radius using side of square
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Inside radius of square</returns>
        public static double GetInRadiusUsingSide(double side) => side / 2;

        /// <summary>
        /// Calculate area using diagonal of square
        /// </summary>
        /// <param name="diagonal"></param>
        /// <returns>Inside radius of square</returns>
        public static double GetInRadiusUsingDiagonal(double diagonal) => diagonal / (2 * Math.Sqrt(2));

        /// <summary>
        /// Calculate area using perimeter of square
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>Inside radius of square</returns>
        public static double GetInRadiusUsingPerimeter(double perimeter) => perimeter / 8;

        /// <summary>
        /// Calculate area using area of square
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Inside radius of square</returns>
        public static double GetInRadiusUsingArea(double area) => Math.Sqrt(area) / 2;

        /// <summary>
        /// Calculate area using circumradius of square
        /// </summary>
        /// <param name="outRadius"></param>
        /// <returns>Inside radius of square</returns>
        public static double GetInRadiusUsingOutRadius(double outRadius) => outRadius / Math.Sqrt(2);

        #endregion

        #region Get Circumradius

        /// <summary>
        /// Calculate Circumradius using side of square
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Circumradius of square</returns>
        public static double GetCircumRadiusUsingSide(double side) => side * (Math.Sqrt(2) / 2);

        /// <summary>
        /// Calculate area using diagonal of square
        /// </summary>
        /// <param name="diagonal"></param>
        /// <returns>Circumradius of square</returns>
        public static double GetCircumRadiusUsingDiagonal(double diagonal) => diagonal / 2;

        /// <summary>
        /// Calculate area using perimeter of square
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>Circumradius of square</returns>
        public static double GetCircumRadiusUsingPerimeter(double perimeter) => perimeter / (4 * Math.Sqrt(2));

        /// <summary>
        /// Calculate area using area of square
        /// </summary>
        /// <param name="area"></param>
        /// <returns>Circumradius of square</returns>
        public static double GetCircumRadiusUsingArea(double area) => Math.Sqrt(2 * area) / 2;

        /// <summary>
        /// Calculate area using diagonal of square
        /// </summary>
        /// <param name="inRadius"></param>
        /// <returns>Circumradius of square</returns>
        public static double GetcircumRadiusUsingInRadius(double inRadius) => inRadius * Math.Sqrt(2);
        #endregion
    }
}
