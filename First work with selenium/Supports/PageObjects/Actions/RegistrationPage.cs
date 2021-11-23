using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObject.Locators;

namespace First_work_with_selenium.Supports.PageObject.Actions
{
    class RegistrationPage
    {
        internal void ClickOnUpperSingInButton() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.UpperSingInButton).Click();
        internal void FIrstNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.FirstnameField).SendKeys("");
        internal void LastNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.LastnameField).SendKeys("");
        internal void EmailInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.EmailField).SendKeys("");
        internal void PasswordInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordField).SendKeys("");
        internal void ConfirmPasswordInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordConfirmField).SendKeys("");
        internal void PhoneInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PhoneNumberField).SendKeys("");


    }
}
