using System;
using CalcSquare;


namespace CalcSquare.Tests
{
    public class CircleTests
    {
        [Fact]
        public void ZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0d));
        }


        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1d));
        }


        [Fact]
        public void LessMinRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(Circle.RadiusMin - 1e7));
        }


        [Fact]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);

            var square = circle.GetSquare();

            Assert.True(Math.Abs(square - expectedValue) < IFigure.accuracy);
        }
    }
}
