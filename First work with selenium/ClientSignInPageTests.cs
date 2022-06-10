using NUnit.Framework;
using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObjects.Actions;

namespace First_work_with_selenium
{
    public class ClientSignInTests: Hooks
    {
        [Test]
        public void IsRegistrationpageOpensFromMainPage()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
        }
     /*   [Test]
        public void TransitionFromRegistrationToAuthorization()
        {
            MainPageMeth.ClickOnRegistButton();
            RegistrationPageMeth.ClickOnUpperSingInButton();
            Assert.IsTrue();
        }
        [Test]
        public void EnteringValidValuesIntoRegistrationFieldsFirstPage()
        {

        }
        [Test]
        public void EnteringNotValidValuesIntoRegistrationFieldsFirstPage()
        {
        }*/

    }
}