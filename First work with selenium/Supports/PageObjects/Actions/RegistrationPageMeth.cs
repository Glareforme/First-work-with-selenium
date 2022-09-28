using ChromeTests.Supports.Hooks;
using FirefoxTesting.Support.Locators;
using NewModelTestFireFox.Support.DataForTests.Registration;

namespace ChromeTests.Supports.PageObjects.Actions
{
    public static class RegistrationPageMeth
    {
        internal static bool IsRegistrationPage()
        {
            if (ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PageTitle).Displayed)
                return true;
            return false;
        }

        internal static bool IsURLCorrected() => RegistrationLoc.CorrectURL.Equals(ChromeBrowser.GetDriver().Url);
        internal static void ClickOnUpperSingInButton() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.UpperSingInButton).Click();
        internal static void FIrstNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.FirstnameField).SendKeys(NameAndLastName.GenetareName());
        internal static void LastNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.LastnameField).SendKeys(NameAndLastName.GenetareLastName());
        internal static void EmailInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.EmailField).SendKeys(Email.GenerateMail());
        internal static void PasswordAndConfPassInput() 
        {
            string password = PasswordAndConfirm.GeneratePassword();
            ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordField).SendKeys(password);
            ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordConfirmField).SendKeys(password);
        }
        internal static void PhoneInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PhoneNumberField).SendKeys(PhoneNumb.GenetarePhoneNumb());
        internal static void GoToNextStepRegist() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.NextButton).Click();
    }
    public static class RegistrationSecondPageMeth
    {
        internal static void CompanyNameAndUrlInput()
        {
            string companyName = CompanyAndUrl.GenerateCompanyName();//method
            ChromeBrowser.GetDriver().FindElement(RegistrationSecondPageLoc.NameCompanyField).SendKeys(companyName);
            ChromeBrowser.GetDriver().FindElement(RegistrationSecondPageLoc.CompanyUrl).SendKeys(CompanyAndUrl.GenerateUrl(companyName));
        }
        internal static void AddressInput()
        {
            ChromeBrowser.GetDriver().FindElement(RegistrationSecondPageLoc.Address).SendKeys("23700 West Bluff Road, Channahon, IL, USA");
        }
        internal static void IndustrySelectInPopup()
        {

        }
        internal static void FinishRegistrationButton() => ChromeBrowser.GetDriver().FindElement(RegistrationSecondPageLoc.FinishRegistButton).Click();
    }
}
