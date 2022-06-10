using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace Operatesting.Support.Hooks
{
    public class OperaBrowser
    {
        private static IWebDriver _operaWebDriver;
        
        internal static void CreateDriver()
        {
            var options = new OperaOptions();
            options.AddArgument("--start-maximized");
            _operaWebDriver = new OperaDriver(options);
            _operaWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);    
        }
        internal static IWebDriver GetDriver()
        {
            if (_operaWebDriver == null)
                CreateDriver();

            return _operaWebDriver;
        }
        internal static void CleanDriver()
        {
            // Open new empty tab.
            _operaWebDriver.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _operaWebDriver.WindowHandles; tabs.Count > 1; tabs = _operaWebDriver.WindowHandles)
            {
                _operaWebDriver.SwitchTo().Window(tabs[0]);
                _operaWebDriver.Manage().Cookies.DeleteAllCookies();
                _operaWebDriver.Close();
            }
            // Switch to empty tab.
            _operaWebDriver.SwitchTo().Window(_operaWebDriver.WindowHandles[0]);
        }

        internal static void CloseDriver() => _operaWebDriver.Quit();
        internal static void GoBackOneStep() => _operaWebDriver.Navigate().Back();

    }
}
