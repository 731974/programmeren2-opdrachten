using NUnit.Framework;
using System;
using System.Collections.Generic;
using Assignment5to7;

namespace Assignment5to7.Tests
{
    [TestFixture]
    public class LibraryItemTests
    {
        [Test]
        public void GetCurrentBorrower_ShouldReturnLastBorrower()
        {
            // Arrange
            var borrower1 = new Person("John Doe", 1);
            var borrower2 = new Person("Jane Smith", 2);
            var borrowingRecord1 = new BorrowingRecord(borrower1, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10));
            var borrowingRecord2 = new BorrowingRecord(borrower2, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(15));
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345");
            book.BorrowingHistory.Add(borrowingRecord1);
            book.BorrowingHistory.Add(borrowingRecord2);

            // Act
            var currentBorrower = book.GetCurrentBorrower();

            // Assert
            Assert.That(currentBorrower, Is.EqualTo(borrower2));
        }

        [Test]
        public void GetCurrentBorrower_ShouldThrowInvalidOperationException_WhenNoBorrowingHistory()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => book.GetCurrentBorrower());
        }

        [Test]
        public void LibraryItemConstructor_ShouldInitializeEmptyBorrowingHistory()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345");

            // Act
            var borrowingHistory = book.BorrowingHistory;

            // Assert
            Assert.That(borrowingHistory, Is.Not.Null);
            Assert.That(borrowingHistory, Is.Empty);
        }
    }

    [TestFixture]
    public class BorrowingRecordTests
    {
        [Test]
        public void BorrowingRecordConstructor_ShouldInitializeProperties()
        {
            // Arrange
            var borrower = new Person("John Doe", 1);
            var borrowDate = DateTime.Now;
            var dueDate = DateTime.Now.AddDays(14);

            // Act
            var borrowingRecord = new BorrowingRecord(borrower, borrowDate, dueDate);

            // Assert
            Assert.That(borrowingRecord.Borrower, Is.EqualTo(borrower));
            Assert.That(borrowingRecord.BorrowDate, Is.EqualTo(borrowDate));
            Assert.That(borrowingRecord.DueDate, Is.EqualTo(dueDate));
        }
    }

    [TestFixture]
    public class BorrowingManagerTests
    {
        [Test]
        public void BorrowItem_ShouldAddBorrowingRecordAndSetIsBorrowedToTrue()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345");
            var person = new Person("John Doe", 1);
            var dueDate = DateTime.Now.AddDays(14);
            var borrowingManager = new BorrowingManager();

            // Act
            borrowingManager.BorrowItem(book, person, dueDate);

            // Assert
            Assert.That(book.IsBorrowed, Is.True);
            Assert.That(book.BorrowingHistory, Has.Count.EqualTo(1));
            Assert.That(book.BorrowingHistory[0].Borrower, Is.EqualTo(person));
            Assert.That(book.BorrowingHistory[0].DueDate, Is.EqualTo(dueDate));
        }

        [Test]
        public void ReturnItem_ShouldSetIsBorrowedToFalse()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345");
            var person = new Person("John Doe", 1);
            var dueDate = DateTime.Now.AddDays(14);
            var borrowingManager = new BorrowingManager();
            borrowingManager.BorrowItem(book, person, dueDate);

            // Act
            borrowingManager.ReturnItem(book);

            // Assert
            Assert.That(book.IsBorrowed, Is.False);
        }
    }

    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void BorrowLibraryItem_ShouldAddBorrowingRecordAndSetIsBorrowedToTrue()
        {
            // Arrange
            var program = new Program();
            var libraryItems = new Dictionary<string, LibraryItem>
            {
                { "12345", new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345") }
            };
            var person = new Person("John Doe", 1);
            var dueDate = DateTime.Now.AddDays(14);

            // Act
            program.BorrowLibraryItem(libraryItems, "12345", person, dueDate);

            // Assert
            var book = libraryItems["12345"];
            Assert.That(book.IsBorrowed, Is.True);
            Assert.That(book.BorrowingHistory, Has.Count.EqualTo(1));
            Assert.That(book.BorrowingHistory[0].Borrower, Is.EqualTo(person));
            Assert.That(book.BorrowingHistory[0].DueDate, Is.EqualTo(dueDate));
        }
    }
}

