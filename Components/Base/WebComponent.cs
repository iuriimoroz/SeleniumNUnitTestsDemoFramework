using OpenQA.Selenium;

namespace SeleniumNUnitTests.Components.Base
{
    public class WebComponent
    {
        private readonly IWebElement rootElement;

        protected WebComponent(IWebElement rootElement) => this.rootElement = rootElement;

        protected IWebElement FindElement(By selector) => rootElement.FindElement(selector);

        protected void Click() => rootElement.Click();

        public string Text => rootElement.Text;
    }
}