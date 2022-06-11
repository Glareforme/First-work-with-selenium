using FirefoxTesting.Support.Actions;
using NUnit.Framework;
using FirefoxTesting.Support.Hooks;

namespace FirefoxTesting
{
    public class Tests : Hooks
    {
        [Test]
        public void ÑheckingTransitionFromMainPageToRegistration()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            GoBackOneStep();
            MainPageMeth.ClickOnSingInButton();
            Assert.IsTrue(ClientSingInPageMeth.IsClientSingInPage());
            GoBackOneStep();
            MainPageMeth.ClickOnBrowseTalantButton();
        }
    }
}
