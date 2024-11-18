using NUnit.Framework;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class AnimalSoundTests
    {
        [TestCase("Dumbo", "Trumpet (Elephant)", typeof(Elephant))]
        [TestCase("Simba", "Roar (Lion)", typeof(Lion))]
        public void MakeSound_ShouldReturnCorrectSound(string name, string expectedSound, Type animalType)
        {
            // Act
            var animal = (Animal)Activator.CreateInstance(animalType, name);
            var sound = animal.MakeSound();

            // Assert
            Assert.AreEqual(expectedSound.ToLower(), sound.ToLower());
        }
    }

    [TestFixture]
    public class ZooTests
    {
        [Test]
        public void MakeAllAnimalsSound_ShouldPrintCorrectSounds()
        {
            // Arrange
            var animals = new Animal[]
            {
                new Lion("Simba"),
                new Elephant("Dumbo")
            };
            var zoo = new Zoo();
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            zoo.MakeAllAnimalsSound(animals);

            // Assert
            var result = sw.ToString().Trim();
            Assert.IsTrue(result.Contains("Roar (Lion)"));
            Assert.IsTrue(result.Contains("Trumpet (Elephant)"));
        }
    }
}




