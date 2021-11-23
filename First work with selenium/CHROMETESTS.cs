using First_work_with_selenium.Supports.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace First_work_with_selenium
{
    public class RegistrationTests : Hooks
    {
        private IWebDriver driverforchrome;

        //private readonly By _bubs = By.CssSelector(""); nauchtsya 

        [Test]
        public void ÑheckingTransitionFromMainPageToRegistration()
        {
           
        }
        [Test]
        public void ÑheckingTransitionFromRegistrationToAuthorization()
        {
         
        }
        [Test]
        public void EnteringValidValuesIntoRegistrationFieldsFirstPage() //work 
        {
       
        }
        [Test]
        public void EnteringNotValidValuesIntoRegistrationFieldsFirstPage() 
        {
        }

    }
}