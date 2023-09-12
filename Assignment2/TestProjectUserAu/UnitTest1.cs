
using Assignment2;
using NUnit.Framework;

namespace TestProjectUserAu
{


    [TestFixture]
    public class UserAuthenticatorTests
    {
        private  UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            userAuthenticator = new Assignment2.UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            // Test case 1: Valid registration
            Assert.IsTrue(userAuthenticator.RegisterUser("john", "password123"));

            // Test case 2: Invalid registration (username already exists)
            Assert.IsFalse(userAuthenticator.RegisterUser("john", "password456"));
        }

        [Test]
        public void TestUserLogin()
        {
            // Test case 1: Valid login
            Assert.IsTrue(userAuthenticator.LoginUser("john", "password123"));

            // Test case 2: Invalid login (user not found)
            Assert.IsFalse(userAuthenticator.LoginUser("jane", "password789"));

            // Test case 3: Invalid login (wrong password)
            Assert.IsFalse(userAuthenticator.LoginUser("john", "wrongpassword"));
        }

        [Test]
        public void TestPasswordReset()
        {
            // Test case 1: Valid password reset
            Assert.IsTrue(userAuthenticator.ResetPassword("john", "newpassword123"));

            // Test case 2: Invalid password reset (user not found)
            Assert.IsFalse(userAuthenticator.ResetPassword("jane", "newpassword456"));
        }
    }
}