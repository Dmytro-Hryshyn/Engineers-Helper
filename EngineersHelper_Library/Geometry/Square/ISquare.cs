namespace Geometry.Square
{
    interface ISquare : IBaseShape
    {
        double Side { get; }
        double Diagonal { get; }

        void GetDiagonal();

    }
}
