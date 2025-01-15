using NUnit.Framework;
using System;
using System.IO;

namespace Assignment2.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string MockFilename = "mock-safe_data.txt";
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
        public void SafeFileReadWrite_ShouldWriteInputToFile()
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
                    _program.SafeFileReadWrite(MockFilename);
                }
            }

            // Assert
            var fileContent = File.ReadAllText(MockFilename).Trim();
            Assert.AreEqual(input, fileContent);
        }

        [Test]
        public void SafeFileReadWrite_ShouldHandleWriteException()
        {
            // Arrange
            var invalidFilename = string.Empty; // Invalid filename to trigger exception
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader("Test input"))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SafeFileReadWrite(invalidFilename);
                }

                // Assert
                var output = sw.ToString();
                Assert.IsTrue(output.Contains("Error: Unable to write to file."));
            }
        }

        [Test]
        public void SafeFileReadWrite_ShouldHandleReadException()
        {
            // Arrange
            var invalidFilename = string.Empty; // Invalid filename to trigger exception
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader("Test input"))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SafeFileReadWrite(invalidFilename);
                }

                // Assert
                var output = sw.ToString();
                Assert.IsTrue(output.Contains("Error: Unable to read from file."));
            }
        }
    }
}
