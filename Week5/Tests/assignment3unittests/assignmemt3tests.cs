namespace Assignment3.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase(4, 16)]
        [TestCase(9, 81)]
        [TestCase(0, 0)]
        public void CalculateSquareRoot_ValidNumber_ReturnsExpectedResult(double input, double expected)
        {
            // Arrange
            var program = new Program();

            // Act
            double result = program.CalculateSquareRoot(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        public void CalculateSquareRoot_NegativeNumber_ThrowsNegativeValueException(double input)
        {
            // Arrange
            var program = new Program();

            // Act & Assert
            var ex = Assert.Throws<NegativeValueException>(() => program.CalculateSquareRoot(input));
            Assert.That(ex.Message, Is.EqualTo("Error: Negative values are not allowed."));
        }
    }
}
