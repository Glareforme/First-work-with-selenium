using OpenQA.Selenium;


namespace First_work_with_selenium.Supports.PageObject.Locators
{
    internal static class RegistrationLoc
    {
        internal static readonly By UpperSingInButton = By.XPath("//a [@href='/auth/signin'] [text()='Sign In']");
        internal static readonly By FirstnameField = By.XPath("//input[@name='first_name']");
        internal static readonly By LastnameField = By.XPath("//input[@name='last_name']");
        internal static readonly By EmailField = By.XPath("//input[@type='email']");
        internal static readonly By PasswordField = By.XPath("//input[@type='password'] [@name='password']");
        internal static readonly By PasswordConfirmField = By.XPath("//input[@type='password'] [@name='password_confirm']");
        internal static readonly By PhoneNumberField = By.XPath("//input[@name='code']");
        internal static readonly By NextButton = By.XPath("//button [@type='subm it'] [text()='Next']");
        internal static readonly By LowerLogInButton = By.XPath("//a [@href='/auth/signin'] [text()='Log In']");
    }
    internal class RegistrationSecongPageLoc
    {
        internal readonly By _nameCompanyField = By.XPath("//input[@name='company_name']");
    }
}
