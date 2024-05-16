using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.BasePage;
using AutomationFramework.Core.Browser;
using OpenQA.Selenium;
using AutomationFramework.Core.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.BasePage;
using AutomationFramework.Core.Browser;
using OpenQA.Selenium;
using System.Security.Policy;



namespace AutomationFramework.Web.PageObjects.Pages
{
    public class CostSummaryPage : BasePage
    {
        public override string Url => "https://cloud.google.com/products/calculator/estimate-preview/4b9dbb92-19ae-4e7f-b516-23be626a17da";

        public Label instanceNumber => new Label(By.XPath("//*[text()='4']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public static string os = "Free: Debian, CentOS, CoreOS, Ubuntu or BYOL (Bring Your Own License)";
        public Label softElement => new Label(By.XPath($"//*[text()='{os}']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public Label provisioningElement => new Label(By.XPath($"//*[text()='Regular']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public static string type = "n1-standard-8, vCPUs: 8, RAM: 30 GB";
        public Label typeElement => new Label(By.XPath($"//*[text()='{type}']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public Label nvidiaElement => new Label(By.XPath($"//*[text()='NVIDIA Tesla V100']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public Label localssdElement => new Label(By.XPath($"//*[text()='2x375 GB']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        public Label locationElement => new Label(By.XPath($"//*[text()='Netherlands (europe-west4)']//ancestor::div[@class = 'EQCBxd g5Ano']"));

        //public By commitElement = (By.XPath($"//*[text()='1 year']//ancestor::div[@class = 'EQCBxd g5Ano']"));
        public Label commitElement => new Label(By.XPath($"//*[text()='1 year']//ancestor::div[@class = 'EQCBxd g5Ano']"));

    }
}
