using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.BasePage;
using OpenQA.Selenium;
using System.Security.Policy;

namespace AutomationFramework.Web.PageObjects.Pages
{
    public class CalculatorPage : BasePage
    {
        public override string Url => "https://cloud.google.com/products/calculator";

        public By estimateElement = By.CssSelector("span.UywwFc-vQzf8d[jsname='V67aGc']");

        public By computeElement = By.CssSelector("div.aHij0b-WsjYwc.b9Ejl");

        public By instancesElement = By.CssSelector("button[aria-label='Increment']");
        //public By instancesElement = (By.CssSelector("div[jsaction='JIbuQc:qGgAE']"));

        public By osElement = By.XPath("//*[text() = 'Operating System / Software']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By osOption = By.CssSelector("li[data-value='free-debian-centos-coreos-ubuntu-or-byol-bring-your-own-license']");

        public By modelElement = By.CssSelector("label.zT2df");

        public By familyElement = By.XPath("//*[text() = 'Machine Family']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By familyOption = By.CssSelector("li[data-value='general-purpose']");

        public By seriesElement = By.XPath("//*[text() = 'Series']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By seriesOption = By.CssSelector("li[data-value='n1']");

        public By machineElement = By.XPath("//*[text() = 'Machine type']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By machineOption = By.CssSelector("li[data-value='n1-standard-8']");

        public By gpuElement = By.CssSelector("button[type='button'][role='switch'][aria-label='Add GPUs']");

        public By gtypeElement = By.XPath("//*[text() = 'GPU Model']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By gtypeOption = By.CssSelector("li[data-value='nvidia-tesla-v100']");

        public By gnumberElement = By.XPath("//*[text() = 'Number of GPUs']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By gnumberOption = By.XPath($"//li[@data-value='1' and descendant::span[text()='1']]");

        public By ssdElement = By.XPath("//*[text() = 'Local SSD']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By ssdOption = By.XPath($"//li[@data-value='2' and descendant::span[text()='2x375 GB']]");

        public By datacenterElement = By.XPath("//*[text() = 'Region']//ancestor::div[@class = 'VfPpkd-TkwUic']");
        public By datacenterOption = By.CssSelector("li[data-value='europe-west4']");

        public By usageElement = By.CssSelector("label.zT2df[for='1-year']");

        public By priceElement = By.CssSelector("label.gt0C8e.MyvX5d.D0aEmf");

        public By shareButton = By.CssSelector("span.FOBRw-vQzf8d[jsname='V67aGc']");

        public By estimateSummaryLink = By.LinkText("Open estimate summary");

    }
}
