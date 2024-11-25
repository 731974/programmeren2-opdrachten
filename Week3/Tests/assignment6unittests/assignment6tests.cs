using NUnit.Framework;
using System;
using System.IO;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class EmployeeMethodTests
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
        public void FullTimeEmployee_DisplayDetails_WritesExpectedOutput()
        {
            // Arrange
            var employee = new FullTimeEmployee("John Doe", "Software Engineer", 80000m);

            // Act
            employee.DisplayDetails();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("full-time employee with fixed salary:", output);
            StringAssert.Contains("name: john doe", output);
            StringAssert.Contains("job title: software engineer", output);
            StringAssert.Contains("salary: 80000", output);
        }

        [Test]
        public void FullTimeEmployee_GetJobDetails_ReturnsExpectedString()
        {
            // Arrange
            var employee = new FullTimeEmployee("John Doe", "Software Engineer", 80000m);

            // Act
            var jobDetails = NormalizeString(employee.GetJobDetails());

            // Assert
            StringAssert.Contains("full-time employee with fixed salary:", jobDetails);
        }

        [Test]
        public void PartTimeEmployee_DisplayDetails_WritesExpectedOutput()
        {
            // Arrange
            var employee = new PartTimeEmployee("Jane Doe", "Consultant", 50m, 20);

            // Act
            employee.DisplayDetails();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("part-time employee with hourly wage:", output);
            StringAssert.Contains("name: jane doe", output);
            StringAssert.Contains("job title: consultant", output);
            StringAssert.Contains("salary: 1000", output);
        }

        [Test]
        public void PartTimeEmployee_GetJobDetails_ReturnsExpectedString()
        {
            // Arrange
            var employee = new PartTimeEmployee("Jane Doe", "Consultant", 50m, 20);

            // Act
            var jobDetails = NormalizeString(employee.GetJobDetails());

            // Assert
            StringAssert.Contains("part-time employee with hourly wage:", jobDetails);
        }

        private string NormalizeString(string input)
        {
            return input.Replace("\r\n", "\n").ToLowerInvariant();
        }
    }
}
