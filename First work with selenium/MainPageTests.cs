using NUnit.Framework;
using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObjects.Actions;
using System.Threading;

namespace First_work_with_selenium
{
    public class MainPageTests : Hooks
    {
        [Test]
        public void IsUpperButtonsWork()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            ChromeBrowser.GoBackOneStep();
            Thread.Sleep(500);
            MainPageMeth.ClickOnSingInButton();
            Assert.IsTrue(ClientSingInPageMeth.IsClientSingInPage());
            ChromeBrowser.GoBackOneStep();
            Thread.Sleep(500);
            MainPageMeth.ClickOnBrowseTalantButton();
        }
    }
}