using OpenQA.Selenium;

namespace FirefoxTesting.Support.Locators 
{
    public static class MainPageLoc
    {
        public static readonly By SingUpButton = By.XPath("//button[@class='Navbar__signUp--12ZDV']");
        public static readonly By SingInButton = By.XPath("//a [@href='/auth/signin']");
        public static readonly By BrowseTalentButton = By.XPath("//a [text()='Browse Talent'] ");
    }
}
