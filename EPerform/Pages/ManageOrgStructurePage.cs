using ePerform.Library.Extent_Reports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class ManageOrgStructurePage
    {
        IWebDriver driver;

        public ManageOrgStructurePage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Details')]")]
        public IWebElement Details_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Organisational Unit List')]")]
        public IWebElement OrganisationalUnitList_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Chart')]")]
        public IWebElement Chart_Tab { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Org Unit")]
        public IWebElement AddOrgUnit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement ErrorMessage { get; set; }

        public void ManageOrgStructurePageVerification()
        {
            Assert.IsTrue(Details_Tab.Displayed, "Details Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Details Tab is displayed successfully in the Manage Organisational Structure Page");

            Assert.IsTrue(OrganisationalUnitList_Tab.Displayed, "Organisational Unit List Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Organisational Unit List Tab is displayed successfully in the Manage Organisational Structure Page");

            Assert.IsTrue(Chart_Tab.Displayed, "Chart Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Chart Tab is displayed successfully in the Manage Organisational Structure Page");

        }

        public void VerifyMandatoryFields_AddOrgUnit()
        {
            OrganisationalUnitList_Tab.Click();
            AddOrgUnit_Button.Click();

            Submit_Button.Click();

            Assert.IsTrue(ErrorMessage.Displayed, "Details Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Details Tab is displayed successfully in the Manage Organisational Structure Page");
        }







    }
}
