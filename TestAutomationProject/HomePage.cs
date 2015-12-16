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

        [Test]
        public void GoogleAbout()
        {
            IWebElement aboutLink = driver.FindElement(By.LinkText("About"));
            IWebElement business = driver.FindElement(By.LinkText("Business"));
            Assert.IsTrue(aboutLink.Displayed);
            Assert.IsTrue(business.Displayed);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing now");
            driver.Quit();
        }
        
    }
}
