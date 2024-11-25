using NUnit.Framework;
using System;
using System.IO;

namespace Assignment4.Tests
{
    [TestFixture]
    public class EmployeeTests
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
        public void Manager_DisplayRole_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var manager = new Manager();

            // Act
            manager.DisplayRole();

            // Assert
            var output = _stringWriter.ToString().Trim();
            StringAssert.AreEqualIgnoringCase("Manager role", output);
        }

        [Test]
        public void Developer_DisplayRole_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var developer = new Developer();

            // Act
            developer.DisplayRole();

            // Assert
            var output = _stringWriter.ToString().Trim();
            StringAssert.AreEqualIgnoringCase("Developer role", output);
        }
    }
}
