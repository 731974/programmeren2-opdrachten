using NUnit.Framework;
using Assignment2;
using System.Reflection;

namespace Assignment2.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var title = "The Great Gatsby";
            var author = "F. Scott Fitzgerald";

            // Act
            var book = new Book(title, author);

            // Assert
            Assert.AreEqual($"Title: {title} \nAuthor: {author}", book.ToString());
        }

        [Test]
        public void ToString_ShouldReturnFormattedString()
        {
            // Arrange
            var title = "1984";
            var author = "George Orwell";
            var book = new Book(title, author);

            // Act
            var result = book.ToString();

            // Assert
            Assert.AreEqual($"Title: {title} \nAuthor: {author}", result);
        }

        [Test]
        public void Title_ShouldBeAccessible()
        {
            // Arrange
            var title = "The Catcher in the Rye";
            var author = "J.D. Salinger";
            var book = new Book(title, author);

            // Act
            var titleField = typeof(Book).GetField("title", BindingFlags.NonPublic | BindingFlags.Instance);
            var titleValue = titleField.GetValue(book);

            // Assert
            Assert.AreEqual(title, titleValue);
        }

        [Test]
        public void Author_ShouldBeAccessible()
        {
            // Arrange
            var title = "To Kill a Mockingbird";
            var author = "Harper Lee";
            var book = new Book(title, author);

            // Act
            var authorField = typeof(Book).GetField("author", BindingFlags.NonPublic | BindingFlags.Instance);
            var authorValue = authorField.GetValue(book);

            // Assert
            Assert.AreEqual(author, authorValue);
        }
    }
}


