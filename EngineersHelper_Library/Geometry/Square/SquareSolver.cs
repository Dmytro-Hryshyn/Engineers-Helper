using Geometry.Helper;

namespace Geometry.Square
{
    public class SquareSolver : ISquare, IGeometrySolver
    {
        public double Side { get; private set; }
        public double Diagonal { get; private set; }
        public double Perimeter { get; private set; }
        public double Area { get; private set; }
        public double CircumScribedRadius { get; private set; }
        public double InRadius { get; private set; }

        bool SideIsKnown = false;
        bool DiagonalIsKnown = false;
        bool PerimeterIsKnown = false;
        bool AreaIsKnown = false;
        bool CircumRadiusIsKnown = false;
        bool InRadiusisKnown = false;

        public void SetKnownProperties()
        {
            if (Side > 0 && Diagonal == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                SideIsKnown = true;
            }
            else if (Side == 0 && Diagonal > 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                DiagonalIsKnown = true;
            }
            else if (Side == 0 && Diagonal == 0 && Perimeter > 0 && Area == 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                PerimeterIsKnown = true;
            }
            else if (Side == 0 && Diagonal == 0 && Perimeter == 0 && Area > 0 && CircumScribedRadius == 0 && InRadius == 0)
            {
                AreaIsKnown = true;
            }
            else if (Side == 0 && Diagonal == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius > 0 && InRadius == 0)
            {
                CircumRadiusIsKnown = true;
            }
            else if (Side == 0 && Diagonal == 0 && Perimeter == 0 && Area == 0 && CircumScribedRadius == 0 && InRadius > 0)
            {
                InRadiusisKnown = true;
            }
            else return;
        }
        #region Constructor
        /// <summary>
        /// Default an empty constructor
        /// </summary>
        public SquareSolver()
        {
            SetKnownProperties();
        }
        /// <summary>
        /// Initialize Side property
        /// </summary>
        /// <param name="side">Side of square</param>
        public SquareSolver(double side) 
        {
            Side = side > 0 ? Side = side : Side = 0;

            SetKnownProperties();
        }

        /// <summary>
        /// Initialize Side, Diagonal properties
        /// </summary>
        /// <param name="side">Side of square</param>
        /// <param name="diagonal">Diagonal of square</param>
        public SquareSolver(double side, double diagonal) : this(side)
        {
            Diagonal = diagonal > 0 ? Diagonal = diagonal : Diagonal = 0;
            SetKnownProperties();
        }

        /// <summary>
        /// Initialize Side, Diagonal, Perimeter properties
        /// </summary>
        /// <param name="side">Side of square</param>
        /// <param name="diagonal">Diagonal of square</param>
        /// <param name="perimeter">Perimeter of squre</param>
        public SquareSolver(double side, double diagonal, double perimeter) : this(side, diagonal)
        {
            Perimeter = perimeter > 0 ? Perimeter = perimeter : Perimeter = 0;
            SetKnownProperties();
        }

        /// <summary>
        /// Initialize Side, Diagonal, Perimeter, Area properties
        /// </summary>
        /// <param name="side">Side of square</param>
        /// <param name="diagonal">Diagonal of square</param>
        /// <param name="perimeter">Perimeter of squre</param>
        /// <param name="area">Area of square</param>
        public SquareSolver(double side, double diagonal, double perimeter, double area) : this(side, diagonal, perimeter)
        {
            Area = area > 0 ? Area = area : Area = 0;
            SetKnownProperties();
        }

        /// <summary>
        /// Initialize Side, Diagonal, Perimeter, Area, Circum radius properties
        /// </summary>
        /// <param name="side">Side of square</param>
        /// <param name="diagonal">Diagonal of square</param>
        /// <param name="perimeter">Perimeter of squre</param>
        /// <param name="area">Area of square</param>
        /// <param name="circumScribedRadius">Circum radius of square</param>
        public SquareSolver(double side, double diagonal, double perimeter, double area, double circumScribedRadius) : this(side, diagonal, perimeter, area)
        {
            CircumScribedRadius = circumScribedRadius > 0 ? CircumScribedRadius = circumScribedRadius : CircumScribedRadius = 0;
            SetKnownProperties();
        }

        /// <summary>
        /// Initialize Side, Diagonal, Perimeter, Area, Circum radius, Inside radius properties
        /// </summary>
        /// <param name="side">Side of square</param>
        /// <param name="diagonal">Diagonal of square</param>
        /// <param name="perimeter">Perimeter of squre</param>
        /// <param name="area">Area of square</param>
        /// <param name="circumScribedRadius">Circum radius of square</param>
        /// <param name="inRadius">Inside radius of square</param>
        public SquareSolver(double side, double diagonal, double perimeter, double area, double circumScribedRadius, double inRadius) : this(side, diagonal, perimeter, area, circumScribedRadius)
        {
            InRadius = inRadius > 0 ? InRadius = inRadius : InRadius = 0;
            SetKnownProperties();
        }
        #endregion

