using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class Label : BaseElement
{
    public Label(By locator) : base(locator)
    {
        
    }

    public Label(WebElement element) : base(element)
    {
        
    }
}