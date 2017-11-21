using NUnit.Framework;
using Selenium.Tests;

namespace Selenium
{
    [TestFixture]
    public class PostEditionTests : AuthBase
    {
        [Test]
        public void PostEditionTest()
        {
            app.Navigate.GoToPostsPage();
            app.Navigate.GoToLastPostPage();


            PostData data = new PostData("Some title", "mahsdashdhasd", "test");
            app.Post.EditPost(data.Text);
        }


    }
}
