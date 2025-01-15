using NUnit.Framework;
using System;
using System.IO;

namespace Assignment1.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string MockFilename = "mock-user-input.txt";
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
            // Create a mock file with some initial content
            using (StreamWriter sw = new StreamWriter(MockFilename))
            {
                sw.WriteLine("Initial content");
            }
        }

        [TearDown]
        public void Teardown()
        {
            // Delete the mock file after each test
            if (File.Exists(MockFilename))
            {
                File.Delete(MockFilename);
            }
        }

        [Test]
        public void WriteToFile_ShouldWriteInputToFile()
        {
            // Arrange
            var input = "Test input";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(input))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.WriteToFile(MockFilename);
                }
            }

            // Assert
            var fileContent = File.ReadAllText(MockFilename).Trim();
            Assert.AreEqual(input, fileContent);
        }

        [Test]
        public void ReadFromFile_ShouldReadContentFromFile()
        {
            // Arrange
            var expectedContent = "Initial content";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _program.ReadFromFile(MockFilename);

                // Assert
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains(expectedContent));
            }
        }
    }
}
