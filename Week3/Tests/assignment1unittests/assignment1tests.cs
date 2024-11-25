using NUnit.Framework;
using System;
using System.IO;

namespace Assignment1.Tests
{
    [TestFixture]
    public class VehicleTests
    {
        private StringWriter _stringWriter;

        [SetUp]
        public void Setup()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
        }

        [Test]
        public void Car_Drive_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Drive();

            // Assert
            var output = _stringWriter.ToString().Trim();
            StringAssert.AreEqualIgnoringCase("Car is driving", output);
        }

        [Test]
        public void Bike_Drive_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var bike = new Bike();

            // Act
            bike.Drive();

            // Assert
            var output = _stringWriter.ToString().Trim();
            StringAssert.AreEqualIgnoringCase("Bike is pedaling", output);
        }
    }
}
