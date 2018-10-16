using System;

using FluentAssertions;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using product_catalog.IntegrationTests.Helpers;

namespace product_catalog.IntegrationTests
{
    [TestFixture]
    public class IndexPage
    {
        [SetUp]
        public void Setup()
        {
            Webdriver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Webdriver.Quit();
        }

        public string BaseUrl => "http://localhost:5000/";

        public IWebDriver Webdriver { get; private set; }

        [Test]
        public void ClickingOnAproductShouldTakeYouToTheProductPage()
        {
            Webdriver.Navigate().GoToUrl(BaseUrl);
            Webdriver.WaitUntilElementVisible(By.Id("product-2"));
            Webdriver.FindElement(By.Id("product-2")).Click();
            Webdriver.WaitUntilElementVisible(By.Id("display-product-2"));
            Action findElement = () => { Webdriver.FindElement(By.Id("display-product-2")); };
            findElement.Should().NotThrow<NoSuchElementException>();
        }
    }
}