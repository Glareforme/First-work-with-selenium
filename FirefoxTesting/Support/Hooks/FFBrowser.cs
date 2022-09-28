using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace FirefoxTesting.Support.Hooks
{
    public class FFBrowser 
    {
        private static IWebDriver _driverforff;
        internal static void CreateDriver()
        {
            var option = new FirefoxOptions();
            option.AddArgument("--start-maximized");
            _driverforff = new FirefoxDriver(option);
            _driverforff.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        internal static IWebDriver GetDriver()
        {
            if (_driverforff == null)
                CreateDriver();

            return _driverforff;
        }
        internal static void CleanDriver()
        {
            // Open new empty tab.
            _driverforff.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _driverforff.WindowHandles; tabs.Count > 1; tabs = _driverforff.WindowHandles)
            {
                _driverforff.SwitchTo().Window(tabs[0]);
                _driverforff.Manage().Cookies.DeleteAllCookies();
                _driverforff.Close();
            }
            // Switch to empty tab.
            _driverforff.SwitchTo().Window(_driverforff.WindowHandles[0]);
        }

        internal static void CloseDriver() => _driverforff.Quit();
        internal static void GoBackOneStep() => _driverforff.Navigate().Back();
    }
}
