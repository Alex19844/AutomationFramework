using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class BasePanel : BaseElement
{
    public BasePanel (By locator) : base(locator)
    {
        
    }

    public BasePanel (IWebElement element) : base(element)
    {
        
    }
}