using OpenQA.Selenium;

namespace First_work_with_selenium.Supports.PageObjects.Locators
{
    internal static class MainPageLoc
    {
        internal static readonly By SingUpButton = By.XPath("//button[@class='Navbar__signUp--12ZDV']");
        internal static readonly By SingInButton = By.XPath("//a [@href='/auth/signin']");
        internal static readonly By BrowseTalentButton = By.XPath("//a [text()='Browse Talent'] ");
    }
}
