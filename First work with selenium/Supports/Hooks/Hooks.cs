using NUnit.Framework;


namespace First_work_with_selenium.Supports.Hooks
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
