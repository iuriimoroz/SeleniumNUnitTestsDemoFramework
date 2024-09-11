using OpenQA.Selenium;
using SeleniumNUnitTests.Components.Base;

namespace SeleniumNUnitTests.Components.Search
{
    public class SearchComponent : WebComponent
    {
        public SearchComponent(IWebElement rootElement) : base(rootElement) { }

        private static readonly By SearchInputCss = By.CssSelector("#query-builder-test");

        public void PerformSearch(string searchPhrase)
        {
            Click(); 
            FindElement(SearchInputCss).SendKeys(searchPhrase);
            FindElement(SearchInputCss).SendKeys(Keys.Enter); 
        }
    }
}
