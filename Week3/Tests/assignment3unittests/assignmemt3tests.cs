using NUnit.Framework;
using System;
using System.IO;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ContractorTests
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
        public void Constructor_WhenCalled_SetsHourlyRateAndHoursWorked()
        {
            // Arrange
            decimal hourlyRate = 50m;
            int hoursWorked = 20;

            // Act
            var contractor = new Contractor(hourlyRate, hoursWorked);

            // Assert
            Assert.AreEqual(hourlyRate * hoursWorked, contractor.GetPayment());
        }

        [Test]
        public void GetPayment_WhenCalled_ReturnsCorrectPayment()
        {
            // Arrange
            decimal hourlyRate = 60m;
            int hoursWorked = 25;
            var contractor = new Contractor(hourlyRate, hoursWorked);

            // Act
            var payment = contractor.GetPayment();

            // Assert
            Assert.AreEqual(hourlyRate * hoursWorked, payment);
        }

        [Test]
        public void Work_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var contractor = new Contractor(50m, 20);

            // Act
            contractor.Work();

            // Assert
            var output = _stringWriter.ToString().Trim();
            StringAssert.AreEqualIgnoringCase("Contractor is working", output);
        }
    }
}
