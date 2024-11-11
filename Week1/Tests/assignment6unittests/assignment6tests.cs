using NUnit.Framework;
using Assignment58;
using System;
using System.IO;

namespace Assignment58.Tests
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _userRegistration;

        [SetUp]
        public void Setup()
        {
            _userRegistration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ShouldReturnNull_WhenPasswordIsInvalid()
        {
            // Arrange
            var input = "testuser\nshort\nuser@example.com\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            var result = _userRegistration.RegisterUser();

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void RegisterUser_ShouldReturnUser_WhenPasswordIsValid()
        {
            // Arrange
            var input = "testuser\nValid1Password\nuser@example.com\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            var result = _userRegistration.RegisterUser();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testuser", result.Username);
            Assert.AreEqual("Valid1Password", result.Password);
            Assert.AreEqual("user@example.com", result.Email);
        }
    }
}
