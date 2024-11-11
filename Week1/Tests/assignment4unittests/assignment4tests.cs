using NUnit.Framework;
using Assignment4;

namespace Assignment4.Tests
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
            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(age, person.Age);
        }

        [Test]
        public void Name_ShouldGetAndSet()
        {
            // Arrange
            var person = new Person("John Doe", 30);
            var newName = "Jane Doe";

            // Act
            person.Name = newName;

            // Assert
            Assert.AreEqual(newName, person.Name);
        }

        [Test]
        public void Age_ShouldGetAndSet()
        {
            // Arrange
            var person = new Person("John Doe", 30);
            var newAge = 35;

            // Act
            person.Age = newAge;

            // Assert
            Assert.AreEqual(newAge, person.Age);
        }

        [Test]
        public void Age_ShouldNotSetNegativeValue()
        {
            // Arrange
            var person = new Person("John Doe", 30);

            // Act
            person.Age = -5;

            // Assert
            Assert.AreEqual(30, person.Age);
        }

        [Test]
        public void ToString_ShouldReturnFormattedString()
        {
            // Arrange
            var name = "John Doe";
            var age = 30;
            var person = new Person(name, age);

            // Act
            var result = person.ToString();

            // Assert
            Assert.AreEqual($"Name: {name}\nAge: {age}", result);
        }

        [Test]
        public void AgeField_ShouldBeAccessible()
        {
            // Arrange
            var person = new Person("John Doe", 30);

            // Act
            var ageField = typeof(Person).GetField("_age", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var ageValue = ageField.GetValue(person);

            // Assert
            Assert.AreEqual(30, ageValue);
        }
    }
}



