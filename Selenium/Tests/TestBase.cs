using NUnit.Framework;


namespace Selenium
{
    public class TestBase
    {
        protected AppManager app;
        [SetUp]
        public void SetupTest()
        {
            app = new AppManager();

            app.Navigate.GoToLoginPage();
        }
        [TearDown]
        public void TeardownTest()
        {
            app.Auth.Logout();
            app.Stop();
        }
    }
}
