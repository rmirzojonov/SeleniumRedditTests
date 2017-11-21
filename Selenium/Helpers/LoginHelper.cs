using OpenQA.Selenium;
using System.Threading;

namespace Selenium
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager) : base(manager)
        { }
        public void Login(AccountData user)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(user))
                {
                    return;
                }
            }
            Logout();
            driver.FindElement(By.Id("user_login")).Clear();
            driver.FindElement(By.Id("user_login")).SendKeys(user.Username);
            driver.FindElement(By.Id("passwd_login")).Clear();
            driver.FindElement(By.Id("passwd_login")).SendKeys(user.Password);
            driver.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            Thread.Sleep(3000);

        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.XPath("//a[text()='logout']"));
        }
        public string GetLoggedUserName()
        {
            string text = driver.FindElement(By.XPath("//span[@class='user']//a")).Text;
            return text;
        }
        public bool IsLoggedIn(AccountData user)
        {
            return IsLoggedIn() && GetLoggedUserName() == user.Username;
        }
        public void Logout()
        {
            Thread.Sleep(2000);
            if (IsLoggedIn())
            {
                driver.FindElement(By.XPath("//a[text()='logout']")).Click();
                Thread.Sleep(2000);
            }
        }
    }
}
