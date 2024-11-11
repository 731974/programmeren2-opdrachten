using NUnit.Framework;
using Assignment3;

namespace Assignment3.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Width_ShouldGetAndSet()
        {
            // Arrange
            var rectangle = new Rectangle();
            var width = 5.0;

            // Act
            rectangle.Width = width;

            // Assert
            Assert.AreEqual(width, rectangle.Width);
        }

        [Test]
        public void Length_ShouldGetAndSet()
        {
            // Arrange
            var rectangle = new Rectangle();
            var length = 10.0;

            // Act
            rectangle.Length = length;

            // Assert
            Assert.AreEqual(length, rectangle.Length);
        }

        [Test]
        public void Area_ShouldReturnCorrectValue()
        {
            // Arrange
            var rectangle = new Rectangle
            {
                Width = 5.0,
                Length = 10.0
            };

            // Act
            var area = rectangle.Area;

            // Assert
            Assert.AreEqual(50.0, area);
        }

        [Test]
        public void Area_ShouldReturnZero_WhenWidthOrLengthIsZero()
        {
            // Arrange
            var rectangle = new Rectangle
            {
                Width = 0.0,
                Length = 10.0
            };

            // Act
            var area = rectangle.Area;

            // Assert
            Assert.AreEqual(0.0, area);

            // Arrange
            rectangle.Width = 5.0;
            rectangle.Length = 0.0;

            // Act
            area = rectangle.Area;

            // Assert
            Assert.AreEqual(0.0, area);
        }
    }
}



