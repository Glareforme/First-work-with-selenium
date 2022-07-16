using OpenQA.Selenium;

namespace FirefoxTesting.Support.Locators
{
    public static class RegistrationLoc
    {
        public static readonly string CorrectURL = "https://newbookmodels.com/join";

        public static readonly By PageTitle = By.XPath("//h1[text()='Client Signup']");
        public static readonly By UpperSingInButton = By.XPath("//a [@href='/auth/signin'] [text()='Sign In']");
        public static readonly By FirstnameField = By.XPath("//input[@name='first_name']");
        public static readonly By LastnameField = By.XPath("//input[@name='last_name']");
        public static readonly By EmailField = By.XPath("//input[@type='email']");
        public static readonly By PasswordField = By.XPath("//input[@type='password'] [@name='password']");
        public static readonly By PasswordConfirmField = By.XPath("//input[@type='password'] [@name='password_confirm']");
        public static readonly By PhoneNumberField = By.XPath("//input[@name='phone_number']");
        public static readonly By NextButton = By.XPath("//button[@type='submit'] [text()='Next']");
        public static readonly By LowerLogInButton = By.XPath("//a [@href='/auth/signin'] [text()='Log In']");
    }
    public class RegistrationSecondPageLoc
    {
        public static readonly By NameCompanyField = By.XPath("//input[@name='company_name']");
        public static readonly By CompanyUrl = By.XPath("//input[@name='company_website']");
        public static readonly By Address = By.XPath("//input[@name='location']");
        public static readonly By IndustryPopUp = By.XPath("//input[@aria-haspopup='listbox']");
        public static readonly By FinishRegistButton = By.XPath("//button[@type='submit']");
    }
}
