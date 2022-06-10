using FirefoxTesting.Support.Hooks;
using FirefoxTesting.Support.Locators;

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

        internal static bool IsURLCorrected() => RegistrationLoc.CorrectURL.Equals(FFBrowser.GetDriver().Url);
        internal static void ClickOnUpperSingInButton() => FFBrowser.GetDriver().FindElement(RegistrationLoc.UpperSingInButton).Click();
        internal static void FIrstNameInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.FirstnameField).SendKeys("");
        internal static void LastNameInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.LastnameField).SendKeys("");
        internal static void EmailInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.EmailField).SendKeys("");
        internal static void PasswordInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PasswordField).SendKeys("");
        internal static void ConfirmPasswordInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PasswordConfirmField).SendKeys("");
        internal static void PhoneInput() => FFBrowser.GetDriver().FindElement(RegistrationLoc.PhoneNumberField).SendKeys("");
        internal static void GoToNextStepRegist() => FFBrowser.GetDriver().FindElement(RegistrationLoc.NextButton).SendKeys("");
    }
}
