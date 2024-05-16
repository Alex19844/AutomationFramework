using AutomationFramework.Core.Browser;
using OpenQA.Selenium;
using AutomationFramework.Web.PageObjects.Pages;

namespace AutomationFramework.Tests
{
    public class CalculatorPageTests : BaseTest
    {
        private CalculatorPage calculatorPage;

        [SetUp]
        public void Setup()
        {
            calculatorPage = new CalculatorPage();
        }

        [Test]
        public void CalculatorPageTest()
        {
            BrowserFactory.Browser.GoToUrl(calculatorPage.Url);

            BrowserFactory.Browser.ClickElement(calculatorPage.estimateElement);
            Thread.Sleep(2000);

            BrowserFactory.Browser.ClickElement(calculatorPage.computeElement);
            BrowserFactory.Browser.GoToUrl("https://cloud.google.com/products/calculator?dl=CiQ0MWE4YjA1My04OWI4LTQxZmEtYjA1ZS02OTMzMzdhZjhiMTcQCBokRkY5MDAwRTgtNDhDQi00ODRGLTk2MzgtNDA2NkIwRDExNDlB");
            
            BrowserFactory.Browser.ClickElement(calculatorPage.instancesElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.instancesElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.instancesElement);


            BrowserFactory.Browser.ClickElement(calculatorPage.osElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.osOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.modelElement);

            BrowserFactory.Browser.ClickElement(calculatorPage.familyElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.familyOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.seriesElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.seriesOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.machineElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.machineOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.gpuElement);

            BrowserFactory.Browser.GoToUrl("https://cloud.google.com/products/calculator?dl=CiRmMGYxMDg4My0zZDRhLTQ2MWEtYTc4NS1kMzBkNWUyNjQyMzYQCBokRkY5MDAwRTgtNDhDQi00ODRGLTk2MzgtNDA2NkIwRDExNDlB");
            BrowserFactory.Browser.ExecuteScript("window.scrollBy(0,500)", "");

            BrowserFactory.Browser.ClickElement(calculatorPage.gtypeElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.gtypeOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.gnumberElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.gnumberOption);

            BrowserFactory.Browser.ClickElement(calculatorPage.ssdElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.ssdOption);

            BrowserFactory.Browser.GoToUrl("https://cloud.google.com/products/calculator?dl=CiQ2MGNlM2FlOC0wOGI4LTRiYjktYjk1MC1iNDViN2ZhZWQ0ZjAQCBokRkY5MDAwRTgtNDhDQi00ODRGLTk2MzgtNDA2NkIwRDExNDlB");

            BrowserFactory.Browser.ClickElement(calculatorPage.datacenterElement);
            BrowserFactory.Browser.ClickElement(calculatorPage.datacenterOption);

            BrowserFactory.Browser.GoToUrl("https://cloud.google.com/products/calculator?dl=CiQ2YzA5YWM4OC00YTJlLTQ0N2EtOTE1Mi1hZjk0YWE0ZTUxNzcQCBokRkY5MDAwRTgtNDhDQi00ODRGLTk2MzgtNDA2NkIwRDExNDlB");

            BrowserFactory.Browser.ClickElement(calculatorPage.usageElement);

            BrowserFactory.Browser.GoToUrl("https://cloud.google.com/products/calculator?dl=CiQ5MjFkZGI5My01ZWE2LTRhYmEtYjRhMi0wNGQ4NmZmYTlmOGYQCBokRkY5MDAwRTgtNDhDQi00ODRGLTk2MzgtNDA2NkIwRDExNDlB");

            string calculatedPrice = "$5,628.90";
            string actualPrice = BrowserFactory.Browser.FindElement(By.CssSelector("label.gt0C8e.MyvX5d.D0aEmf")).Text;
            Assert.That(actualPrice, Is.EqualTo(calculatedPrice));

            // Scroll down the window
            BrowserFactory.Browser.ExecuteScript("window.scrollBy(0,500)", "");

            BrowserFactory.Browser.ClickElement(calculatorPage.shareButton);

            Thread.Sleep(2000);
            BrowserFactory.Browser.ClickElement(calculatorPage.estimateSummaryLink);

            Assert.Pass(); // Instruction for Breakpoint
        }
    }
}
