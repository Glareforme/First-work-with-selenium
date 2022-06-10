using NUnit.Framework;


namespace Operatesting.Support.Hooks
{
    public class Hooks : OperaBrowser
    {
        [SetUp]
        public void SetUp() => GetDriver().Navigate().GoToUrl("https://newbookmodels.com/");

        [TearDown]
        public void OneTimeTearDown() => CloseDriver();

        [OneTimeTearDown]
        public void TearDown() => CleanDriver();
    }
}
