using First_work_with_selenium.Supports.Hooks;
using First_work_with_selenium.Supports.PageObject.Locators;

namespace First_work_with_selenium.Supports.PageObject.Actions
{
    public static class MainPage
    {
        public static bool IsURLCorrected()
        {
           var currentURL =  ChromeBrowser.GetDriver().Url;
            if (currentURL.Equals(""))
                return true;
            return false;
        }
        public static void ClickOnRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc._singupButton).Click();
        public static void ClickOnSingInButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc._singinButton).Click();
    }
}
