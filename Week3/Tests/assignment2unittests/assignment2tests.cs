using NUnit.Framework;
using Assignment2;

namespace Assignment2.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void PartTimeEmployee_GetSalary_WhenCalled_ReturnsCorrectSalary()
        {
            // Arrange
            decimal hourlyWage = 20.5m;
            int hoursWorked = 40;
            var employee = new PartTimeEmployee(hourlyWage, hoursWorked);

            // Act
            var salary = employee.GetSalary();

            // Assert
            Assert.AreEqual(hourlyWage * hoursWorked, salary);
        }

        [Test]
        public void PartTimeEmployee_Constructor_WhenCalled_SetsHourlyWageAndHoursWorked()
        {
            // Arrange
            decimal hourlyWage = 15.75m;
            int hoursWorked = 30;

            // Act
            var employee = new PartTimeEmployee(hourlyWage, hoursWorked);

            // Assert
            Assert.AreEqual(hourlyWage * hoursWorked, employee.GetSalary());
        }

        [Test]
        public void FullTimeEmployee_GetSalary_WhenCalled_ReturnsCorrectSalary()
        {
            // Arrange
            decimal salary = 50000m;
            var employee = new FullTimeEmployee(salary);

            // Act
            var result = employee.GetSalary();

            // Assert
            Assert.AreEqual(salary, result);
        }

        [Test]
        public void FullTimeEmployee_Constructor_WhenCalled_SetsSalary()
        {
            // Arrange
            decimal salary = 60000m;

            // Act
            var employee = new FullTimeEmployee(salary);

            // Assert
            Assert.AreEqual(salary, employee.GetSalary());
        }
    }
}

