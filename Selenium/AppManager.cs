using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace Selenium
{
    public class AppManager
    {
        public IWebDriver driver;
        public StringBuilder verificationErrors;
        public string baseURL;

        private LoginHelper auth;
        private NavigationHelper navigate;
        private PostHelper post;

        public AppManager()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.reddit.com/";
            verificationErrors = new StringBuilder();

            auth = new LoginHelper(this);
            navigate = new NavigationHelper(this, baseURL);
            post = new PostHelper(this);
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }
        public LoginHelper Auth
        {
            get { return auth; }
        }
        public NavigationHelper Navigate
        {
            get { return navigate; }
        }
        public PostHelper Post
        {
            get { return post; }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
