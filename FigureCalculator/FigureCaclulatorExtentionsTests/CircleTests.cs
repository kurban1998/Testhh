using FigureCaclulatorExtentions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureCaclulatorExtentionsTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateAreaTest_Success()
        {
            // arrange
            Circle circle = new Circle(3);
            var expected = Math.PI * Math.Pow(3, 2);

            // act
            var actual = circle.CalculateArea();

            // assert
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void CalculateAreaTest_Failed()
        {
            // arrange
            Circle circle = new Circle(-1);
            var expected = 0;

            // act
            var actual = circle.CalculateArea();

            // assert
            actual.Should().Be(expected);
        }
    }
}