        /// <summary>
        /// Calculate Side of square. returns value to a Side property.
        /// </summary>
        public void GetSide()
        {
            if (DiagonalIsKnown)
            {
                Side = Square.GetSideUsingDiagonal(Diagonal);
            }
            else if (AreaIsKnown)
            {
                Side = Square.GetSideUsingArea(Area);
            }
            else if (PerimeterIsKnown)
            {
                Side = Square.GetSideUsingPerimeter(Perimeter);
            }
            else if (CircumRadiusIsKnown)
            {
                Side = Square.GetSideUsingCircumRadius(CircumScribedRadius);
            }
            else if (InRadiusisKnown)
            {
                Side = Square.GetSideUsingInRadius(InRadius);
            }
            else Side = Side;
        }

        /// <summary>
        /// Calculate diagonal of square, returns value to a Diagonal property
        /// </summary>
        public void GetDiagonal()
        {
            if (SideIsKnown)
            {
                Diagonal = Square.GetDiagonalUsingSide(Side);
            }

            else if (PerimeterIsKnown)
            {
                Diagonal = Square.GetDiagonalUsingPerimeter(Perimeter);
            }

            else if (AreaIsKnown)
            {
                Diagonal = Square.GetDiagonalUsingAre(Area);
            }
            else if (CircumRadiusIsKnown)
            {
                Diagonal = Square.GetDiagonalUsingOutRadius(CircumScribedRadius);
            }
            else if (InRadiusisKnown)
            {
                Diagonal = Square.GetDiagonalUsingInRadius(InRadius);
            }
            else Diagonal = Diagonal;
        }


        /// <summary>
        /// Calculate perimeter of square, returns value to Perimeter property
        /// </summary>
        public void GetPerimeter()
        {
            if (SideIsKnown)
            {
                Perimeter = Square.GetPerimeterUsingSide(Side);
            }
            else if (DiagonalIsKnown)
            {
                Perimeter = Square.GetPerimeterUsingDiagonal(Diagonal);
            }
            else if (AreaIsKnown)
            {
                Perimeter = Square.GetPerimeterUsingArea(Area);
            }
            else if (CircumRadiusIsKnown)
            {
                Perimeter = Square.GetPerimeterUsingOutRadius(CircumScribedRadius);
            }
            else if (InRadiusisKnown)
            {
                Perimeter = Square.GetPerimeterUsingInRadius(InRadius);
            }
            else Diagonal = Diagonal ;
        }

        /// <summary>
        ///  Calculate area of square, returns value to Area property
        /// </summary>
        public void GetArea()
        {
            if (SideIsKnown)
            {
                Area = Square.GetAreaUsingSide(Side);
            }

            else if (DiagonalIsKnown)
            {
                Area = Square.GetAreaUsingDiagonal(Diagonal);
            }

            else if (PerimeterIsKnown)
            {
                Area = Square.GetAreaUsingPerimeter(Perimeter);
            }

            else if (CircumRadiusIsKnown)
            {
                Area = Square.GetAreaUsingOutRadius(CircumScribedRadius);
            }

            else if (InRadiusisKnown)
            {
                Area = Square.GetAreaUsingInRadius(InRadius);
            }

            else Area = Area;

        }

        /// <summary>
        /// Calculate circumradius of square, returns value to Circumradius property
        /// </summary>
        public void GetCircumScribedRadius()
        {
            if (SideIsKnown)
            {
                CircumScribedRadius = Square.GetCircumRadiusUsingSide(Side);
            }

            else if (DiagonalIsKnown)
            {
                CircumScribedRadius = Square.GetCircumRadiusUsingDiagonal(Diagonal);
            }

            else if (PerimeterIsKnown)
            {
                CircumScribedRadius = Square.GetCircumRadiusUsingPerimeter(Perimeter);
            }

            else if (AreaIsKnown)
            {
                CircumScribedRadius = Square.GetCircumRadiusUsingArea(Area);
            }

            else if (InRadiusisKnown)
            {
                CircumScribedRadius = Square.GetcircumRadiusUsingInRadius(InRadius);
            }

            else CircumScribedRadius = CircumScribedRadius;
        }


        public void GetInRadius()
        {
            if (SideIsKnown)
            {
                InRadius = Square.GetInRadiusUsingSide(Side);
            }

            else if (DiagonalIsKnown)
            {
                InRadius = Square.GetInRadiusUsingDiagonal(Diagonal);
            }

            else if (PerimeterIsKnown)
            {
                InRadius = Square.GetInRadiusUsingPerimeter(Perimeter);
            }

            else if (AreaIsKnown)
            {
                InRadius = Square.GetInRadiusUsingArea(Area);
            }
            else if (CircumRadiusIsKnown)
            {
                InRadius = Square.GetInRadiusUsingOutRadius(CircumScribedRadius);
            }
            else InRadius = InRadius;
        }

        public void Solve()
        {
            GetSide();
            GetDiagonal();
            GetArea();
            GetPerimeter();
            GetInRadius();
            GetCircumScribedRadius();
        }
    }
}
