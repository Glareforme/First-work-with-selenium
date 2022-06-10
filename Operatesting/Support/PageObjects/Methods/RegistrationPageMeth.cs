using FirefoxTesting.Support.Locators;
using Operatesting.Support.Hooks;

namespace Operatesting.Support.PageObjects.Methods
{
    internal class RegistrationPageMeth
    {
        internal static bool IsRegistrationPage()
        {
            if (OperaBrowser.GetDriver().FindElement(RegistrationLoc.PageTitle).Displayed)
                return true;
            return false;
        }
    }
}
