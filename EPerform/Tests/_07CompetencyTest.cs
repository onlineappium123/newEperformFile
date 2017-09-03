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
using EPerform.Library.Excel;
using System.Collections;

namespace EPerform.Tests
{
    class _07CompetencyTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        #region Competency List Tests

        [Test, Order(1)]
        [TestCase(Description = "To Verify Competency List Page Elements")]
        public void VerifyCompetencyListPageElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Competency List Page Elements");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyCompetencyListPageElements();

        }

        [Test, Order(2)]
        [TestCase(Description = "To Verify Actions Button and its functionality in Competency List Page")]
        public void VerifyActionsButton()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Actions Button and its functionality in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyActionsButton_CompetencyListPage();
        }

        [Test, Order(3)]
        [TestCase(Description = "To Verify Pagination in Competency List Page")]
        public void VerifyPagination()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Pagination in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyPagination_CompetencyListPage();
        }

        [Test, Order(4)]
        [TestCase(Description = "To Verify 'Add Competency' Popup Elements")]
        public void VerifyAddPopupElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify 'Add Competency' Popup Elements");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyAddPopupElements_CompetencyListPage();
        }

        [Test, Order(5)]
        [TestCase(Description = "To Create Active Competency")]
        public void CreateCompetency_Active()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Active Competency");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.CreateCompetency("Active", true);
        }

        [Test, Order(6)]
        [TestCase(Description = "To Create InActive Competency")]
        public void CreateCompetency_InActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create InActive Competency");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.CreateCompetency("InActive", true);
        }

        [Test, Order(7)]
        [TestCase(Description = "To Verify Mandatory Fields in Add Competency")]
        public void VerifyMandatoryFields_AddCompetency()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Competency");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyMandatoryFields_AddCompetency();
        }

        [Test, Order(8)]
        [TestCase(Description = "To Edit a Competency and make it InActive")]
        public void EditCompetency_ActiveToInActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency and make it InActive");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.EditCompetency("Active", "InActive");
        }

        [Test, Order(9)]
        [TestCase(Description = "To Edit a Competency and make it Active")]
        public void EditCompetency_InActiveToActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency and make it Active");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.EditCompetency("InActive", "Active");
        }

        [Test, Order(10)]
        [TestCase(Description = "To Create Competency of same Name")]
        public void CreateCompetency_SameName()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency of same Name");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.CreateCompetency_SameName();
        }

        [Test, Order(22)]
        [TestCase(Description = "To Make all types of Search in Competency List Page")]
        public void SearchCompetency_AllTypes()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Make all types of Search in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.SearchCompetency_AllTypes();
        }

        #endregion

        #region Competency Level List Tests


        [Test, Order(11)]
        [TestCase(Description = "To Verify Competency Level List Page Elements")]
        public void VerifyCompetencyLevelListPageElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Competency Level List Page Elements");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyCompetencyLevelListPageElements();

        }

        [Test, Order(12)]
        [TestCase(Description = "To Verify Actions Button and its functionality in Competency Level List Page")]
        public void VerifyActionsButton_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Actions Button and its functionality in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyActionsButton_CompetencyLevelListPage();
        }

        [Test, Order(13)]
        [TestCase(Description = "To Verify Pagination in Competency Level List Page")]
        public void VerifyPagination_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Pagination in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyPagination_CompetencyLevelListPage();
        }

        [Test, Order(14)]
        [TestCase(Description = "To Verify 'Add Competency' Popup Elements in Competency Level List Page")]
        public void VerifyAddPopupElements_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify 'Add Competency' Popup Elements in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyAddPopupElements_CompetencyLevelListPage();
        }

        [Test, Order(15)]
        [TestCase(Description = "To Create Active Competency Level")]
        public void CreateCompetencyLevel_Active()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Active Competency Level");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.CreateCompetencyLevel("Active", true);
        }

        [Test, Order(16)]
        [TestCase(Description = "To Create InActive Competency Level")]
        public void CreateCompetencyLevel_InActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create InActive Competency Level");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.CreateCompetencyLevel("InActive", true);
        }

        [Test, Order(17)]
        [TestCase(Description = "To Verify Mandatory Fields in Add Competency Level")]
        public void VerifyMandatoryFields_AddCompetencyLevel()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Competency Level");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyMandatoryFields_AddCompetencyLevel();
        }


        [Test, Order(18)]
        [TestCase(Description = "To Edit a Competency Level and make it InActive")]
        public void EditCompetencyLevel_ActiveToInActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency Level and make it InActive");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.EditCompetencyLevel("Active", "InActive");
        }

        [Test, Order(19)]
        [TestCase(Description = "To Edit a Competency Level and make it Active")]
        public void EditCompetencyLevel_InActiveToActive()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency Level and make it Active");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.EditCompetencyLevel("InActive", "Active");
        }

        [Test, Order(20)]
        [TestCase(Description = "To Create Competency Level of same Name")]
        public void CreateCompetencyLevel_SameName()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency Level of same Name");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.CreateCompetencyLevel_SameName();
        }

        [Test, Order(21)]
        [TestCase(Description = "To Make all types of Search in Competency Level List Page")]
        public void SearchCompetencyLevel_AllTypes()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Make all types of Search in Competency Level List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.SearchCompetencyLevel_AllTypes();
        }

        #endregion

        #region Competency Behaviour List Tests

        [Test, Order(23)]
        [TestCase(Description = "To Verify Page Elements in Competency Behaviours List Page")]
        public void VerifyBehavioursListPageElements()
        {
            CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Page Elements in Competency Behaviours List Page");
            compBehPage.VerifyBehavioursListPageElements();
        }

        [Test, Order(24)]
        [TestCase(Description = "To Create Behaviour in Competency Behaviours List Page")]
        public void CreateBehaviour()
        {
            CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Behaviour in Competency Behaviours List Page");
            compBehPage.CreateBehaviour();
        }

        [Test, Order(24)]
        [TestCase(Description = "To Create and Edit Behaviour in Competency Behaviours List Page")]
        public void EditBehaviour()
        {
            CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Behaviour in Competency Behaviours List Page");
            compBehPage.EditBehaviour();
        }

        #endregion

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
