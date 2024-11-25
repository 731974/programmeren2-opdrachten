using NUnit.Framework;
using System;
using System.IO;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class FullTimeEmployeeReportTests
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
        public void GenerateReport_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var employee = new FullTimeEmployee("John Doe", "Software Engineer", 80000m);

            // Act
            employee.GenerateReport();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("employee report:", output);
            StringAssert.Contains("full-time employee with fixed salary:", output);
            StringAssert.Contains("name: john doe", output);
            StringAssert.Contains("job title: software engineer", output);
            StringAssert.Contains("salary: 80000", output);
        }

        private string NormalizeString(string input)
        {
            return input.Replace("\r\n", "\n").ToLowerInvariant();
        }
    }

    [TestFixture]
    public class PartTimeEmployeeReportTests
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
        public void GenerateReport_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var employee = new PartTimeEmployee("Jane Doe", "Consultant", 50m, 20);

            // Act
            employee.GenerateReport();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("employee report:", output);
            StringAssert.Contains("part-time employee with hourly wage:", output);
            StringAssert.Contains("name: jane doe", output);
            StringAssert.Contains("job title: consultant", output);
            StringAssert.Contains("salary: 1000", output);
        }

        private string NormalizeString(string input)
        {
            return input.Replace("\r\n", "\n").ToLowerInvariant();
        }
    }
}
