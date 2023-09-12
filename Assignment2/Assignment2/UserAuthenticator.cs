using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class UserAuthenticator
    {
        public bool RegisterUser(string username, string password)
        {
            // Implement user registration logic here
            // Return true if registration is successful, false otherwise
            return true;
        }

        public bool LoginUser(string username, string password)
        {
            // Implement user login logic here
            // Return true if login is successful, false otherwise
            return true;
        }

        public bool ResetPassword(string username, string newPassword)
        {
            // Implement password reset logic here
            // Return true if password reset is successful, false otherwise
            return true;
        }
    }

    [TestFixture]
    public class UserAuthenticatorTests
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            // Create an instance of UserAuthenticator before each test
            userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void RegisterUser_ValidUsernameAndPassword_ReturnsTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "password123";

            // Act
            bool result = userAuthenticator.RegisterUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void LoginUser_ValidUsernameAndPassword_ReturnsTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "password123";

            // Act
            bool result = userAuthenticator.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ResetPassword_ValidUsernameAndNewPassword_ReturnsTrue()
        {
            // Arrange
            string username = "testuser";
            string newPassword = "newpassword123";

            // Act
            bool result = userAuthenticator.ResetPassword(username, newPassword);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
   