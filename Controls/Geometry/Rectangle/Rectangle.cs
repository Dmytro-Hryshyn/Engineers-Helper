namespace Geometry.Rectangle
{
    public class Rectangle : IRectangle
    {
        public GetPerimeter GetPerimeter { get;  private set; }  = new GetPerimeter();
        public GetArea GetArea { get; private set; }
        public GetDiagonal GetDiagonal { get; private set; }
        public GetOutRadius GetOutRadius { get; private set; }
        public GetInRadius GetInRadius { get; private set; }
        public GetSideA GetSideA { get; private set; }
        public GetSideB GetSideB { get; private set; }
    }
}