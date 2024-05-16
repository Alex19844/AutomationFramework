using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class Dropdown : BaseElement
{
    public Dropdown (By locator) : base(locator)
    {
        
    }

    public Dropdown(IWebElement element) : base(element)
    {
        
    }
}