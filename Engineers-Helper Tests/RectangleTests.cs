using Geometry.Rectangle;
using System;
using Xunit;

namespace EngineersHelperTests

{
    public class RectangleTests
    {
        Rectangle rectangle = new Rectangle();

        #region GetPerimeter tests

        [Theory]
        [InlineData(5, 15, 40)]
        [InlineData(5.5, 10.5, 32)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]
        public void GetPerimeter_UsingSides(double SideA, double SideB, double expected)
        {
            double actual = double.MaxValue;
            actual = rectangle.GetPerimeter.BySides(SideA, SideB);
            Assert.Equal(expected, actual);
        }

        [Theory]
        //Needs to round value on test to 3 digit after floating point
        [InlineData(25, 5, 20)]
        [InlineData(30.5, 3.5, 24.429)]
        [InlineData(-25, -5, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(10, 0, 0)]
        public void GetPerimeter_SolveByAreaAndSide(double area, double side, double expected)
        {
            double actual = double.MaxValue;
            actual = rectangle.GetPerimeter.ByAreaAndSide(area, side);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(15, 5, 38.284)]
        [InlineData(10.5, 3.5, 26.799)]
        [InlineData(-25, -5, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(10, 0, 0)]
        public void GetPerimeter_DiagonalAndSide(double diagonal, double side, double expected)
        {
            double actual = double.MaxValue;
            actual = Math.Round(rectangle.GetPerimeter.ByDiagonalAndSide(diagonal, side), 3);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20, 10, 97.460)]
        [InlineData(15.5, 10.5, 79.335)]
        [InlineData(-25, -5, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(10, 0, 0)]
        public void GetPerimeter_OutRadiusAndSide(double outradius, double side, double expected)
        {
            double actual = double.MaxValue;
            actual = Math.Round(rectangle.GetPerimeter.ByOutRadiusAndSide(outradius, side), 3);

            Assert.Equal(expected, actual);
        }

        #endregion

        #region GetArea Tests
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(5.5, 5.5, 30.25)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]
        public void GetArea_BySides(double SideA, double SideB, double expected)
        {
            var actual = double.MaxValue;
            actual = Math.Round(rectangle.GetArea.BySides(SideA, SideB), 3);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(30, 5, 50)]
        [InlineData(32, 5.5, 57.75)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(30, 35, 0)]
        public void GetArea_PerimeterAndSideAreKnown(double perimeter, double side, double expected)
        {
            double actual = double.PositiveInfinity;
            actual = rectangle.GetArea.ByPerimeterAndSide(perimeter, side);
            actual = Math.Round(actual, 3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(11.1803, 10, 50)]
        [InlineData(11.8533, 10.5, 57.75)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(30, 35, 0)]
        public void GetArea_DiagonalandSideAreKnown(double diagonal, double side, double expected)
        {
            double actual = double.PositiveInfinity;
            actual = rectangle.GetArea.ByDiagonalAndSide(diagonal, side);
            actual = Math.Round(actual, 2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(63.435 * 2, 11.18, 50)]
        [InlineData(62.354 * 2, 11.853, 57.75)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]

        public void GetArea_AcuteAngleandDiagonal(double acuteAngle, double diagonal, double expected)
        {
            double actual = double.PositiveInfinity;
            actual = rectangle.GetArea.ByAcuteAngleAndDiagonal(acuteAngle, diagonal);
            actual = Math.Round(actual, 2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5.5901, 5, 50)]
        [InlineData(5.9266, 5.5, 57.75)]
        [InlineData(5.9266, 10.5, 57.75)]
        [InlineData(-3, -5, 0)]
        [InlineData(0, 4, 0)]
        public void GetArea_OutRadiusAndSide(double outRadius, double side, double expected)
        {
            double actual = double.MaxValue;
            actual = rectangle.GetArea.ByOutRadiusAndSide(outRadius, side);
            actual = Math.Round(actual, 2);
            Assert.Equal(expected, actual);
        }


        #endregion

        #region GetDiagonal Tests
        [Theory]
        [InlineData(5, 10, 11.18)]
        [InlineData(5.5, 10.5, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagonal_TwoSidesAreKnown(double sideA, double sideB, double expected)
        {
            double actual = rectangle.GetDiagonal.BySide(sideA, sideB);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 10, 11.18)]
        [InlineData(57.75, 10.5, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagonal_AreaAndSideAreKnown(double area, double side, double expected)
        {
            double actual = rectangle.GetDiagonal.ByAreaAndSide(area, side);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(30, 10, 11.18)]
        [InlineData(32, 10.5, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagonal_PerimeterAndSideAreKnown(double perimeter, double side, double expected)
        {
            double actual = rectangle.GetDiagonal.ByPerimeterAndSide(perimeter, side);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDiagonal_OutRadiusTimesTwo()
        {
            double actual = rectangle.GetDiagonal.ByOutRadius(5);
            double expected = 10;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(63.435, 10, 11.18)]
        [InlineData(62.354, 10.5, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagonal_ByAngleAndOppositeSide(double angle, double side, double expected)
        {
            double actual = rectangle.GetDiagonal.ByAngleAndOppositeSide(angle, side);
            actual = Math.Round(actual, 3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(63.435, 5, 11.18)]
        [InlineData(62.354, 5.5, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagonal_ByAngleAndAdjacentSide(double angle, double adjacentSide, double expected)
        {
            double actual = rectangle.GetDiagonal.ByAngleAndAdjacentSide(angle, adjacentSide);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(53.13, 50, 11.18)]
        [InlineData(55.3, 57.75, 11.853)]
        [InlineData(0, 10.5, 0)]
        [InlineData(5.5, 0, 0)]
        public void GetDiagona_ByAcuteangleAndArea(double angle, double area, double expected)
        {
            double actual = rectangle.GetDiagonal.ByAcuteAngleAndArea(angle, area);
            actual = Math.Round(actual, 3);
            Assert.Equal(expected, actual);
        }
        #endregion

        #region GetSide Tests

        [Theory]
        [InlineData(5, 11.18, 10)]
        [InlineData(0, 11.18, 0)]
        public void GetSide_ByEnotherSideAndDiagonal_ShouldCalculateSide(double side, double diagonal, double expected)
        {
            var actual = rectangle.GetSide.BySideAndDIagonal(side, diagonal);

            Assert.Equal(expected, Math.Round(actual, 3));
        }

        [Theory]
        [InlineData(5, 50, 10)]
        [InlineData(0, 50, 0)]
        public void GetSide_ByOtherSideAndArea_ShouldCalculateSide(double side, double area, double expected)
        {
            double actual = rectangle.GetSide.BySideAndArea(side, area);
            Assert.Equal(expected, Math.Round(actual, 3));
        }

        [Theory]
        [InlineData(5, 30, 10)]
        [InlineData(0, 50, 0)]
        public void GetSide_ByOtherSideAndPerimeter_ShouldCalculateSide(double side, double perimeter, double expected)
        {
            double actual = rectangle.GetSide.BySideAndPerimeter(side, perimeter);
            Assert.Equal(expected, Math.Round(actual, 3));
        }

        [Theory]
        [InlineData(9.433981132, 32.00538321,5)]
        [InlineData(6.800735254, 53.97262661, 5.5)]
        public void GetSide_ByOppositeAngle_AndDiagonal_ShouldCalculate_OppisiteSide(double diagonal, double angle, double expected)
        {
            double actual = rectangle.GetSide.ByDiagonalAndOppositeAngle(diagonal, angle);
            Assert.Equal(expected, Math.Round(actual, 3));
        }

        [Theory]
        [InlineData(9.433981132, 32.00538321, 8)]
        [InlineData(6.800735254, 53.97262661, 4)]
        public void GetSide_ByAdjacentAngle_AndDiagonal_ShouldCalculate_AdjacentSide(double diagonal, double angle, double expected)
        {
            double actual = rectangle.GetSide.ByDiagonalAndAdjacentAngle(diagonal, angle);
            Assert.Equal(expected, Math.Round(actual, 3));
        }
        #endregion

        #region GetOutRadius
        [Theory]
        [InlineData(5, 8, 4.716990566)]
        [InlineData(5.5, 4, 3.400367627)]
        [InlineData(0, 4, 0)]
        [InlineData(4, 0, 0)]
        public void GetOutRadius_Using_twoSides_OutRadiusShouldCalculate(double sideA, double sideB, double expected)
        {
            var actual = rectangle.GetOutRadius.ByTwoSides(sideA, sideB);
            Assert.Equal(Math.Round(expected,2), Math.Round(actual,2));
        }

        [Theory]
        [InlineData(5, 26, 4.716990566)]
        [InlineData(5.5, 19, 3.400367627)]
        [InlineData(0, 4, 0)]
        [InlineData(4, 0, 0)]
        public void GetOutRadius_Using_SideAndPerimeter_OutRadiusShouldCalculate(double side, double perimeter, double expected)
        {
            double actual = rectangle.GetOutRadius.BySideAndPerimeter(side, perimeter);
            Assert.Equal(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        [Theory]
        [InlineData(5, 40, 4.716990566)]
        [InlineData(5.5, 22, 3.400367627)]
        [InlineData(0, 4, 0)]
        [InlineData(4, 0, 0)]
        public void GetOutRadius_Using_SideAndArea_OutRadiusShouldCalculate(double side, double area, double expected)
        {
            double actual = rectangle.GetOutRadius.BySideAndArea(side, area);
            Assert.Equal(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        [Theory]
        [InlineData(9.433981132, 4.716990566)]
        [InlineData(6.800735254, 3.400367627)]
        [InlineData(0, 0)]
      
        public void GetOutRadius_Using_Diagonal_OutRadiusShouldCalculate(double diagonal, double expected)
        {
            double actual = rectangle.GetOutRadius.ByDiagonal(diagonal);
            Assert.Equal(expected, actual);
        }


        #endregion
    }
}
