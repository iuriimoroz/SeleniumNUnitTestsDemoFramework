using OpenQA.Selenium;
using SeleniumNUnitTests.Components.Base;
using SeleniumNUnitTests.Entities;

namespace SeleniumNUnitTests.Components.Search
{
    public class SearchResultItemComponent : WebComponent
    {
        public SearchResultItemComponent(IWebElement rootElement) : base(rootElement) { }

        private static readonly By TitleSelector = By.CssSelector(".search-title");
        private static readonly By DescriptionSelector =
            By.XPath(".//h3/following-sibling::*/*[contains(@class, 'search-match')]");

        public SearchResultItem ConvertToSearchResultItem() =>
    new SearchResultItem(
        RetrieveTitleText(),
        RetrieveDescriptionText()
    );

        private string RetrieveTitleText() =>
            FindElement(TitleSelector).Text.ToLower();

        private string RetrieveDescriptionText() =>
            FindElement(DescriptionSelector).Text.ToLower();
    }
}

