using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class HtmlElement : BaseElement
{
    public HtmlElement(By locator) : base(locator)
    {

    }

    public HtmlElement(IWebElement element) : base(element)
    {

    }
}