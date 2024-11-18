using NUnit.Framework;
using System;

namespace Assignment2.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void ShapeClass_ShouldBeAbstract()
        {
            // Arrange & Act
            var type = typeof(Shape);

            // Assert
            Assert.IsTrue(type.IsAbstract, "Shape class should be abstract.");
        }

        [Test]
        public void CalculateAreaMethod_ShouldBeAbstract()
        {
            // Arrange & Act
            var method = typeof(Shape).GetMethod("CalculateArea");

            // Assert
            Assert.IsTrue(method.IsAbstract, "CalculateArea method should be abstract.");
        }

        [Test]
        public void GetShapeInfoMethod_ShouldBeVirtual()
        {
            // Arrange & Act
            var method = typeof(Shape).GetMethod("GetShapeInfo");

            // Assert
            Assert.IsTrue(method.IsVirtual, "GetShapeInfo method should be virtual.");
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_ShouldInitializeRadius()
        {
            // Arrange
            var radius = 5.0;

            // Act
            var circle = new Circle(radius);

            // Assert
            Assert.AreEqual(radius, circle.Radius, "Constructor should initialize Radius property.");
        }

        [Test]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            var radius = 5.0;
            var circle = new Circle(radius);
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, area, 0.0001, "CalculateArea should return the correct area.");
        }

        [Test]
        public void GetShapeInfo_ShouldReturnCorrectInfo()
        {
            // Arrange
            var radius = 5.0;
            var circle = new Circle(radius);
            var expectedInfo = $"Circle area: {circle.CalculateArea():f2} \nCircle details: Circle with radius: {radius}";

            // Act
            var info = circle.GetShapeInfo();

            // Assert
            Assert.IsTrue(string.Equals(expectedInfo, info, StringComparison.OrdinalIgnoreCase), "GetShapeInfo should return the correct information.");
        }
    }

    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ShouldInitializeLengthAndWidth()
        {
            // Arrange
            var length = 10.0;
            var width = 5.0;

            // Act
            var rectangle = new Rectangle(length, width);

            // Assert
            Assert.AreEqual(length, rectangle.Length, "Constructor should initialize Length property.");
            Assert.AreEqual(width, rectangle.Width, "Constructor should initialize Width property.");
        }

        [Test]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            var length = 10.0;
            var width = 5.0;
            var rectangle = new Rectangle(length, width);
            var expectedArea = length * width;

            // Act
            var area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, area, 0.0001, "CalculateArea should return the correct area.");
        }

        [Test]
        public void GetShapeInfo_ShouldReturnCorrectInfo()
        {
            // Arrange
            var length = 10.0;
            var width = 5.0;
            var rectangle = new Rectangle(length, width);
            var expectedInfo = $"Rectangle area: {rectangle.CalculateArea():f2} \nRectangle details: Rectangle with length: {length}, width: {width}";

            // Act
            var info = rectangle.GetShapeInfo();

            // Assert
            Assert.IsTrue(string.Equals(expectedInfo, info, StringComparison.OrdinalIgnoreCase), "GetShapeInfo should return the correct information.");
        }
    }
}
