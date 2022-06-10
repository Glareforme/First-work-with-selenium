using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObjects.Locators;

namespace First_work_with_selenium.Supports.PageObjects.Actions
{
    public static class MainPageMeth
    {
        public static void ClickOnRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingUpButton).Click();
        public static void ClickOnSingInButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingInButton).Click();
        public static void ClickOnBrowseTalantButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.BrowseTalentButton).Click();
    }
}
