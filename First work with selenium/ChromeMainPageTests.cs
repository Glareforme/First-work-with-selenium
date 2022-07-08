using NUnit.Framework;
using ChromeTests.Supports.Hooks;
using ChromeTests.Supports.PageObjects.Actions;


namespace ChromeTests
{
    public class ChromeMainPageTests : Hooks
    {
        [Test]
        public void CheckButtonsWork()
        {
            MainPageMeth.ClickSecongRegistButton();
            ChromeBrowser.GoBackOneStep();
            ChromeBrowser.GoForwardOneStep();
            MainPageMeth.ClickThirdRegistButton();
            ChromeBrowser.GoBackOneStep();
            ChromeBrowser.GoForwardOneStep();
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            ChromeBrowser.GoBackOneStep();
            MainPageMeth.ClickOnSingInButton();
            Assert.IsTrue(ClientSingInPageMeth.IsClientSingInPage());
            ChromeBrowser.GoBackOneStep();
            MainPageMeth.ClickOnBrowseTalantButton();
            ChromeBrowser.Colhoz();
            MainPageMeth.ClickSecongRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            ChromeBrowser.GoBackOneStep();
            MainPageMeth.ClickThirdRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
        }
        [TestCase("niyiv18448@krunsea.com")]
        public void CheckFieldForEmailWorkCorrect(string email)
        {
            MainPageMeth.InputToEmailField(email);
            MainPageMeth.ClickThirdRegistButton();
            Assert.IsTrue(MainPageMeth.IsEmailFieldIsEmpty());
        }
    }
}