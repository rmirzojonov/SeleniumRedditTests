using NUnit.Framework;
using Selenium.Tests;

namespace Selenium
{
    [TestFixture]
    public class PostCreationTests : AuthBase
    {
        [Test]
        public void PostCreationTest()
        {
            app.Navigate.GoToPostCreationPage();

            PostData data = new PostData("Some title", "mahsdashdhasd", "test");
            app.Post.CreatePost(data);
        }
    }
}
