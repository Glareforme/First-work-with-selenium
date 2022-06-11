using First_work_with_selenium.Supports.Hooks;
using FirefoxTesting.Support.Locators;
using System;
namespace First_work_with_selenium.Supports.PageObjects.Actions
{
    public static class MainPageMeth
    {
        public static void ClickOnRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingUpButton).Click();
        public static void ClickOnSingInButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingInButton).Click();
        public static void ClickOnBrowseTalantButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.BrowseTalentButton).Click();
        public static void ClickSecongRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SecondSingUpButton).Click();
        public static void ClickThirdRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.ThirdSingUpButton).Click();
        public static void TryClickSecongRegistButton()
        {
            try
            {
                ClickSecongRegistButton();
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                ChromeBrowser.MoveToElement(MainPageLoc.SecondSingUpButton);
                ClickSecongRegistButton();
            }
        }
    }
}
