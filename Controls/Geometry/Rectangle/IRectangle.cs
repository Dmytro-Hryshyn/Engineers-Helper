using System.Windows.Forms;

namespace Geometry.Rectangle
{
    interface IRectangle
    {
        public GetSideA GetSideA { get;  }
        public GetSideB GetSideB { get;  }
        public GetPerimeter GetPerimeter { get; }
        public GetArea GetArea { get;  }
        public GetDiagonal GetDiagonal { get;  }
        public GetOutRadius GetOutRadius { get;  }
        public GetInRadius GetInRadius { get;  }


    }


}

