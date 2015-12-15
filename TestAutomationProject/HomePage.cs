using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestAutomationProject
{
    [TestFixture]
    public class HomePage
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Set Up");
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.co.in");
        }

        [Test]
        public void GoToHomePage()
        {
            Assert.IsTrue(driver.FindElement(By.Id("hplogo")).Displayed);
        }

        [Test]
        public void SearchSelenium()
        {
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            Assert.IsTrue(driver.FindElement(By.PartialLinkText("Wikipedia")).Displayed);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing now");
            driver.Quit();
        }
        
    }
}
