namespace Geometry
{
    public interface IBaseShape
    {
        double Perimeter { get;  }
        double Area { get;  }
        double CircumScribedRadius { get;  }
        double InRadius { get;  }

        void GetSide();
        void GetPerimeter();
        void GetArea();
        void GetCircumScribedRadius();
        void GetInRadius();
    }
}
