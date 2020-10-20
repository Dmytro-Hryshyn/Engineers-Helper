
namespace Geometry.Rectangle
{
    public class Rectangle : IRectangle
    {
        public GetSide GetSide { get; private set; } = new GetSide();
        public GetDiagonal GetDiagonal { get; private set; } = new GetDiagonal();
        public GetPerimeter GetPerimeter { get;  private set; }  = new GetPerimeter();
        public GetArea GetArea { get; private set; } = new GetArea();
        public GetOutRadius GetOutRadius { get; private set; } = new GetOutRadius();
        public GetInRadius GetInRadius { get; private set; }
        public GetOppositeAngle GetOppositeAngle { get; private set; } = new GetOppositeAngle();
        public GetAdjacentAngle GetAdjacentAngle { get; private set; } = new GetAdjacentAngle();
    }
}