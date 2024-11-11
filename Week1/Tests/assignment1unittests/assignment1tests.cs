using NUnit.Framework;
using Assignment1;

namespace Assignment1.Tests
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
    }
}


