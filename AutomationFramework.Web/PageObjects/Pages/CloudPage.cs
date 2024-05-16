using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.BasePage;
using AutomationFramework.Core.Browser;
using OpenQA.Selenium;

namespace AutomationFramework.Web.PageObjects.Pages;

    public class CloudPage : BasePage
    {
        public string keyWord = "Google Cloud Platform Pricing Calculator";
        public override string Url => "https://cloud.google.com";

        public By searchElement = (By.CssSelector("div.YSM5S[jsname='Ohx1pb']"));

        public By searchInput = (By.Id("i4"));

        public By calculatorElement = (By.CssSelector("a.K5hUy"));
    }

