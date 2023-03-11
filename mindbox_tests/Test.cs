using Mindbox.Geometry;

namespace Mindbox.Tests
{
    public class Test
    {
        [Fact]
        public void SimpleCircleTest()
        {
            // Arrange
            double radius = 10;
            double expected = 314;

            // Act
            var testedCircle = new Circle(radius);
            double actual = Math.Round(testedCircle.Area);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleTriangleTest() 
        {
            // Arrange
            double firstSide = 5;
            double secondSide = 7;
            double thirdSide = 9;
            double expected = 17.4;

            // Act
            var testedTriangle = new Triangle(firstSide, secondSide, thirdSide);
            double actual = Math.Round(testedTriangle.Area, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RectangularTriangleTest()
        {
            //Arrange
            double firstSide = 7;
            double secondSide = 24;
            double thirdSide = 25;
            bool expected = true;

            // Act
            var testedTriangle = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = testedTriangle.IsRectangular;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NotRectangularTriangleTest()
        {
            //Arrange
            double firstSide = 7;
            double secondSide = 20;
            double thirdSide = 7;
            bool expected = false;

            // Act
            var testedTriangle = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = testedTriangle.IsRectangular;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}