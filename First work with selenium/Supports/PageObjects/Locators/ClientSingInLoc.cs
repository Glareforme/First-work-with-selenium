using OpenQA.Selenium;

namespace First_work_with_selenium.Supports.PageObjects.Locators
{
    internal static class ClientSingInLoc
    {
        internal static readonly string CorrectURL = "https://newbookmodels.com/auth/signin";

        internal static readonly By PageTitle = By.XPath("//*[text()='Client Sign In']");
    }
}
