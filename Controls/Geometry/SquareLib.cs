using System;

namespace ModernUiDesign.Controls.Geometry
{
    public class SquareLib : AbstractShape
    {
        public double Side { get; set; }

        public override double Diagonal { get; set; }

        public override string DiagonalFromula { get; } = "d = a·√2";

        public override double Perimeter { get; set; }

        public override string PerimeterFormula { get; } = "P = a*4";

        public override double Area { get; set; }

        public override string AreaFormula { get; } = "A = a²";

        public override double CircumScribedRadius { get; set; }

        public override string CircumScribedRadiusFromula { get; } = $"R = a*(√2/2)";

        public override double InRadius { get; set; }

        public override string InRadiusFormula { get; } = "r = a/2";


        public override double GetArea()
        {
            return Side != 0 ? Side * Side : 0;
        }

        public override double GetCircumScribedRadius()
        {
            return Side != 0 ? Side * (Math.Sqrt(2) / 2) : 0;
        }

        public override double GetDiagonal()
        {
            return Side != 0 ? Side * Math.Sqrt(2) : 0;
        }

        public override double GetInscribedCircleRadius()
        {
            return Side != 0 ? Side / 2 : 0;
        }



        #region Perimeter

        public override double GetPerimeter() => Side * 4;

        public double GetPerimeter(double side) => side * 4;

        #endregion
    }
}
