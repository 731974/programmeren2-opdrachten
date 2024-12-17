namespace Assignment4.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        [TestCase("10\n2\nn\n", "10 / 2 = 5")]
        [TestCase("10\n0\nn\n", "Cannot divide by zero. Please try again.")]
        [TestCase("abc\n2\nn\n", "Invalid input. Please enter a valid number.")]
        public void TryDivision_VariousInputs_ExpectedOutput(string input, string expectedOutput)
        {
            // Arrange
            var program = new Program();
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.TryDivision();

            // Assert
            string output = stringWriter.ToString();
            StringAssert.Contains(expectedOutput, output);
        }

        [Test]
        public void TryDivision_RecursiveCall_ExpectedBehavior()
        {
            // Arrange
            var program = new Program();
            var input = "10\n0\ny\n10\n2\nn\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.TryDivision();

            // Assert
            string output = stringWriter.ToString();
            StringAssert.Contains("Cannot divide by zero. Please try again.", output);
            StringAssert.Contains("10 / 2 = 5", output);
        }
    }
}

