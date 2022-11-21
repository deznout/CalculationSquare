using System;
using CalcSquare;


namespace CalcSquare.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(6, -3, 5)]
        [InlineData(4, 10, -5)]
        [InlineData(0, 0, 0)]
        public void InitErrorArgsTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void Test1()
        {
            //Data
            double a = 2d, b = 7d, c = 8d;

            //Act
            Triangle triangle = new Triangle(a, b, c);

            //Assert
            Assert.NotNull(triangle);
            Assert.True(Math.Abs(triangle.SideA - a) < IFigure.accuracy);
            Assert.True(Math.Abs(triangle.SideB - b) < IFigure.accuracy);
            Assert.True(Math.Abs(triangle.SideC - c) < IFigure.accuracy);
        }


        [Fact]
        public void GetSquareTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var actual = triangle.GetSquare();

            // Assert.
            Assert.True(Math.Abs(actual - result) < IFigure.accuracy);

        }

		[Fact]
		public void InitNotTriangleTest()
		{
			Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 4));
		}

        [Theory]
        [InlineData(3, 4, 3, false)]
		[InlineData(3, 4, 5 + 2e-7, false)]
		[InlineData(3, 4, 5, true)]
		[InlineData(3, 4, 5.000000001, true)]
		public void NotRightTriangle(double a, double b, double c, bool answer)
		{
			//Data
			var triangle = new Triangle(a, b, c);

			//Act
			var isRight = triangle.IsTriangleRightAngled;

            //Assert
            Assert.Equal(isRight, answer);
		}

    }
}