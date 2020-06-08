using System;
using System.Security.Cryptography;

namespace ModernUiDesign.Controls.Geometry
{
    public class Square : ISquare
    {
        public static string DiagonalFromula { get; } = "d = a·√2";
        public static string PerimeterFormula { get; } = "P = a*4";
        public static string AreaFormula { get; } = "A = a²";
        public static string CircumScribedRadiusFromula { get; } = $"R = a*(√2/2)";
        public static string InRadiusFormula { get; } = "r = a/2";

        public double Side { get; private set; }
        public double Diagonal { get; }
        public double Perimeter { get; }
        public double Area { get; }
        public double CircumScribedRadius { get; }
        public double InRadius { get; }
       
        #region GetArea
        public void GetArea()
        {
            Side = Side*Side;
        }

        #endregion

        #region GetCircumScribedRadius
        public void GetCircumScribedRadius()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetDiagonal
        public void GetDiagonal()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetInRadius
        public void GetInRadius()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetPerimeter
        public void GetPerimeter()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
