using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUiDesign.Controls.Geometry
{
    abstract class Shape
    {
        public virtual byte NumberOfSides { get; } = 3;

        public virtual double Diagonal { get; set; }

        public virtual double Perimeter { get; set; }

        public virtual double Area { get; set; }

        public virtual double CircumScribedRadius { get; set; }

        public virtual double InscribeCircleRadius { get; set; }




        public abstract double GetPerimeter();

        public abstract double GetArea();

        public abstract double GetDiagonal();

        public abstract double GetCircumscribedRadius();

        public abstract double GetInscribedCircleRadius();
    }
}
