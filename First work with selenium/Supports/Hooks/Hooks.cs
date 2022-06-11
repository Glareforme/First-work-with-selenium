using NUnit.Framework;


namespace ChromeTests.Supports.Hooks
{
    public class Hooks
    {
        [SetUp]
        public void Setup()
        {
            ChromeBrowser.GetDriver().Navigate().GoToUrl("https://newbookmodels.com/");
        }
        [TearDown]
        public void TearDown()
        {
            ChromeBrowser.CleanDriver();
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            ChromeBrowser.CloseDriver();
        }
    }
}
