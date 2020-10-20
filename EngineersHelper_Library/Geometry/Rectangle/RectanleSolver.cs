using Geometry.Helper;

namespace Geometry.Rectangle
{
    public class RectanleSolver : IGeometrySolver
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Diagonal { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }
        public double CircumscribedRadius { get; set; }
        public double AngleA { get; set; }
        public double AngleB { get; set; }

        private bool sideAIsKnown = false;
        private bool SideBIsKnown = false;
        private bool diagonalIsknown = false;
        private bool perimeterIsKnown = false;
        private bool areaIsKnown = false;
        private bool circumradiusIsKnown = false;
        private bool angle_A_IsKnown = false;
        private bool angle_B_IsKnown = false;

        Rectangle rectangle = new Rectangle();

        public void SetKnownProperties()
        {
            if (SideA != 0
                && SideB == 0
                && Diagonal == 0
                && Perimeter == 0
                && Area == 0
                && CircumscribedRadius == 0
                && AngleA == 0
                && AngleB == 0)
            {
                sideAIsKnown = true;
            }
            if (SideB != 0
               && SideA == 0
               && Diagonal == 0
               && Perimeter == 0
               && Area == 0
               && CircumscribedRadius == 0
               && AngleA == 0
               && AngleB == 0)
            {
                SideBIsKnown = true;
            }

            else if (Diagonal != 0
                     && SideA.IsDefault()
                     && SideB == 0
                     && Perimeter == 0
                     && Area == 0
                     && CircumscribedRadius == 0
                     && AngleA == 0
                     && AngleB == 0)
            {
                diagonalIsknown = true;
            }

            else if (Perimeter != 0
                     && SideA == 0
                     && SideB == 0
                     && Diagonal == 0
                     && Area == 0
                     && CircumscribedRadius == 0
                     && AngleA == 0
                     && AngleB == 0)
            {
                perimeterIsKnown = true;
            }

            else if (Area != 0
                     && SideA.IsDefault()
                     && SideB.IsDefault()
                     && Diagonal.IsDefault()
                     && Perimeter.IsDefault()
                     && CircumscribedRadius.IsDefault()
                     && AngleA.IsDefault()
                     && AngleB.IsDefault())
            {
                areaIsKnown = true;
            }

            else if (CircumscribedRadius != 0
                    && SideA.IsDefault()
                    && SideB.IsDefault()
                    && Diagonal.IsDefault()
                    && Perimeter.IsDefault()
                    && AngleA.IsDefault()
                    && AngleB.IsDefault())
            {
                circumradiusIsKnown = true;
            }
            else if (AngleA != 0
                    && AngleB.IsDefault()
                    && SideA.IsDefault()
                    && SideB.IsDefault()
                    && Perimeter.IsDefault()
                    && Area.IsDefault()
                    && Diagonal.IsDefault()
                    && CircumscribedRadius.IsDefault())
            {
                angle_A_IsKnown = true;
            }
            else if (AngleB != 0
                    && AngleA.IsDefault()
                    && SideA.IsDefault()
                    && SideB.IsDefault()
                    && Perimeter.IsDefault()
                    && Area.IsDefault()
                    && Diagonal.IsDefault()
                    && CircumscribedRadius.IsDefault())
            {
                angle_B_IsKnown = true;
            }
        }

