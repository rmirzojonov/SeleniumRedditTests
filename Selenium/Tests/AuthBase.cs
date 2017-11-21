using NUnit.Framework;

namespace Selenium.Tests
{
    public class AuthBase : TestBase
    {
        [SetUp]
        public void SetupAuthTest()
        {
            AccountData user = new AccountData("username", "password");
            app.Auth.Login(user);
        }
    }
}
