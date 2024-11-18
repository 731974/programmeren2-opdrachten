using NUnit.Framework;
using Assignment3;

namespace Assignment3.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var name = "John Doe";
            var age = 30;

            // Act
            var person = new Person(name, age);

            // Assert
            Assert.AreEqual(name, person.Name, "Constructor should initialize Name property.");
            Assert.AreEqual(age, person.Age, "Constructor should initialize Age property.");
        }

        [Test]
        public void NameProperty_ShouldGetAndSet()
        {
            // Arrange
            var person = new Person("John Doe", 30);
            var newName = "Jane Doe";

            // Act
            person.Name = newName;

            // Assert
            Assert.AreEqual(newName, person.Name, "Name property should get and set value.");
        }

        [Test]
        public void AgeProperty_ShouldGetAndSet()
        {
            // Arrange
            var person = new Person("John Doe", 30);
            var newAge = 25;

            // Act
            person.Age = newAge;

            // Assert
            Assert.AreEqual(newAge, person.Age, "Age property should get and set value.");
        }
    }

    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var name = "John Doe";
            var age = 30;
            var jobTitle = "Software Developer";

            // Act
            var employee = new Employee(name, age, jobTitle);

            // Assert
            Assert.AreEqual(name, employee.Name, "Constructor should initialize Name property.");
            Assert.AreEqual(age, employee.Age, "Constructor should initialize Age property.");
            Assert.AreEqual(jobTitle, employee.JobTitle, "Constructor should initialize JobTitle property.");
        }

        [Test]
        public void JobTitleProperty_ShouldGetAndSet()
        {
            // Arrange
            var employee = new Employee("John Doe", 30, "Software Developer");
            var newJobTitle = "Senior Software Developer";

            // Act
            employee.JobTitle = newJobTitle;

            // Assert
            Assert.AreEqual(newJobTitle, employee.JobTitle, "JobTitle property should get and set value.");
        }

        [Test]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var name = "John Doe";
            var age = 30;
            var jobTitle = "Software Developer";
            var employee = new Employee(name, age, jobTitle);
            var expectedOutput = $"Employee: {name}, Age: {age}, Job Title: {jobTitle}";

            // Act
            var result = employee.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "ToString should return the correct format.");
        }
    }

    [TestFixture]
    public class ManagerTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var name = "John Doe";
            var age = 40;
            var jobTitle = "Project Manager";
            var department = "IT";

            // Act
            var manager = new Manager(name, age, jobTitle, department);

            // Assert
            Assert.AreEqual(name, manager.Name, "Constructor should initialize Name property.");
            Assert.AreEqual(age, manager.Age, "Constructor should initialize Age property.");
            Assert.AreEqual(jobTitle, manager.JobTitle, "Constructor should initialize JobTitle property.");
            Assert.AreEqual(department, manager.Department, "Constructor should initialize Department property.");
        }

        [Test]
        public void DepartmentProperty_ShouldGetAndSet()
        {
            // Arrange
            var manager = new Manager("John Doe", 40, "Project Manager", "IT");
            var newDepartment = "HR";

            // Act
            manager.Department = newDepartment;

            // Assert
            Assert.AreEqual(newDepartment, manager.Department, "Department property should get and set value.");
        }

        [Test]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var name = "John Doe";
            var age = 40;
            var jobTitle = "Project Manager";
            var department = "IT";
            var manager = new Manager(name, age, jobTitle, department);
            var expectedOutput = $"Manager: {name}, Age: {age}, Job Title: {jobTitle}, Department: {department}";

            // Act
            var result = manager.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result, "ToString should return the correct format.");
        }
    }
}
