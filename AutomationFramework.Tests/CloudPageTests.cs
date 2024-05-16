using AutomationFramework.Core.Browser;
using AutomationFramework.Web.PageObjects.Pages;

namespace AutomationFramework.Tests
{
    public class CloudPageTests : BaseTest
    {
        private CloudPage cloudPage;
        private SearchResultPage searchResultPage;

        [SetUp]
        public void Setup()
        {
            cloudPage = new CloudPage();
            searchResultPage = new SearchResultPage();
        }

        [Test]
        public void CloudPageTest()
        {
            BrowserFactory.Browser.ClickElement(cloudPage.searchElement);
            BrowserFactory.Browser.EnterText(cloudPage.searchInput, cloudPage.keyWord);
            BrowserFactory.Browser.Submit(cloudPage.searchInput);
            BrowserFactory.Browser.GoToUrl(searchResultPage.Url);
            BrowserFactory.Browser.ClickElement(cloudPage.calculatorElement);

            Assert.Pass(); // Instruction for Breakpoint
        }
    }
}
