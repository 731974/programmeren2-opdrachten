namespace Assignment1.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase("123", 123)]
        [TestCase("abc", 0)]
        public void AskNumber_InputVariousStrings_ReturnsExpectedResult(string input, int expected)
        {
            // Arrange
            var program = new Program();
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            int result = program.AskNumber();

            // Assert
            Assert.AreEqual(expected, result);

            // Check the output for case-insensitive comparison
            string output = stringWriter.ToString().ToLower();
            StringAssert.Contains("asknumber execution completed.", output);
        }

        [Test]
        public void AskNumber_InvalidInput_HandlesFormatException()
        {
            // Arrange
            var program = new Program();
            var stringReader = new StringReader("invalid");
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            int result = program.AskNumber();

            // Assert
            Assert.AreEqual(0, result);

            // Check the output for the specific error message
            string output = stringWriter.ToString().ToLower();
            StringAssert.Contains("invalid input. please enter a valid number.", output);
            StringAssert.Contains("asknumber execution completed.", output);
        }
    }
}
