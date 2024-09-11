using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumNUnitTests.Pages
{
    public class WebPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        protected WebPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        protected IWebElement FindElement(By selector) => driver.FindElement(selector);

        protected IList<IWebElement> FindElements(By selector) => driver.FindElements(selector);

        protected void WaitForElement(By selector, int timeoutInSeconds = 15)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds))
                .Until(driver => driver.FindElement(selector));
        }

    }
}
