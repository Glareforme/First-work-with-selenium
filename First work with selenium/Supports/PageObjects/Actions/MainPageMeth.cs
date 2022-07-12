using ChromeTests.Supports.Hooks;
using FirefoxTesting.Support.Locators;

namespace ChromeTests.Supports.PageObjects.Actions
{
    public static class MainPageMeth
    {
        public static void ClickOnRegistButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingUpButton).Click();
        public static void ClickOnSingInButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.SingInButton).Click();
        public static void ClickOnBrowseTalantButton() => ChromeBrowser.GetDriver().FindElement(MainPageLoc.BrowseTalentButton).Click();
        public static void InputToEmailField(string email)
        {
            ChromeBrowser.GetDriver().FindElement(MainPageLoc.EmailInputField).SendKeys(email);
        }
        public static void SubmitToSendEmail() 
        {
            ChromeBrowser.MoveToElement(MainPageLoc.SubmitSendEmail);
            ChromeBrowser.GetDriver().FindElement(MainPageLoc.SubmitSendEmail).Click(); 
        } 
        public static void ClickSecongRegistButton() 
        {
            ChromeBrowser.MoveToElement(MainPageLoc.SecondSingUpButton);
            ChromeBrowser.GetDriver().FindElement(MainPageLoc.SecondSingUpButton).Click();

        }
        public static void ClickThirdRegistButton()
        {
            ChromeBrowser.MoveToElement(MainPageLoc.ThirdSingUpButton);
            ChromeBrowser.GetDriver().FindElement(MainPageLoc.ThirdSingUpButton).Click();
        }
        public static bool IsEmailFieldIsEmpty()
        {
            if (ChromeBrowser.GetDriver().FindElement(MainPageLoc.SubmitSendEmail).Enabled)
                return true; 
            return false;
        }
    }
}
