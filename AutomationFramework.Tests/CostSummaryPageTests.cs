using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Core.Browser;
using OpenQA.Selenium;
using AutomationFramework.Web.PageObjects.Pages;
using AutomationFramework.Core.Elements;
using AutomationFramework.Core.Browser;
using OpenQA.Selenium;


namespace AutomationFramework.Tests
{
    internal class CostSummaryPageTests : BaseTest
    {
        private CostSummaryPage costSummaryPage;

        [SetUp]
        public void Setup()
        {
            costSummaryPage = new CostSummaryPage();
            BrowserFactory.Browser.GoToUrl(costSummaryPage.Url);
        }

        [Test]
        public void NumberOfInstancesTest()
        {
            string calculatedNumber = "Number of Instances\r\n4\r\nN/A";
            string actualNumber = costSummaryPage.instanceNumber.GetText();
            Assert.That(actualNumber, Is.EqualTo(calculatedNumber));
            Assert.Pass(); // Instruction for Breakpoint
        }

        [Test]
        public void OSSoftwareTest()
        {
            string calculatedOS = "Operating System / Software\r\nFree: Debian, CentOS, CoreOS, Ubuntu or BYOL (Bring Your Own License)\r\nN/A";
            string actualOS = costSummaryPage.softElement.GetText();
            Assert.That(actualOS, Is.EqualTo(calculatedOS));
        }

        [Test]
        public void ProvisioningModelTest()
        {
            string calculatedModel = "Provisioning Model\r\nRegular\r\nN/A";
            string actualModel = costSummaryPage.provisioningElement.GetText();
            Assert.That(actualModel, Is.EqualTo(calculatedModel));
        }

        [Test]
        public void MachineTypeTest()
        {
            string calculatedType = "Instance-time\r\n2920 Hours\r\nN/A\r\nMachine type\r\nn1-standard-8, vCPUs: 8, RAM: 30 GB\r\n$769.54";
            string actualType = costSummaryPage.typeElement.GetText();
            Assert.That(actualType, Is.EqualTo(calculatedType));
        }

        [Test]
        public void GPUTypeTest()
        {
            string calculatedGPU = "Instance-time\r\n2920 Hours\r\nN/A\r\nGPU Model\r\nNVIDIA Tesla V100\r\nN/A\r\nNumber of GPUs\r\n1\r\n$4,689.52";
            string actualGPU = costSummaryPage.nvidiaElement.GetText();
            Assert.That(actualGPU, Is.EqualTo(calculatedGPU));
        }

        [Test]
        public void LocalSSDTest()
        {
            string calculatedSSD = "Local SSD\r\n2x375 GB\r\n$166.32";
            string actualSSD = costSummaryPage.localssdElement.GetText();
            Assert.That(actualSSD, Is.EqualTo(calculatedSSD));
        }

        [Test]
        public void DatacenterLocationTest()
        {
            string calculatedLocation = "Region\r\nNetherlands (europe-west4)\r\nN/A";
            string actualLocation = costSummaryPage.locationElement.GetText();
            Assert.That(actualLocation, Is.EqualTo(calculatedLocation));
        }

        [Test]
        public void CommittedUsageTest()
        {
            string calculatedUsage = "Committed use discount options\r\n1 year\r\nN/A";
            string actualUsage = costSummaryPage.commitElement.GetText();
            Assert.That(actualUsage, Is.EqualTo(calculatedUsage));
        }

    }
}
