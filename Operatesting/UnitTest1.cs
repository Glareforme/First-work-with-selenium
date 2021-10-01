using NUnit.Framework;
using OpenQA.Selenium;

namespace Operatesting
{
    public class Tests
    {
        private IWebDriver opera;
        [SetUp]
        public void Setup()
        {
            opera = new OpenQA.Selenium.Opera.OperaDriver();
            opera.Navigate().GoToUrl("https://www.google.com/");

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}