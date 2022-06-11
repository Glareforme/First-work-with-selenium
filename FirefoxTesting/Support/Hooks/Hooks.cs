using NUnit.Framework;


namespace FirefoxTesting.Support.Hooks
{
    public class Hooks : FFBrowser
    {
        [SetUp]
        public void SetUp() => GetDriver().Navigate().GoToUrl("https://newbookmodels.com/");

        [TearDown]
        public void OneTimeTearDown() => CloseDriver();

        [OneTimeTearDown]
        public void TearDown() => CleanDriver();
    }
}
