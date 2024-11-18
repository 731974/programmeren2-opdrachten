using NUnit.Framework;
using System;
using System.Globalization;
using System.IO;

namespace Assignment4.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void EmployeeClass_ShouldBeAbstract()
        {
            // Arrange & Act
            var type = typeof(Employee);

            // Assert
            Assert.IsTrue(type.IsAbstract, "Employee class should be abstract.");
        }

        [Test]
        public void CalculateBonusMethod_ShouldBeAbstract()
        {
            // Arrange & Act
            var method = typeof(Employee).GetMethod("CalculateBonus");

            // Assert
            Assert.IsTrue(method.IsAbstract, "CalculateBonus method should be abstract.");
        }

        [Test]
        public void DisplayEmployeeDetailsMethod_ShouldBeVirtual()
        {
            // Arrange & Act
            var method = typeof(Employee).GetMethod("DisplayEmployeeDetails");

            // Assert
            Assert.IsTrue(method.IsVirtual, "DisplayEmployeeDetails method should be virtual.");
        }

        [TestCase(typeof(FullTimeEmployee), "John Doe", 5000, 500, "Full-time Employee: John Doe\nSalary: 5000.00\nBonus: 500.00")]
        [TestCase(typeof(PartTimeEmployee), "Jane Smith", 3000, 150, "Part-time Employee: Jane Smith\nSalary: 3000.00\nBonus: 150.00")]
        public void Employee_CalculateBonus_ShouldReturnCorrectValue(Type employeeType, string name, decimal salary, decimal expectedBonus, string expectedOutput)
        {
            // Arrange
            var employee = (Employee)Activator.CreateInstance(employeeType, name, salary);

            // Act
            var bonus = employee.CalculateBonus();

            // Assert
            Assert.AreEqual(expectedBonus, bonus, $"{employeeType.Name} CalculateBonus should return the correct bonus.");

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                employee.DisplayEmployeeDetails();
                var consoleOutputText = sw.ToString().Trim();

                // Normalize new lines and decimal separators
                var normalizedExpectedOutput = expectedOutput.Replace("\r\n", "\n").Replace("\r", "\n");
                var normalizedConsoleOutputText = consoleOutputText.Replace("\r\n", "\n").Replace("\r", "\n");

                // Ensure decimal separator is a period
                normalizedExpectedOutput = normalizedExpectedOutput.Replace(',', '.');
                normalizedConsoleOutputText = normalizedConsoleOutputText.Replace(',', '.');

                // Assert
                Assert.AreEqual(normalizedExpectedOutput, normalizedConsoleOutputText, $"{employeeType.Name} DisplayEmployeeDetails should write the correct output.");
            }
        }
    }
}
