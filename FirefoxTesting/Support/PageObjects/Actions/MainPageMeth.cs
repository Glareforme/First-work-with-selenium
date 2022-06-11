using FirefoxTesting.Support.Locators;
using FirefoxTesting.Support.Hooks;

namespace FirefoxTesting.Support.Actions
{
    public static class MainPageMeth
    {
        public static void ClickOnRegistButton() => FFBrowser.GetDriver().FindElement(MainPageLoc.SingUpButton).Click();
        public static void ClickOnSingInButton() => FFBrowser.GetDriver().FindElement(MainPageLoc.SingInButton).Click();
        public static void ClickOnBrowseTalantButton() => FFBrowser.GetDriver().FindElement(MainPageLoc.BrowseTalentButton).Click();
    }
}
