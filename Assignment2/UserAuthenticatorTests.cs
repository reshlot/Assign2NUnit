using System;

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
    public void TestUserRegistration()
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
    public void TestUserLogin()
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
    public void TestPasswordReset()
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