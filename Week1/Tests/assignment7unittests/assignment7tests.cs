using NUnit.Framework;
using Assignment58;
using System;
using System.IO;

namespace Assignment58.Tests
{
    [TestFixture]
    public class UserManagementServiceTests
    {
        private UserManagementService _userManagementService;

        [SetUp]
        public void Setup()
        {
            _userManagementService = new UserManagementService();
        }

        [Test]
        public void AddUser_ShouldAddUser_WhenPasswordIsValid()
        {
            // Arrange
            var input = "testuser\nValid1Password\nuser@example.com\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            _userManagementService.AddUser();

            // Assert
            var usersField = typeof(UserManagementService).GetField("users", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var users = (User[])usersField.GetValue(_userManagementService);
            Assert.IsNotNull(users[0]);
            Assert.AreEqual("testuser", users[0].Username);
            Assert.AreEqual("Valid1Password", users[0].Password);
            Assert.AreEqual("user@example.com", users[0].Email);
        }

        [Test]
        public void AddUser_ShouldNotAddUser_WhenPasswordIsInvalid()
        {
            // Arrange
            var input = "testuser\nshort\nuser@example.com\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            _userManagementService.AddUser();

            // Assert
            var usersField = typeof(UserManagementService).GetField("users", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var users = (User[])usersField.GetValue(_userManagementService);
            Assert.IsNull(users[0]);
        }
    }
}

