using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public class PizzahubStepDefinitions
    {
        public ChromeDriver driver;

        [Given(@"i have to navigate to pizzahub page")]
        public void GivenIHaveToNavigateToPizzahubPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:1007/");

        }

        [Then(@"click on all pizza button and add pizza to cart")]
        public void GivenClickOnAllPizzaButtonAndAddPizzaToCart()
        {
            driver.FindElement(By.LinkText("All Pizaa\'s")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("2")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("3")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();
        }

        [Then(@"click on veg pizza button and add pizza to cart")]
        public void ThenClickOnVegPizzaButtonAndAddPizzaToCart()
        {
            driver.FindElement(By.LinkText("Veg")).Click();
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
            driver.FindElement(By.LinkText("Non_Veg")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
        }

        [Then(@"click on view cart butoon to check order list")]
        public void ThenClickOnViewCartButoonToCheckOrderList()
        {
            driver.FindElement(By.LinkText("View Cart")).Click();
        }

        [Then(@"add or remove pizzas")]
        public void ThenAddOrRemovePizzas()
        {
            driver.FindElement(By.LinkText("Remove")).Click();
            driver.FindElement(By.LinkText("-")).Click();
            driver.FindElement(By.LinkText("+")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-primary")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("tr:nth-child(4) .btn-info")).Click();
        }

        [When(@"click on checkout button order should be placed")]
        public void WhenClickOnCheckoutButtonOrderShouldBePlaced()
        {
            driver.FindElement(By.LinkText("Checkout")).Click();
            driver.Close();
        }
    }
}
