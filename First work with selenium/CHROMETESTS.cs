using NUnit.Framework;
using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObject.Actions;

namespace First_work_with_selenium
{
    public class RegistrationTests : Hooks
    {

        [Test]
        public void IsRegistrationpageOpensFromMainPage()
        {
            MainPage.ClickOnRegistButton();
            Assert.IsTrue(MainPage.IsURLCorrected());
        }
        [Test]
        public void ÑheckingTransitionFromRegistrationToAuthorization()
        {

        }
        [Test]
        public void EnteringValidValuesIntoRegistrationFieldsFirstPage()
        {

        }
        [Test]
        public void EnteringNotValidValuesIntoRegistrationFieldsFirstPage()
        {
        }

    }
}