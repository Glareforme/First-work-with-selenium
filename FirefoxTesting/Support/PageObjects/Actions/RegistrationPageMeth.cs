using FirefoxTesting.Support.Hooks;
using FirefoxTesting.Support.Locators;
using NewModelTestFireFox.Support.DataForTests.Registration;

namespace FirefoxTesting.Support.Actions
{
    public static class RegistrationPageMeth
    {
        internal static bool IsRegistrationPage()
        {
            if (FFBrowser.GetDriver().FindElement(RegistrationLoc.PageTitle).Displayed)
                return true;
            return false;
        }
        public static bool IsURLCorrected() => RegistrationLoc.CorrectURL.Equals(FFBrowser.GetDriver().Url);
        public static void ClickOnUpperSingInButton() => FFBrowser.GetDriver().FindElement(RegistrationLoc.UpperSingInButton).Click();
        public static void FIrstNameInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.FirstnameField).SendKeys(NameAndLastName.GenetareName());
        public static void LastNameInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.LastnameField).SendKeys(NameAndLastName.GenetareLastName());
        public static void EmailInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.EmailField).SendKeys("");
        public static void PasswordInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PasswordField).SendKeys(PasswordAndConfirm.GeneratePassword());
      //  public static void ConfirmPasswordInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PasswordConfirmField).SendKeys(PasswordAndConfirm.GenerateConfPassword(PasswordAndConfirm.GeneratePassword()));
        public static void PhoneInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PhoneNumberField).SendKeys(PhoneNumb.GenetarePhoneNumb());
        public static void GoToNextStepRegist() => FFBrowser.GetDriver().FindElement(RegistrationLoc.NextButton).Click();
    }
}
