using AutomationFramework.Core.Browser;
using AutomationFramework.Core.Elements;
using AutomationFramework.Core.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Core.BasePage;

public abstract class BasePage
{
    public abstract string Url { get; }
    private Button AcceptAllCookiesButton => new Button(By.Id("onetrust-accept-btn-handler"));
    
    public void AcceptAllCookies()
    {
        Waiters.WaitForCondition(()=>AcceptAllCookiesButton.IsDisplayed());
        Waiters.WaitForCondition(()=>AcceptAllCookiesButton.IsEnabled());
        Thread.Sleep(3000);
        AcceptAllCookiesButton.Click();
    }
    
    public bool IsOpened()
    {
        return BrowserFactory.Browser.GetUrl().Equals(Url);
    }

    public IWebElement FindElement(By by)
    {
        return BrowserFactory.Browser.FindElement(by);
    } 
    public IReadOnlyCollection <IWebElement> FindElements(By by)
    {
        return BrowserFactory.Browser.FindElements(by);
    }
}
