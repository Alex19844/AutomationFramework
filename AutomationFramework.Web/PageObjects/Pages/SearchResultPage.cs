using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.BasePage;
using AutomationFramework.Core.Browser;
using AutomationFramework.Web.PageObjects.Pages;


namespace AutomationFramework.Web.PageObjects.Pages;

public class SearchResultPage : BasePage
{
    public override string Url => "https://cloud.google.com/search?q=Google%20Cloud%20Platform%20Pricing%20Calculator";
}

