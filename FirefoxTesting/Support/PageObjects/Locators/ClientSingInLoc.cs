using OpenQA.Selenium;

namespace FirefoxTesting.Support.Locators
{
    public static class ClientSingInLoc
    {
        public static readonly string CorrectURL = "https://newbookmodels.com/auth/signin";

        public static readonly By PageTitle = By.XPath("//*[text()='Client Sign In']");
    }
}