        void FindSides()
        {
            if (SideBIsKnown && diagonalIsknown)
            {
               SideA = rectangle.GetSide.BySideAndDIagonal(SideB, Diagonal);
            }
            else if(sideAIsKnown && diagonalIsknown)
            {
                SideB = rectangle.GetSide.BySideAndDIagonal(SideA, Diagonal);
            }

            else if (sideAIsKnown && perimeterIsKnown)
            {
                SideB = rectangle.GetSide.BySideAndPerimeter(SideA, Perimeter);
            }
            else if (SideBIsKnown && perimeterIsKnown)
            {
                SideA = rectangle.GetSide.BySideAndPerimeter(SideB, Perimeter);
            }

            else if (sideAIsKnown && areaIsKnown)
            {
                SideB = rectangle.GetSide.BySideAndArea(SideA, Area);
            }
            else if (SideBIsKnown && areaIsKnown)
            {
                SideA = rectangle.GetSide.BySideAndArea(SideB, Area);
            }

            else if (diagonalIsknown && angle_A_IsKnown)
            {
               SideA = rectangle.GetSide.ByDiagonalAndOppositeAngle(Diagonal, AngleA);
            }
            else if(diagonalIsknown && angle_B_IsKnown)
            {
                SideB = rectangle.GetSide.ByDiagonalAndOppositeAngle(Diagonal, AngleB);
            }

        }
        void FindDiagonal()
        {
            if (sideAIsKnown && SideBIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.BySide(SideA, SideB);
            }

            else if (perimeterIsKnown && sideAIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByPerimeterAndSide(Perimeter, SideA);
            }
            else if (perimeterIsKnown && SideBIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByPerimeterAndSide(Perimeter, SideB);
            }

            else if (areaIsKnown&& sideAIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByAreaAndSide(Area, SideA);
            }

            else if (areaIsKnown && SideBIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByAreaAndSide(Area, SideB);
            }

            else if (circumradiusIsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByOutRadius(CircumscribedRadius);
            }

            else if (sideAIsKnown && angle_A_IsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByAngleAndOppositeSide(AngleA, SideA);
            }
            else if (SideBIsKnown && angle_B_IsKnown)
            {
                Diagonal = rectangle.GetDiagonal.ByAngleAndOppositeSide(AngleB, SideB);
            }
            
        }
        void FindPerimeter()
        {
            if (sideAIsKnown && SideBIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.BySides(SideA, SideB);
            }

            else if (sideAIsKnown && circumradiusIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByOutRadiusAndSide(CircumscribedRadius, SideA);
            }
            else if (SideBIsKnown && circumradiusIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByOutRadiusAndSide(CircumscribedRadius, SideB);
            }

            else if (diagonalIsknown && sideAIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByDiagonalAndSide(Diagonal, SideA);
            }
            else if (diagonalIsknown && SideBIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByDiagonalAndSide(Diagonal, SideB);
            }

            else if (areaIsKnown && sideAIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByAreaAndSide(Area, SideA);
            }
            else if (areaIsKnown && SideBIsKnown)
            {
                Perimeter = rectangle.GetPerimeter.ByAreaAndSide(Area, SideB);
            }
        }
        void FindArea()
        {
            if (sideAIsKnown && SideBIsKnown)
            {
                Area = rectangle.GetArea.BySides(SideA, SideB);
            }
            else if (perimeterIsKnown && sideAIsKnown)
            {
                Area = rectangle.GetArea.ByPerimeterAndSide(Perimeter, SideA);
            }
            else if (perimeterIsKnown && SideBIsKnown)
            {
                Area = rectangle.GetArea.ByPerimeterAndSide(Perimeter, SideB);
            }
            else if (diagonalIsknown && sideAIsKnown)
            {
                Area = rectangle.GetArea.ByDiagonalAndSide(Diagonal, SideA);
            }
            else if (diagonalIsknown && SideBIsKnown)
            {
                Area = rectangle.GetArea.ByDiagonalAndSide(Diagonal, SideB);
            }
            else if (circumradiusIsKnown && sideAIsKnown)
            {
                Area = rectangle.GetArea.ByOutRadiusAndSide(CircumscribedRadius, SideA);
            }
            else if (diagonalIsknown && SideBIsKnown)
            {
                Area = rectangle.GetArea.ByDiagonalAndSide(Diagonal, SideB);
            }

        }
        void FindCircumScribedRadius()
        {
            if (sideAIsKnown && SideBIsKnown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.ByTwoSides(SideA, SideB);
            }
            else if (diagonalIsknown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.ByDiagonal(Diagonal);
            }
            else if (areaIsKnown && sideAIsKnown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.BySideAndArea(SideA, Area);
            }
            else if (areaIsKnown && SideBIsKnown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.BySideAndArea(SideB, Area);
            }
            else if (perimeterIsKnown && sideAIsKnown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.BySideAndPerimeter(SideA, Perimeter);
            }
            else if (perimeterIsKnown && SideBIsKnown)
            {
                CircumscribedRadius = rectangle.GetOutRadius.BySideAndPerimeter(SideB, Perimeter);
            }


        }
        void FindAngleA()
        {
            if (sideAIsKnown && diagonalIsknown)
            {
                AngleA = rectangle.GetOppositeAngle.BySideAndDiagonal(SideA, Diagonal);
            } 
        }

        void FindAngleB()
        {
            if (sideAIsKnown && diagonalIsknown)
            {
                AngleB = rectangle.GetAdjacentAngle.BySideAndDiagonal(SideA, Diagonal);
            }
        }
        


        public void Solve()
        {
            FindSides();
            FindDiagonal();
            FindPerimeter();
            FindArea();
            FindCircumScribedRadius();
            FindAngleA();
            FindAngleB();
        }
    }
}
