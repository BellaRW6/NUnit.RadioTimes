using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NuGet.Resources;
using NUnit.Framework;
using NUnit.Mocks;
using PNUnit.Framework;
using OpenQA.Selenium;
using System.Drawing;
using Selenium.Internal;
using OpenQA.Selenium.Firefox;
using System.IO;
using Selenium;
namespace MadeForMoms
{
    [TestFixture]
    public class PageNavigation
    {
        private IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.madeformums.com/");

        }

        [Test]
        public void Madeformum()
        {

            driver.FindElement(By.XPath("//*[@id='navitem4v1']/a/span")).Click();
            driver.FindElement(By.XPath("//*[@id='maincontentcell']/div[2]/h2/a")).Click();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='podsRight']/div[5]/div"));
            IWebElement element1 = element.FindElement(By.XPath("//*[@id='podsRight']/div[5]/div/div[2]/ul/li[1]"));
            element1.FindElement(By.XPath("//*[@id='podsRight']/div[5]/div/div[2]/ul/li[1]/a")).Click();

            IWebElement element2=  driver.FindElement(By.XPath("//*[@id='historybar']/div/span"));

            string actualPageTitle = element2.Text;
            string expectedPageTitle = "Baby";
            
            Assert.IsTrue(expectedPageTitle.Equals(actualPageTitle));
        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
            driver.Dispose();
            
        }

    }
}