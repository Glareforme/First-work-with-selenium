using NUnit.Framework;
using Operatesting.Support.Hooks;
using Operatesting.Support.PageObjects.Methods;

namespace Operatesting
{
    public class Tests : Hooks 
    {
        [Test]
        public void IsUpperButtonsWork()
        {
            MainPageMeth.ClickOnRegistButton();
            Assert.IsTrue(RegistrationPageMeth.IsRegistrationPage());
            GoBackOneStep();
            MainPageMeth.ClickOnSingInButton();
            Assert.IsTrue(SingInPageMeth.IsClientSingInPage());
            GoBackOneStep();
            MainPageMeth.ClickOnBrowseTalantButton();
        }
    }
}