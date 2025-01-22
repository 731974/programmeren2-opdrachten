using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string MockFilename = "mock-records.txt";
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

        [Test]
        public void SaveMultipleEntries_ShouldSaveEntriesToFile()
        {
            // Arrange
            var inputs = new List<string> { "Alice", "Bob", "exit" };
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(string.Join(Environment.NewLine, inputs)))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SaveMultipleEntries(MockFilename);
                }
            }

            // Assert
            var fileContent = File.ReadAllLines(MockFilename);
            Assert.AreEqual(2, fileContent.Length);
            Assert.AreEqual("alice", fileContent[0]);
            Assert.AreEqual("bob", fileContent[1]);
        }

        [Test]
        public void SaveMultipleEntries_ShouldHandleWriteException()
        {
            // Arrange
            var invalidFilename = string.Empty; // Invalid filename to trigger exception
            var inputs = new List<string> { "Alice", "Bob", "exit" };
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(string.Join(Environment.NewLine, inputs)))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SaveMultipleEntries(invalidFilename);
                }

                // Assert
                var output = sw.ToString();
                Assert.IsTrue(output.Contains("Error: Unable to save records. Please check file permissions or if the file is in use."));
            }
        }
    }
}

