using NUnit.Framework;
using ChromeTests.Supports.Hooks;
using ChromeTests.Supports.PageObjects.Actions;

namespace ChromeTests
{
    public class ClientSignUpTests : Hooks
    {
        [Test]
        public void IsRegistrationpageOpensFromMainPage()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
        }
    }
}