using FirefoxTesting.Support.Locators;
using Operatesting.Support.Hooks;

namespace Operatesting.Support.PageObjects.Methods
{
    internal static class MainPageMeth 
    {
        public static void ClickOnRegistButton() => OperaBrowser.GetDriver().FindElement(MainPageLoc.SingUpButton).Click();
        public static void ClickOnSingInButton() => OperaBrowser.GetDriver().FindElement(MainPageLoc.SingInButton).Click();
        public static void ClickOnBrowseTalantButton() => OperaBrowser.GetDriver().FindElement(MainPageLoc.BrowseTalentButton).Click();
    }
}
