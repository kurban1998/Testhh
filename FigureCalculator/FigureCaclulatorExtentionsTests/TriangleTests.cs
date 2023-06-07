using FigureCaclulatorExtentions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureCaclulatorExtentionsTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateAreaTest_Success()
        {
            // arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double perimeter = (3 + 4 + 5) / 2;
            var expected = Math.Sqrt(perimeter * (perimeter - 3) * (perimeter - 4) * (perimeter - 5));
            
            // act
            var actual = triangle.CalculateArea();

            // assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void CalculateAreaTest_Failed()
        {
            // arrange
            Triangle triangle = new Triangle(-3, -4, -5);
            var expected = 0;

            // act
            var actual = triangle.CalculateArea();

            // assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void CalculateAreaTest_IsRectangular()
        {
            // arrange
            Triangle triangle = new Triangle(3, 4, 5);
            var expected = true;

            // act
            var actual = triangle.IsRectangular();

            // assert
            actual.Should().Be(expected);
        }
    }
}