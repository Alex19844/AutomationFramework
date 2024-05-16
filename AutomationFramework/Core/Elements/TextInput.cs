using OpenQA.Selenium;

namespace AutomationFramework.Core.Elements;

public class TextInput : BaseElement
{
    public TextInput(By locator) : base(locator)
    {
        
    }

    public TextInput(IWebElement element) : base(element)
    {
        
    }
}