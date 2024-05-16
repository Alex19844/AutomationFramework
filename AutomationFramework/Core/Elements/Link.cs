using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class Link : BaseElement
{
    public Link(By locator) : base(locator)
    {

    }

    public Link(IWebElement element) : base(element)
    {

    }
}