using ePerform.Library.Extent_Reports;
using EPerform.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Tests
{
    class _08OrganisationalStructuresTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        [Test,Order(1)]
        public void ManageOrgStructurePageVerification()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Page Elements in Manage Organisational Structure Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformOrganisationStructureOption.Click();
            ManageOrgStructurePage manageOrgStrPage = new ManageOrgStructurePage(_driver);
            manageOrgStrPage.ManageOrgStructurePageVerification();
        }

        [Test, Order(2)]
        public void VerifyMandatoryFields_AddOrgUnit()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Organisational Unit of Manage Organisational Structure Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformOrganisationStructureOption.Click();
            ManageOrgStructurePage manageOrgStrPage = new ManageOrgStructurePage(_driver);
            manageOrgStrPage.VerifyMandatoryFields_AddOrgUnit();
        }


        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                string screenShotPath = ExtentReport.Capture(_driver);
                ExtentReport.test.Log(LogStatus.Fail, stackTrace + errorMessage);
                ExtentReport.test.Log(LogStatus.Fail, "Please find the Screenshot below: " + ExtentReport.test.AddScreenCapture(screenShotPath));
            }
            ExtentReport.extent.EndTest(ExtentReport.test);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
            ExtentReport.extent.Flush();
            ExtentReport.extent.Close();
        }

    }
}
