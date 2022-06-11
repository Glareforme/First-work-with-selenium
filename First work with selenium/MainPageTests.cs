using NUnit.Framework;
using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObjects.Actions;
using System.Threading;

namespace First_work_with_selenium
{
    public class MainPageTests : Hooks
    {
        [Test]
        public void CheckButtonsWork()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            ChromeBrowser.GoBackOneStep();
            MainPageMeth.ClickOnSingInButton();
            Assert.IsTrue(ClientSingInPageMeth.IsClientSingInPage());
            ChromeBrowser.GoBackOneStep();
            MainPageMeth.ClickOnBrowseTalantButton();
            ChromeBrowser.GoBackOneStep();
        }
        [Test]
        public void CheckFieldForEmailWorkCorrect()
        {
        }
        [Test]
        public void CheckButtonForScrollPage()
        {

        }
    }
}