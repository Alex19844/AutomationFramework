using AutomationFramework.Core.Browser;
using AutomationFramework.Core.Helper;
using AutomationFramework.Core.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using Logger = AutomationFramework.Core.Utils.Logger;

namespace AutomationFramework.Tests;

public abstract class BaseTest
{
    public TestContext TestContext { get; set; }
    public Actions action { get; set; }

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Logger.InitLogger(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.TestDirectory);
    }

    [SetUp]
    public virtual void BeforeTest()
    {
        Logger.Info("Test has begun");
        BrowserFactory.Browser.Maximize();
        BrowserFactory.Browser.GoToUrl("https://cloud.google.com");
        //BrowserFactory.Browser.GoToUrl(TestSettings.ApplicationUrl);
        Waiters.WaitForPageLoad();
        action = new Actions(BrowserFactory.Browser.Driver);
    }

    [TearDown]
    public virtual void CleanTest()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Logger.Info("Test has failed");
            BrowserFactory.Browser.SaveScreenShot(TestContext.CurrentContext.Test.MethodName, 
                Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
        }
        Logger.Info("Test has finished");
        BrowserFactory.Browser.Quit();
    }
}