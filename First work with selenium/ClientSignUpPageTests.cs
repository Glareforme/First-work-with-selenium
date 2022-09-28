using NUnit.Framework;
using ChromeTests.Supports.Hooks;
using ChromeTests.Supports.PageObjects.Actions;
using System.Threading;

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
            Thread.Sleep(1000);
            RegistrationPageMeth.GoToNextStepRegist();
            Thread.Sleep(1000);
            RegistrationSecondPageMeth.CompanyNameAndUrlInput();
            RegistrationSecondPageMeth.AddressInput();
            RegistrationSecondPageMeth.IndustrySelectInPopup();
            RegistrationSecondPageMeth.FinishRegistrationButton();
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