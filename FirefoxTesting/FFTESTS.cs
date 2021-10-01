using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace FirefoxTesting
{
    public class Tests
    {
        private readonly By _singupButton = By.XPath("//button[@class='Navbar__signUp--12ZDV']  [text()='Sign Up']");
        private readonly By _singinButton = By.XPath("//a [@href='/auth/signin']");
        private readonly By _firstnameField = By.XPath("//input[@type='text'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='first_name']");
        //private readonly By _bubs = By.CssSelector("");
        private IWebDriver driverforff;
        [SetUp]
        public void Setup()//work
        { // rabotaet 
            driverforff = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driverforff.Navigate().GoToUrl("https://newbookmodels.com/");
            //IWebElement element0 = driver.FindElement(By.Name("q"));
            //element0.SendKeys("simple Selenium tests on C#");
        }
        [Test]
        public void ÑheckingTransitionFromMainPageToRegistration()
        {
            var singup = driverforff.FindElement(_singupButton);
            singup.Click();
            Thread.Sleep(3000);
            var gotoSingIn = driverforff.FindElement(_singinButton);
            gotoSingIn.Click();
        }
        [Test]
        public void ÑheckingCheckingPossibilitiesTheFillingOfFieldsInRegistrationModule()
        {
            var singup = driverforff.FindElement(_singupButton);
            singup.Click();
            driverforff.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            // tyt ne rabotaet
            var firstname = driverforff.FindElement(_firstnameField);
            firstname.SendKeys("Vasya");
        }

        [TearDown]
        public void TearDown()
        {
            driverforff.Quit();
        }
    }
}
