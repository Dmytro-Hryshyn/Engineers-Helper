
namespace Geometry.Rectangle
{
    interface IRectangle
    {
        public GetSide GetSide { get; }
        public GetPerimeter GetPerimeter { get; }
        public GetArea GetArea { get; }
        public GetDiagonal GetDiagonal { get;  }
        public GetOutRadius GetOutRadius { get;  }
        public GetInRadius GetInRadius { get;  }


    }

}

