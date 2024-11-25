using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class FullTimeEmployeeTests
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
        public void Constructor_WhenCalled_SetsProperties()
        {
            // Arrange
            string name = "John Doe";
            string jobTitle = "Software Engineer";
            decimal salary = 80000m;

            // Act
            var employee = new FullTimeEmployee(name, jobTitle, salary);

            // Assert
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(jobTitle, employee.JobTitle);
            Assert.AreEqual(salary, employee.Salary);
        }

        [Test]
        public void DisplayDetails_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var employee = new FullTimeEmployee("John Doe", "Software Engineer", 80000m);

            // Act
            employee.DisplayDetails();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("name: john doe", output);
            StringAssert.Contains("job title: software engineer", output);
            StringAssert.Contains("salary: 80000", output);
        }

        [Test]
        public void GetSalary_IsNotVirtual()
        {
            // Arrange
            var method = typeof(Employee).GetMethod("GetSalary");

            // Act
            var isVirtual = method.IsVirtual && !method.IsFinal;

            // Assert
            Assert.IsFalse(isVirtual, "GetSalary method should not be virtual.");
        }

        private string NormalizeString(string input)
        {
            return input.Replace("\r\n", "\n").ToLowerInvariant();
        }
    }

    [TestFixture]
    public class PartTimeEmployeeTests
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
        public void Constructor_WhenCalled_SetsProperties()
        {
            // Arrange
            string name = "Jane Doe";
            string jobTitle = "Consultant";
            decimal hourlyRate = 50m;
            int hoursWorked = 20;

            // Act
            var employee = new PartTimeEmployee(name, jobTitle, hourlyRate, hoursWorked);

            // Assert
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(jobTitle, employee.JobTitle);
            Assert.AreEqual(hourlyRate * hoursWorked, employee.Salary);
        }

        [Test]
        public void DisplayDetails_WhenCalled_WritesExpectedOutput()
        {
            // Arrange
            var employee = new PartTimeEmployee("Jane Doe", "Consultant", 50m, 20);

            // Act
            employee.DisplayDetails();

            // Assert
            var output = NormalizeString(_stringWriter.ToString().Trim());
            StringAssert.Contains("name: jane doe", output);
            StringAssert.Contains("job title: consultant", output);
            StringAssert.Contains("salary: 1000", output);
        }

        [Test]
        public void GetSalary_IsNotVirtual()
        {
            // Arrange
            var method = typeof(Employee).GetMethod("GetSalary");

            // Act
            var isVirtual = method.IsVirtual && !method.IsFinal;

            // Assert
            Assert.IsFalse(isVirtual, "GetSalary method should not be virtual.");
        }

        private string NormalizeString(string input)
        {
            return input.Replace("\r\n", "\n").ToLowerInvariant();
        }
    }
}