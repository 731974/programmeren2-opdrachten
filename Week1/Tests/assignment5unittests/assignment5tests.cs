using NUnit.Framework;
using Assignment58;

namespace Assignment58.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var username = "testuser";
            var password = "Valid1Password";
            var email = "testuser@example.com";

            // Act
            var user = new User(username, password, email);

            // Assert
            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual(email, user.Email);
        }

        [Test]
        public void Username_ShouldGetAndSet()
        {
            // Arrange
            var user = new User("testuser", "Valid1Password", "testuser@example.com");
            var newUsername = "newuser";

            // Act
            user.Username = newUsername;

            // Assert
            Assert.AreEqual(newUsername, user.Username);
        }

        [Test]
        public void Password_ShouldGetAndSet_WhenValid()
        {
            // Arrange
            var user = new User("testuser", "Valid1Password", "testuser@example.com");
            var newPassword = "NewValid1Password";

            // Act
            user.Password = newPassword;

            // Assert
            Assert.AreEqual(newPassword, user.Password);
        }

        [Test]
        public void Password_ShouldNotChange_WhenInvalid()
        {
            // Arrange
            var user = new User("testuser", "Valid1Password", "testuser@example.com");
            var invalidPassword = "short";

            // Act
            user.Password = invalidPassword;

            // Assert
            Assert.AreEqual("Valid1Password", user.Password);
        }

        [Test]
        public void Email_ShouldGetAndSet()
        {
            // Arrange
            var user = new User("testuser", "Valid1Password", "testuser@example.com");
            var newEmail = "newuser@example.com";

            // Act
            user.Email = newEmail;

            // Assert
            Assert.AreEqual(newEmail, user.Email);
        }
    }

    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [Test]
        public void IsValid_ShouldReturnFalse_WhenPasswordIsTooShort()
        {
            // Arrange
            var password = "Short1";

            // Act
            var result = _validator.isValid(password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_ShouldReturnFalse_WhenPasswordHasNoUpperCaseLetter()
        {
            // Arrange
            var password = "lowercase1";

            // Act
            var result = _validator.isValid(password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_ShouldReturnFalse_WhenPasswordHasNoDigit()
        {
            // Arrange
            var password = "NoDigits";

            // Act
            var result = _validator.isValid(password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_ShouldReturnTrue_WhenPasswordIsValid()
        {
            // Arrange
            var password = "Valid1Password";

            // Act
            var result = _validator.isValid(password);

            // Assert
            Assert.IsTrue(result);
        }
    }
}

