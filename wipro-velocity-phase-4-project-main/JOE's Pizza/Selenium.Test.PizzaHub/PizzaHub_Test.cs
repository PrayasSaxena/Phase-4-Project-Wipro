using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Threading;

namespace Selenium.Test.PizzaHub
{
    [TestFixture]
    public class PizzaHub_Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]

        public void Pizzahub_test()
        {
            //navigating to the url
            driver.Navigate().GoToUrl("https://localhost:1007/");

            //setting window size
            driver.Manage().Window.Maximize();

            //selecting All pizza menu from list
            driver.FindElement(By.LinkText("All Pizaa\'s")).Click();

            // Adding pizza's to the cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("2")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("3")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();

            //selecting veg pizza from list
            driver.FindElement(By.LinkText("Veg")).Click();
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();

            //selecting non-veg pizza from list
            driver.FindElement(By.LinkText("Non_Veg")).Click();
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();

            //clicking on view cart 
            driver.FindElement(By.LinkText("View Cart")).Click();

            // Adding and removing pizza from order list
            driver.FindElement(By.LinkText("Remove")).Click();
            driver.FindElement(By.LinkText("-")).Click();
            driver.FindElement(By.LinkText("+")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-primary")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(4) .btn-info")).Click();

            // clicking on checkout button
            driver.FindElement(By.LinkText("Checkout")).Click();

            //closing the browser
            driver.Close();
        }
    }
}
