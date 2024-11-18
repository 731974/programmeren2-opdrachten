using NUnit.Framework;
using System;
using System.IO;

namespace Assignment1.Tests
{
    [TestFixture]
    public class VehicleTests
    {
        [Test]
        public void StartEngineMethod_ShouldBeVirtual()
        {
            // Arrange & Act
            var method = typeof(Vehicle).GetMethod("StartEngine");

            // Assert
            Assert.IsTrue(method.IsVirtual, "StartEngine method should be virtual.");
        }
    }

    [TestFixture]
    public class DerivedVehicleTests
    {
        [TestCase(typeof(ElectricCar), "Electric engine started")]
        [TestCase(typeof(DieselCar), "Diesel engine started")]
        public void StartEngine_ShouldOverrideBaseMethod(Type vehicleType, string expectedOutput)
        {
            // Arrange
            var vehicle = (Vehicle)Activator.CreateInstance(vehicleType);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            vehicle.StartEngine();
            var output = stringWriter.ToString().Trim();

            // Assert
            Assert.IsTrue(string.Equals(expectedOutput, output, StringComparison.OrdinalIgnoreCase), $"StartEngine should output '{expectedOutput}'.");
        }
    }
}

