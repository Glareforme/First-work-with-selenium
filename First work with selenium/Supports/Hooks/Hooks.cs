using NUnit.Framework;


namespace First_work_with_selenium.Supports.Hooks
{
    class Hooks
    {
        [SetUp]
        public void Setup()
        {
            driverforchrome = new OpenQA.Selenium.Chrome.ChromeDriver();
            driverforchrome.Navigate().GoToUrl("https://newbookmodels.com/");
            //IWebElement element0 = driver.FindElement(By.Name("q"));
            //element0.SendKeys("simple Selenium tests on C#");
        }
    }
}
