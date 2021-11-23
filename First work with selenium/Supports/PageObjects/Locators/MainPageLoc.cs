using OpenQA.Selenium;

namespace First_work_with_selenium.Supports.PageObject.Locators
{
    internal static class MainPageLoc
    {
        internal static readonly By _singupButton = By.XPath("//button[@class='Navbar__signUp--12ZDV']");
        internal static readonly By _singinButton = By.XPath("//a [@href='/auth/signin']");
    }
}
