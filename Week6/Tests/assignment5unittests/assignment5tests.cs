using NUnit.Framework;
using System;
using System.IO;

namespace Assignment5.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string MockFilename = "mock-log.txt";
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
            // Ensure the mock file is clean before each test
            if (File.Exists(MockFilename))
            {
                File.Delete(MockFilename);
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

        [TestCase(typeof(FileNotFoundException), "Test file not found.")]
        [TestCase(typeof(UnauthorizedAccessException), "Access denied.")]
        [TestCase(typeof(DirectoryNotFoundException), "Directory not found.")]
        [TestCase(typeof(IOException), "General I/O error.")]
        public void LogFileErrors_ShouldLogExceptionMessageToFile(Type exceptionType, string message)
        {
            // Arrange
            var exception = (Exception)Activator.CreateInstance(exceptionType, message);
            var expectedMessage = $"Error: {message}";

            // Act
            _program.LogFileErrors(exception, MockFilename);

            // Assert
            var fileContent = File.ReadAllText(MockFilename).Trim();
            Assert.AreEqual(expectedMessage, fileContent);
        }
    }
}

