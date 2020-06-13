using System;

namespace ModernUiDesign.Controls.Geometry
{
    public class SquareSolver : ISquare
    {
        public SquareSolver(double side, double diagonal, double perimeter, double area, double circumScribedRadius, double inRadius)
        {
            Side = side;
            Diagonal = diagonal;
            Perimeter = perimeter;
            Area = area;
            CircumScribedRadius = circumScribedRadius;
            InRadius = inRadius;
            Calculate();
        }
        public SquareSolver()
        {

        }


        public static string DiagonalFromula { get; } = "d = a·√2";
        public static string PerimeterFormula { get; } = "P = a*4";
        public static string AreaFormula { get; } = "A = a²";
        public static string CircumScribedRadiusFromula { get; } = $"R = a*(√2/2)";
        public static string InRadiusFormula { get; } = "r = a/2";

        public double Side { get; private set; }
        public double Diagonal { get; private set; }
        public double Perimeter { get; private set; }
        public double Area { get; private set; }
        public double CircumScribedRadius { get; private set; }
        public double InRadius { get; private set; }




        #region GetArea
        /// <summary>
        /// Calculate Area of square. Return answer to the Area property.
        /// </summary>
        public void GetArea()
        {
            if (Side != 0 && Diagonal == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)

            {

                Area = Side * Side;
            }

            else if (Perimeter != 0 && Side == 0 && Diagonal == 0 && CircumScribedRadius == 0 && InRadius == 0)

            {
                Area = Math.Pow(Perimeter, 2) / 16;
            }

            else if (Diagonal != 0 && Side == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                Area = Diagonal * Diagonal / 2;
            }

            else if (CircumScribedRadius != 0 && Side == 0 && Perimeter == 0 && Area == 0 && Diagonal == 0 && InRadius == 0)
            {
                Area = 2 * CircumScribedRadius * CircumScribedRadius;
            }

            else if (InRadius != 0 && Side == 0 && Diagonal == 0 && Area == 0 && Perimeter == 0 && CircumScribedRadius == 0)
            {
                Area = 4 * InRadius * InRadius;
            }

            else Area = 0;

        }

        #endregion

        #region GetCircumScribedRadius
        /// <summary>
        /// Calculate circum scribed radius if side of square is known, return answer to CircumScribedRadius property.
        /// </summary>
        public void GetCircumScribedRadius()
        {
            if (Side != 0)
            {
                CircumScribedRadius = Side * (Math.Sqrt(2) / 2);
            }
            else
            {
                CircumScribedRadius = 0;
            }

        }
        #endregion

        #region GetDiagonal
        /// <summary>
        /// Calculate diagonal of square in terms square side. Return answer to Diagonal property
        /// </summary>
        public void GetDiagonal()
        {
            if (Side != 0)
            {
                Diagonal = Side * Math.Sqrt(2);
            }
            else Diagonal = 0;
        }
        #endregion

        #region GetInRadius
        /// <summary>
        /// Calculate inside radius in terms of square Side. Return asnwer to InRadius property.
        /// </summary>
        public void GetInRadius()
        {
            if (Side != 0)
            {
                InRadius = Side / 2;
            }
        }
        #endregion

        #region GetPerimeter
        public void GetPerimeter()
        {
            if (Side != 0)
            {
                Perimeter = Side * 4;
            }
        }
        #endregion
        public void GetSide()
        {
            if (Side != 0)
                return;

            else if (Diagonal != 0 && Side == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                Side = Diagonal / Math.Sqrt(2);
            }
            else Side = 0;
        }
        void Calculate()
        {

            if (Side != 0 && Diagonal == 0 && Perimeter == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                Diagonal = Side * Math.Sqrt(2);
            }
            else if (Diagonal != 0 && Side == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                Side = Diagonal / Math.Sqrt(2);
            }
        }
    }
}
