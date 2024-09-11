using OpenQA.Selenium;
using SeleniumNUnitTests.Components.Search;

namespace SeleniumNUnitTests.Pages
{
    public class HomePage : WebPage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private static readonly By SearchInputCss = By.CssSelector(".search-input");
        public SearchComponent SearchComponent => new SearchComponent(FindElement(SearchInputCss));
    }
}
