using OpenQA.Selenium;
using System.Threading;

namespace Selenium
{
    public class PostHelper : HelperBase
    {
        public PostHelper(AppManager manager) : base(manager)
        { }

        public void CreatePost(PostData data)
        {
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(data.Title);
            driver.FindElement(By.Name("text")).Click();
            driver.FindElement(By.Name("text")).Clear();
            driver.FindElement(By.Name("text")).SendKeys(data.Text);
            driver.FindElement(By.Id("sr-autocomplete")).Click();
            driver.FindElement(By.Id("sr-autocomplete")).Clear();
            driver.FindElement(By.Id("sr-autocomplete")).SendKeys(data.Area);
            driver.FindElement(By.Name("submit")).Click();
            Thread.Sleep(2000);
        }
        public void EditPost(string text)
        {
            driver.FindElement(By.ClassName("edit-usertext")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("text")).Clear();
            driver.FindElement(By.Name("text")).SendKeys(text);
            driver.FindElement(By.ClassName("save")).Click();
            Thread.Sleep(2000);
        }
    }
}
