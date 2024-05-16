using OpenQA.Selenium;

namespace AutomationFramework.Core.Browser;

public interface IDriverFactory
{
    public IWebDriver GetDriver();
}