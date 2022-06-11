using FirefoxTesting.Support.Hooks;
using FirefoxTesting.Support.Locators;

namespace FirefoxTesting.Support.Actions
{
    internal class ClientSingInPageMeth 
    {
        internal static bool IsClientSingInPage()
        {
            if (FFBrowser.GetDriver().FindElement(ClientSingInLoc.PageTitle).Displayed)
                return true;
            return false;
        }

    }
}
