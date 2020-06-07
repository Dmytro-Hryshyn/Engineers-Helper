namespace ModernUiDesign.Controls.Geometry
{
    public abstract class AbstractShape
    {
       

        public abstract double Diagonal { get; set; }
        public abstract string DiagonalFromula { get; }

        public abstract double Perimeter { get; set; }
        public abstract string PerimeterFormula { get;}

        public abstract double Area { get; set; }
        public abstract string AreaFormula { get; }

        public abstract double CircumScribedRadius { get; set; }
        public abstract string CircumScribedRadiusFromula { get; }

        public abstract double InRadius { get; set; }
        public abstract string InRadiusFormula { get; }

        public abstract double GetPerimeter();

        public abstract double GetArea();

        public abstract double GetDiagonal();

        public abstract double GetCircumScribedRadius();

        public abstract double GetInscribedCircleRadius();
    }
}
