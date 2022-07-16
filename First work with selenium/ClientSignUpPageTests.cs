using NUnit.Framework;
using ChromeTests.Supports.Hooks;
using ChromeTests.Supports.PageObjects.Actions;

namespace ChromeTests
{
    public class ClientSignUpTests : Hooks
    {
        [Test]
        public void TryRegistrationWithCorrectData()
        {
            MainPageMeth.ClickOnRegistButton();
            RegistrationPageMeth.FIrstNameInput();
            RegistrationPageMeth.LastNameInput();
            RegistrationPageMeth.EmailInput();
            RegistrationPageMeth.PasswordAndConfPassInput();
            RegistrationPageMeth.PhoneInput();
            RegistrationPageMeth.GoToNextStepRegist();
        }
        [Test]
        public void TryRegistrationWithIncorrectDataOnFirstPAge() 
        {

        }
        [Test]
        public void AllButtonsOnPageWork()
        {

        }
    }
}