using OpenQA.Selenium;

namespace Selenium
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper(AppManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }


        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl(manager.baseURL + "login");
        }
        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(baseURL + url);
        }
        public void GoToPostsPage()
        {
            driver.Navigate().GoToUrl(baseURL + "user/neverthy/submitted/");
        }
        public void GoToLastPostPage()
        {
            driver.FindElement(By.XPath("//div[contains(@class, 'entry')]//div//p//a")).Click();
        }

        public void GoToPostCreationPage()
        {
            driver.Navigate().GoToUrl(baseURL + "submit?selftext=true");
        }
    }
}
