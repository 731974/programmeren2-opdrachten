using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void UpdateStock_ValidAmount_UpdatesStockAndLogs()
        {
            // Arrange
            var program = new Program();
            var product = new Product("Laptop", 10, 1000);
            var input = "5\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.UpdateStock(product);

            // Assert
            Assert.AreEqual(15, product.Stock);
            string output = stringWriter.ToString().ToLower();
            StringAssert.Contains("updated stock for laptop: 15", output);
        }

        [Test]
        public void UpdateStock_InvalidAmount_ThrowsArgumentExceptionAndLogs()
        {
            // Arrange
            var program = new Program();
            var product = new Product("Laptop", 10, 1000);
            var input = "-15\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.UpdateStock(product);

            // Assert
            Assert.AreEqual(10, product.Stock);
            string output = stringWriter.ToString().ToLower();
            StringAssert.Contains("error: amount exceeds stock.", output);
            StringAssert.Contains("updated stock for laptop: 10", output);
            Assert.Contains("Error: Amount exceeds stock.", program.logs);
        }

        [Test]
        public void AddLog_ValidMessage_AddsToLogs()
        {
            // Arrange
            var program = new Program();
            string message = "Test log message";

            // Act
            program.AddLog(message);

            // Assert
            Assert.Contains(message, program.logs);
        }

        [Test]
        public void PrintAllLogs_ValidLogs_PrintsLogs()
        {
            // Arrange
            var program = new Program();
            program.logs.Add("Log 1");
            program.logs.Add("Log 2");
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.PrintAllLogs(program.logs);

            // Assert
            string output = stringWriter.ToString().ToLower();
            StringAssert.Contains("logs:", output);
            StringAssert.Contains("- log 1", output);
            StringAssert.Contains("- log 2", output);
        }
    }
}


