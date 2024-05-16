using AutomationFramework.Core.Enums;
using AutomationFramework.Core.Utils;
using NUnit.Framework;

namespace AutomationFramework.Core.Helper;

public class TestSettings
{
    public static TestContext TestContext { get; set; }

    //public static BrowserType Browser = BrowserType.Chrome;
    public static BrowserType Browser => EnumUtils.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());

    public static string ScreenShotPath => TestContext.Parameters.Get("ScreenShotPath").ToString();
    
    public static string LogsPath => Path.Combine(TestContext.TestDirectory, @TestContext.Parameters.Get("LogsPath").ToString());

    //public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(5.0);

    public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("WebDriverTimeOut").ToString()));

    public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();
    
    public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

    public static string DataDir => Path.Combine(Directory.GetCurrentDirectory(), TestContext.Parameters.Get("TestDataFolder").ToString());
}