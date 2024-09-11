using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using SeleniumNUnitTests.Components.Search;
using SeleniumNUnitTests.Entities;

namespace SeleniumNUnitTests.Pages
{
    public class SearchResultsPage : WebPage
    {
        private IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        private static readonly By SearchResultItemSelector = By.CssSelector("[data-testid='results-list'] > div");

        private IList<SearchResultItemComponent> SearchResultsItems => FindElements(SearchResultItemSelector)
            .Select(element => new SearchResultItemComponent(element))
            .ToList();

        public IList<SearchResultItem> SearchResultItems()
        {
            WaitForElement(SearchResultItemSelector);
            return SearchResultsItems
                .Select(item => item.ConvertToSearchResultItem())
                .ToList();
        }
    }
    }