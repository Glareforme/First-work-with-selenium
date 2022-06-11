using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace ChromeTests.Supports.Hooks
{
    public static class ChromeBrowser
    {
        private static IWebDriver _chromedriver;

        private static Actions action;
        private static void CreateDriver()
        {
            var option = new ChromeOptions();
            option.AddArguments("--start-maximized");
            _chromedriver = new ChromeDriver(option);
            _chromedriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        internal static IWebDriver GetDriver()
        {
            if (_chromedriver == null)
                CreateDriver();

            return _chromedriver;
        }

        internal static void CleanDriver()
        {
            // Open new empty tab.
            _chromedriver.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _chromedriver.WindowHandles; tabs.Count > 1; tabs = _chromedriver.WindowHandles)
            {
                _chromedriver.SwitchTo().Window(tabs[0]);
                _chromedriver.Manage().Cookies.DeleteAllCookies();
                _chromedriver.Close();
            }

            // Switch to empty tab.
            _chromedriver.SwitchTo().Window(_chromedriver.WindowHandles[0]);
        }

        internal static void CloseDriver() => _chromedriver.Quit();
        internal static void GoBackOneStep() => _chromedriver.Navigate().Back();
        internal static void GoForwardOneStep() => _chromedriver.Navigate().Forward(); 

        internal static void MoveToElement(By selector)
        {
            action = new Actions(_chromedriver);
            var element = _chromedriver.FindElement(selector);
            action.MoveToElement(element);
            action.Perform();
        } 
    }
}