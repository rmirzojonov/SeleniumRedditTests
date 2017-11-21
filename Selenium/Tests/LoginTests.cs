using NUnit.Framework;

namespace Selenium.Tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidDataTest()
        {
            AccountData user = new AccountData("correctUsername", "correctPassword");
            app.Auth.Logout();

            app.Auth.Login(user);
            Assert.IsTrue(app.Auth.IsLoggedIn(user));

        }

        [Test]
        public void LoginWithInvalidDataTest()
        {
            AccountData user = new AccountData("wrongUsername", "wrongUsername");
            app.Auth.Logout();

            app.Auth.Login(user);
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}
