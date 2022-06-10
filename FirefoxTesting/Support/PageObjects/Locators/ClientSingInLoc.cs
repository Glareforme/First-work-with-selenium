using OpenQA.Selenium;

namespace FirefoxTesting.Support.Locators
{
    internal static class ClientSingInLoc
    {
        internal static readonly string CorrectURL = "https://newbookmodels.com/auth/signin";

        internal static readonly By PageTitle = By.XPath("//*[text()='Client Sign In']");
    }
}
