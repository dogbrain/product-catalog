using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_catalog.IntegrationTests.Helpers
{
    public static class PageWaiter
    {
        public static IWebElement WaitUntilElementVisible(this IWebDriver driver,By elementLocator, int timeout = 5000)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
                return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }
    }
}
