namespace Geometry
{
    interface ISquare : IBaseShape
    {
        double Side { get; }
        double Diagonal { get; }

        void GetDiagonal();

    }
}
