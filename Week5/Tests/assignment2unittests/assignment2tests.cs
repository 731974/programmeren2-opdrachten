namespace Assignment2.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase(18)]
        [TestCase(25)]
        public void ValidateAge_ValidAge_DoesNotThrowException(int age)
        {
            // Arrange
            var program = new Program();

            // Act & Assert
            Assert.DoesNotThrow(() => program.ValidateAge(age));
        }

        [Test]
        [TestCase(17)]
        [TestCase(10)]
        public void ValidateAge_InvalidAge_ThrowsArgumentException(int age)
        {
            // Arrange
            var program = new Program();

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => program.ValidateAge(age));
            Assert.That(ex.Message, Is.EqualTo("Error: Age must be 18 or older to proceed. "));
        }
    }
}
