using ChromeTests.Supports.Hooks;
using FirefoxTesting.Support.Locators;

namespace ChromeTests.Supports.PageObjects.Actions
{
    internal class ClientSingInPageMeth
    {
        internal static bool IsClientSingInPage()
        {
            if (ChromeBrowser.GetDriver().FindElement(ClientSingInLoc.PageTitle).Displayed)
                return true;
            return false;
        }

    }
}
