using NUnit.Framework;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class AnimalFeedTests
    {
        [TestCase("Simba", "meat", typeof(Lion))]
        [TestCase("Dumbo", "vegetables", typeof(Elephant))]
        public void Feed_ShouldReturnCorrectFood(string name, string expectedFood, Type animalType)
        {
            // Act
            var animal = (Animal)Activator.CreateInstance(animalType, name);
            var food = animal.Feed();

            // Assert
            Assert.IsTrue(food.Contains(expectedFood));
        }
    }

    [TestFixture]
    public class ZooKeeperTests
    {
        [Test]
        public void FeedAnimals_ShouldPrintCorrectFoodForEachAnimal()
        {
            // Arrange
            var animals = new Animal[]
            {
                new Lion("Simba"),
                new Elephant("Dumbo")
            };
            var zooKeeper = new ZooKeeper();
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            zooKeeper.FeedAnimals(animals);

            // Assert
            var result = sw.ToString().Trim();
            Assert.IsTrue(result.Contains("meat"));
            Assert.IsTrue(result.Contains("vegetables"));
        }
    }
}



