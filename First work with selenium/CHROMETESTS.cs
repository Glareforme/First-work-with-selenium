using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace First_work_with_selenium
{
    public class RegistrationTests
    {
        private IWebDriver driverforchrome;
        private readonly By _singupButton = By.XPath("//button[@class='Navbar__signUp--12ZDV']  [text()='Sign Up']");
        private readonly By _singinButton = By.XPath("//a [@href='/auth/signin']");
        private readonly By _firstnameField = By.XPath("//input[@type='text'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='first_name']");
        private readonly By _lastnameField = By.XPath("//input[@type='text'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='last_name']");
        private readonly By _emailField = By.XPath("//input[@type='email'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp']");
        private readonly By _passwordField = By.XPath("//input[@type='password'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='password']");
        private readonly By _passwordconfirmField = By.XPath("//input[@type='password'] [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='password_confirm']");
        private readonly By _phonenumberField = By.XPath("//input [@class='Input__input--_88SI Input__themeNewbook--1IRjd Input__fontRegular--2SStp'] [@name='phone_number']");
        private readonly By _nextButton = By.XPath("//button [@class='SignupForm__submitButton--1m1C2 Button__button---rQSB Button__themePrimary--E5ESP Button__sizeMedium--uLCYD Button__fontSmall--1EPi5 Button__withTranslate--1qGAH']");
        private readonly By _nameCompanyField = By.XPath("//input[@type='text'] [@name='company_name']");

        //private readonly By _bubs = By.CssSelector(""); nauchtsya 

        [SetUp]
        public void Setup()
        {
            driverforchrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            driverforchrome.Navigate().GoToUrl("https://newbookmodels.com/");
            //IWebElement element0 = driver.FindElement(By.Name("q"));
            //element0.SendKeys("simple Selenium tests on C#");
        }
        [Test]
        public void ÑheckingTransitionFromMainPageToRegistration()
        {
            var singup = driverforchrome.FindElement(_singupButton);
            singup.Click();
        }
        [Test]
        public void ÑheckingTransitionFromRegistrationToAuthorization()
        {
            var singup = driverforchrome.FindElement(_singupButton);
            singup.Click();
            var gotoSingIn = driverforchrome.FindElement(_singinButton);
            gotoSingIn.Click();
        }
        [Test]
        public void EnteringValidValuesIntoRegistrationFieldsFirstPage() //work 
        {
            driverforchrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var singup = driverforchrome.FindElement(_singupButton);
            singup.Click();
            var clicknext = driverforchrome.FindElement(_nextButton);
            clicknext.Click();
        }
        [Test]
        public void EnteringNotValidValuesIntoRegistrationFieldsFirstPage() 
        {
            driverforchrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var singup = driverforchrome.FindElement(_singupButton);
            singup.Click();
            var firstname = driverforchrome.FindElement(_firstnameField);
            firstname.SendKeys("");
            var lastname = driverforchrome.FindElement(_lastnameField);
            lastname.SendKeys("");
            var email = driverforchrome.FindElement(_emailField);
            email.SendKeys("");
            var password = driverforchrome.FindElement(_passwordField);
            password.SendKeys("");
            var passwordconfirm = driverforchrome.FindElement(_passwordconfirmField);
            passwordconfirm.SendKeys("");
            var phonenumber = driverforchrome.FindElement(_phonenumberField);
            phonenumber.SendKeys("");
            var clicknext = driverforchrome.FindElement(_nextButton);
            clicknext.Click();
        }
        [TearDown]
        public void TearDown()
        {
            //driverforchrome.Quit();
        }
    }
}