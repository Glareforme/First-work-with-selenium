using First_work_with_selenium.Supports.Hooks;
using FirefoxTesting.Support.Locators;

namespace First_work_with_selenium.Supports.PageObjects.Actions
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
