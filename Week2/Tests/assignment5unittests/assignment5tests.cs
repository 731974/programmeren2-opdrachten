using NUnit.Framework;
using System.IO;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class AnimalTests
    {
        [TestCase("Simba", "Lion", typeof(Lion))]
        [TestCase("Dumbo", "Elephant", typeof(Elephant))]
        public void Constructor_ShouldInitializeNameAndSpecies(string name, string expectedSpecies, Type animalType)
        {
            // Act
            var animal = (Animal)Activator.CreateInstance(animalType, name);

            // Assert
            Assert.AreEqual(name, animal.Name);
            Assert.AreEqual(expectedSpecies, animal.Species);
        }

        [TestCase("Simba", "Roar", typeof(Lion))]
        [TestCase("Dumbo", "Trumpet", typeof(Elephant))]
        public void MakeSound_ShouldReturnCorrectSound(string name, string expectedSound, Type animalType)
        {
            // Act
            var animal = (Animal)Activator.CreateInstance(animalType, name);
            var sound = animal.MakeSound();

            // Assert
            Assert.IsTrue(sound.Contains(expectedSound));
        }

        [TestCase("Simba", "Animal Name: Simba, Species: Lion", typeof(Lion))]
        [TestCase("Dumbo", "Animal Name: Dumbo, Species: Elephant", typeof(Elephant))]
        public void ToString_ShouldReturnCorrectFormat(string name, string expectedString, Type animalType)
        {
            // Act
            var animal = (Animal)Activator.CreateInstance(animalType, name);
            var result = animal.ToString();

            // Assert
            Assert.AreEqual(expectedString, result);
        }
    }

    [TestFixture]
    public class ZooTests
    {
        [TestCase("Simba", "Animal Name: Simba, Species: Lion", typeof(Lion))]
        [TestCase("Dumbo", "Animal Name: Dumbo, Species: Elephant", typeof(Elephant))]
        public void DisplayAnimalDetails_ShouldPrintCorrectDetails(string name, string expectedOutput, Type animalType)
        {
            // Arrange
            var animal = (Animal)Activator.CreateInstance(animalType, name);
            var zoo = new Zoo();
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            zoo.DisplayAnimalDetails(animal);

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
