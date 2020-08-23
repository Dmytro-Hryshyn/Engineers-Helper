namespace Geometry.Rectangle
{
    public class Rectangle : IRectangle
    {
        public GetPerimeter GetPerimeter { get;  private set; }  = new GetPerimeter();
        public GetArea GetArea { get; private set; } = new GetArea();
        public GetDiagonal GetDiagonal { get; private set; } = new GetDiagonal();
        public GetOutRadius GetOutRadius { get; private set; }
        public GetInRadius GetInRadius { get; private set; }
        public GetSide GetSide { get; private set; }
       
    }
}