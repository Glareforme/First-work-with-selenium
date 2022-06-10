using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace FirefoxTesting.Support.Hooks
{
    public class FFBrowser
    {
        private static IWebDriver driverforff;
        internal static void CreateDriver()
        {
            var option = new FirefoxOptions();
            option.AddArgument("--start-maximized");
            driverforff = new FirefoxDriver(option);
            driverforff.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        internal static IWebDriver GetDriver()
        {
            if (driverforff == null)
                CreateDriver();

            return driverforff;
        }
        internal static void CleanDriver()
        {
            // Open new empty tab.
            driverforff.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = driverforff.WindowHandles; tabs.Count > 1; tabs = driverforff.WindowHandles)
            {
                driverforff.SwitchTo().Window(tabs[0]);
                driverforff.Manage().Cookies.DeleteAllCookies();
                driverforff.Close();
            }
            // Switch to empty tab.
            driverforff.SwitchTo().Window(driverforff.WindowHandles[0]);
        }

        internal static void CloseDriver() => driverforff.Quit();
        internal static void GoBackOneStep() => driverforff.Navigate().Back();

    }
}
