using NUnit.Framework;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string MockFilename = "mock-notes.txt";
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
        public void ShowMenu_ShouldAddNote()
        {
            // Arrange
            var inputs = new StringReader("1\nTest note\n3\n");
            Console.SetIn(inputs);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.ShowMenu(MockFilename);

            // Assert
            var fileContent = File.ReadAllText(MockFilename).Trim();
            Assert.AreEqual("Test note", fileContent);
        }

        [Test]
        public void ShowMenu_ShouldViewNotes()
        {
            // Arrange
            File.WriteAllText(MockFilename, "Test note\n");
            var inputs = new StringReader("2\n3\n");
            Console.SetIn(inputs);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.ShowMenu(MockFilename);

            // Assert
            var consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("Test note"));
        }

        [Test]
        public void ShowMenu_ShouldHandleInvalidChoice()
        {
            // Arrange
            var inputs = new StringReader("4\n3\n");
            Console.SetIn(inputs);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.ShowMenu(MockFilename);

            // Assert
            var consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("Not a valid choice."));
        }

        [Test]
        public void ShowMenu_ShouldExitProgram()
        {
            // Arrange
            var inputs = new StringReader("3\n");
            Console.SetIn(inputs);
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.ShowMenu(MockFilename);

            // Assert
            var consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("Exiting program."));
        }

        [Test]
        public void AddNote_ShouldWriteNoteToFile()
        {
            // Arrange
            var inputs = new StringReader("Test note");
            Console.SetIn(inputs);

            // Act
            _program.AddNote(MockFilename);

            // Assert
            var fileContent = File.ReadAllText(MockFilename).Trim();
            Assert.AreEqual("Test note", fileContent);
        }

        [Test]
        public void ViewNotes_ShouldReadNotesFromFile()
        {
            // Arrange
            File.WriteAllText(MockFilename, "Test note\n");
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.ViewNotes(MockFilename);

            // Assert
            var consoleOutput = output.ToString();
            Assert.IsTrue(consoleOutput.Contains("Test note"));
        }
    }
}

