using System.ComponentModel;
using NUnit.Framework;


namespace AutomationFramework.Core.Enums;

public enum BrowserType
{
    [System.ComponentModel.Description("Chrome")]
    Chrome,
    [System.ComponentModel.Description("Undefined")]
    Undefined
}