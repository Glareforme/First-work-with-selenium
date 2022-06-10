using FirefoxTesting.Support.Locators;
using Operatesting.Support.Hooks;

namespace Operatesting.Support.PageObjects.Methods
{
    internal class SingInPageMeth
    {
        internal static bool IsClientSingInPage()
        {
            if (OperaBrowser.GetDriver().FindElement(ClientSingInLoc.PageTitle).Displayed)
                return true;
            return false;
        }
    }
}
