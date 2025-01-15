using NUnit.Framework;
using System;
using System.IO;

namespace Assignment4.Tests
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
            // Create a mock file with some initial content
            using (StreamWriter sw = new StreamWriter(MockFilename))
            {
                sw.WriteLine("Alice");
                sw.WriteLine("Bob");
                sw.WriteLine("Charlie");
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
        public void SearchInFile_ShouldFindName()
        {
            // Arrange
            var input = "Bob";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(input))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SearchInFile(MockFilename);
                }

                // Assert
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("Name found."));
            }
        }

        [Test]
        public void SearchInFile_ShouldNotFindName()
        {
            // Arrange
            var input = "David";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(input))
                {
                    Console.SetIn(sr);

                    // Act
                    _program.SearchInFile(MockFilename);
                }

                // Assert
                var output = sw.ToString().Trim();
                Assert.IsTrue(output.Contains("Name not found."));
            }
        }
    }
}

