using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;

using EPerform.Pages;
using ePerfrom.Library;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Tests
{
    
    public class _02HomeTest
    {

        static IWebDriver _driver;



        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }
        /// <summary>
        /// @Description:To verify the Reviews page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "to verify the Reviews page is displayed or not")]
       
        public void verifyHomeReviewsPage()
        {

            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Home Review page verification");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            Assert.IsTrue(homepage.EperformWelcomeText.Displayed, "Welcome Text is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Welcome Text is displayed in the home page");
            Assert.IsTrue(homepage.EperformReviewsOption.Displayed, "Reviews option is not displayed in the home page");
            
            ExtentReport.test.Log(LogStatus.Pass, "Reviews option is displayed in the home page");
            homepage.EperformReviewsArrowOption.Click();
            Assert.IsTrue(homepage.EperformReviewsIcon.Displayed, "Reviews icon is not displayed");
          
            ExtentReport.test.Log(LogStatus.Pass, "Reviews icon is displayed");
            homepage.EperformReviewsIcon.Click();
            homepage.pageverify(data["HomeReviewsPage"].ToString());
            homepage.EperformReviewsArrowOption.Click();
            Assert.IsTrue(homepage.EperformReviewTemplatesIcon.Displayed, "ReviewsTemplates icon is not displayed");
        
            ExtentReport.test.Log(LogStatus.Pass, "ReviewsTemplates icon is displayed");
            homepage.EperformReviewTemplatesIcon.Click();
            DataRow data1 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            homepage.pageverify( data1["HomeReviewsPage"].ToString());
            homepage.EperformReviewsArrowOption.Click();
            Assert.IsTrue(homepage.EperformWorkFlowsIcon.Displayed, "Workflows icon is not displayed");
       
            ExtentReport.test.Log(LogStatus.Pass, "Workflows icon is displayed");
            homepage.EperformWorkFlowsIcon.Click();
            DataRow data2 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            homepage.pageverify(data2["HomeReviewsPage"].ToString());
            homepage.EperformReviewsArrowOption.Click();
            Assert.IsTrue(homepage.EperformWorkflowRolesIcon.Displayed, "Workflows roles icon is not displayed");
        
            ExtentReport.test.Log(LogStatus.Pass, "Workflows roles icon is displayed");
            homepage.EperformWorkflowRolesIcon.Click();
            DataRow data3 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];
            homepage.pageverify( data3["HomeReviewsPage"].ToString());
            homepage.EperformReviewsArrowOption.Click();
            Assert.IsTrue(homepage.EperformRoleTypes.Displayed, "Eperform Role Type icon is not displayed");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Role Type icon is displayed");
            homepage.EperformRoleTypes.Click();
            DataRow data4 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            homepage.pageverify(data4["HomeReviewsPage"].ToString());
        }
        /// <summary>
        /// @Description:To verify the Organisation Structure page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "to verify the Organisation Structure page is displayed or not")]
       
        public void verifyHomeOrganisationStructurepage()
        {
            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Home  Organisation Structure  page verification");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
         
            Assert.IsTrue(homepage.EperformOrganisationStructureIcon.Displayed, "Orgranisation Structure Icon is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Orgranisation Structure Icon is displayed in the home page");
            
            homepage.EperformOrganisationStructureArrowOption.Click();
            Assert.IsTrue(homepage.EperformOrganisationStructureOption.Displayed, "Orgranisation Structure option is not displayed in the home page");
         
            ExtentReport.test.Log(LogStatus.Pass, "Orgranisation Structure option is displayed in the home page");
            homepage.EperformOrganisationStructureOption.Click();
            homepage.pageverify(data["HomeOrganisationStructurepage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            homepage.EperformOrganisationStructureArrowOption.Click();
            Assert.IsTrue(homepage.EperformPositionsOption.Displayed, "Postions option is not displayed in the home page");
        
            ExtentReport.test.Log(LogStatus.Pass, "Postions option is displayed in the home page");
            homepage.EperformPositionsOption.Click();
            homepage.pageverify(data1["HomeOrganisationStructurepage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            homepage.EperformOrganisationStructureArrowOption.Click();
            Assert.IsTrue(homepage.EperformMarkersOption.Displayed, "Markers option is not displayed in the home page");
            
            ExtentReport.test.Log(LogStatus.Pass, "Markers option is displayed in the home page");
            homepage.EperformMarkersOption.Click();
            homepage.pageverify(data2["HomeOrganisationStructurepage"].ToString());

        }
        /// <summary>
        /// @Description:To verify the Competency Framework page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "to verify the Competency Framework page is displayed or not")]
      
        public void verifyHomeCompetencyFrameworkPage()
        {
            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Home Competency Framework  page verification");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
          
            Assert.IsTrue(homepage.EperformCompetencyFrameworkIcon.Displayed, "Competency Framework Icon is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Competency Framework Icon is displayed in the home page");
            
            homepage.EperformCompetencyFrameworkArrowIcon.Click();
            Assert.IsTrue(homepage.EperformCompetenciesOption.Displayed, "Cometencies option is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Cometencies option is displayed in the home page");
            homepage.EperformCompetenciesOption.Click();
            homepage.pageverify(data["HomeCompetencyFrameworkPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            homepage.EperformCompetencyFrameworkArrowIcon.Click();
            Assert.IsTrue(homepage.EperformCompetencyLevelsOption.Displayed, "Eperform CompetencyLevels is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform CompetencyLevels is displayed in the home page");
            homepage.EperformCompetencyLevelsOption.Click();
            homepage.pageverify(data1["HomeCompetencyFrameworkPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            homepage.EperformCompetencyFrameworkArrowIcon.Click();
            Assert.IsTrue(homepage.EperformCompetencyBehavioursOption.Displayed, "Eperform CompetencyBehaviours Option is not displayed in the home page");
            
            ExtentReport.test.Log(LogStatus.Pass, "Eperform CompetencyBehaviours Option is displayed in the home page");
            homepage.EperformCompetencyBehavioursOption.Click();
            homepage.pageverify(data2["HomeCompetencyFrameworkPage"].ToString());
        }
        /// <summary>
        /// @Description:To verify the Reference Material page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(4)]
        [TestCase(Description = "to verify the Reference Material page is displayed or not")]
      
        public void verifyHomeReferenceMaterialPage()
        {
            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Home Reference Material  page verification");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
          
            Assert.IsTrue(homepage.EperformReferenceMaterialIcon.Displayed, "Eperform ReferenceMaterial Icon is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Eperform ReferenceMaterial Icon is displayed in the home page");
            
            homepage.EperformReferenceMaterialArrowIcon.Click();
            Assert.IsTrue(homepage.EperformGoalsOption.Displayed, "Eperform Goals Option is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Goals Option is displayed in the home page");
            homepage.EperformGoalsOption.Click();
            homepage.pageverify(data["HomeReferenceMaterialPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            homepage.EperformReferenceMaterialArrowIcon.Click();
            Assert.IsTrue(homepage.EperformMeasuresOption.Displayed, "Eperform Measures Option is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Measures Option is displayed in the home page");
            homepage.EperformMeasuresOption.Click();
            homepage.pageverify(data1["HomeReferenceMaterialPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            homepage.EperformReferenceMaterialArrowIcon.Click();
            Assert.IsTrue(homepage.EperformPillarsOption.Displayed, "Eperform Pillars Option is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Pillars Option is displayed in the home page");
            homepage.EperformPillarsOption.Click();
            homepage.pageverify(data2["HomeReferenceMaterialPage"].ToString());
            DataRow data3 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];
            homepage.EperformReferenceMaterialArrowIcon.Click();
            Assert.IsTrue(homepage.EperformDevelopmentActivitiesOption.Displayed, "Eperform DevelopmentActivities Option is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform DevelopmentActivities Option is displayed in the home page");
            homepage.EperformDevelopmentActivitiesOption.Click();
            homepage.pageverify(data3["HomeReferenceMaterialPage"].ToString());
            DataRow data4 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            homepage.EperformReferenceMaterialArrowIcon.Click();
            Assert.IsTrue(homepage.EperformDocumentsOption.Displayed, "Eperform Documents Option is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Documents Option is displayed in the home page");
            homepage.EperformDocumentsOption.Click();
            homepage.pageverify(data4["HomeReferenceMaterialPage"].ToString());


        }
        /// <summary>
        /// @Description:To verify the System Configuration page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(5)]
        [TestCase(Description = "to verify the System Configuration page is displayed or not")]
      
        public void verifyHomeSystemConfigurationPage()
        {
            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Home SystemConfiguration  page verification");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
          
            Assert.IsTrue(homepage.EperformSystemConfigurationIcon.Displayed, "Eperform SystemConfiguration Icon  is not displayed in the home page");
            
            ExtentReport.test.Log(LogStatus.Pass, "Eperform SystemConfiguration Icon  is displayed in the home page");
            
            homepage.EperformSystemConfigurationArrowIcon.Click();

            Assert.IsTrue(homepage.EperformUsersOption.Displayed, "Eperform Users Option  is not displayed in the home page");
          
            ExtentReport.test.Log(LogStatus.Pass, "Eperform Users Option is displayed in the home page");
            homepage.EperformUsersOption.Click();
            homepage.pageverify(data["HomeSystemConfigurationPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            Assert.IsTrue(homepage.EperformPermissionProfilesOption.Displayed, "Eperform PermissionProfiles Option  is not displayed in the home page");
           
            ExtentReport.test.Log(LogStatus.Pass, "Eperform PermissionProfiles Option is displayed in the home page");
            homepage.EperformPermissionProfilesOption.Click();
            homepage.pageverify(data1["HomeSystemConfigurationPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformMessagesOption, "Eperform Messages Option  is not displayed in the home page", "Eperform Messages Option is displayed in the home page");
            homepage.EperformMessagesOption.Click();
            homepage.pageverify(data2["HomeSystemConfigurationPage"].ToString());
            DataRow data4 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformEmailTemplatesOption, "Eperform Email Templates Option  is not displayed in the home page", "Eperform Email Templates Option is displayed in the home page");
            homepage.EperformEmailTemplatesOption.Click();
            homepage.pageverify(data4["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformEmailQueueOption, "Eperform Email Queue Option is not displayed in the home page", "Eperform Email Queue Option is displayed in the home page");
            homepage.EperformEmailQueueOption.Click();
            DataRow data5 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            homepage.pageverify(data5["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformEmailNotificationsOption, "Eperform EmailNotifications Option is not displayed in the home page", "Eperform EmailNotifications Option is displayed in the home page");
            homepage.EperformEmailNotificationsOption.Click();
            DataRow data6 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_06").Rows[0];
            homepage.pageverify(data6["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformGlobalQuestionsOption, "Eperform GlobalQuestions Option is not displayed in the home page", "Eperform GlobalQuestions Option is displayed in the home page");
            homepage.EperformGlobalQuestionsOption.Click();
            DataRow data7 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_07").Rows[0];
            homepage.pageverify(data7["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformFormTemplatesOption, "Eperform FormTemplates Option is not displayed in the home page", "Eperform FormTemplates Option is displayed in the home page");
            homepage.EperformFormTemplatesOption.Click();
            DataRow data8 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_08").Rows[0];
            homepage.pageverify(data8["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformSystemFormsOption, "Eperform SystemForms Option is not displayed in the home page", "Eperform SystemForms Option is displayed in the home page");
            homepage.EperformSystemFormsOption.Click();
            DataRow data9 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_09").Rows[0];
            homepage.pageverify(data9["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformCaptionsOption, "Eperform Captions Option is not displayed in the home page", "Eperform Captions Option is displayed in the home page");
            homepage.EperformCaptionsOption.Click();
            DataRow data10 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_10").Rows[0];
            homepage.pageverify(data10["HomeSystemConfigurationPage"].ToString());
            homepage.EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformBulkImportandExportOption, "Eperform BulkImportandExport Option is not displayed in the home page", "Eperform BulkImportandExport Option is displayed in the home page");
            homepage.EperformBulkImportandExportOption.Click();
            DataRow data11 = ExcelData.GetData_DataTable("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_0").Rows[0];
            homepage.pageverify(data11["HomeSystemConfigurationPage"].ToString());


        }
        /// <summary>
        /// @Description:To verify the System Administrator page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(6)]
        [TestCase(Description = "to verify the System Administrator page is displayed or not")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Priority(6)]
        public void verifySystemAdministratorpage()
        {
            HomePage homepage = new HomePage(_driver);
            LoginPage loginpage = new LoginPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("verifySystemAdministratorpage");

            BaseMethods.webelementverify(homepage.EperformSystemAdministratorIcon);
            loginpage.EperformSystemAdministratorArrowDropDownIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformEmployeePortalOption, "Eperform EmployeePortal Option is not displayed in the home page", "Eperform EmployeePortal Option is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformTalentAcquisitionOption, "Eperform TalentAcquisition Option is not displayed in the home page", "Eperform TalentAcquisition Option is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformChangePasswordOption, "Eperform ChangePassword Option is not displayed in the home page", "Eperform ChangePassword Option is displayed in the home page");
          

        }
        /// <summary>
        /// @Description:To verify the Reference Material page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>

        [Test, Order(7)]
        [TestCase(Description = "to verify the Reference Material page is displayed or not")]
       
        public void verifyHelppage()
        {
            HomePage homepage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("verifyHelppage");
            BaseMethods.verifyWebElement(homepage.EperformHelpIcon, "Eperform Help Icon  is not displayed in the home page", "Eperform Help Icon is displayed in the home page");
            homepage.EperformHelpArrowIcon.Click();
            BaseMethods.verifyWebElement(homepage.EperformToggleCationNamesText, "Eperform ToggleCation Names Text  is not displayed in the home page", "Eperform ToggleCation Names Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformAutomatedTestingText, "Eperform AutomatedTesting Text  is not displayed in the home page", "Eperform AutomatedTesting Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformBuildText, "Eperform Build Text is not displayed in the home page", "Eperform Build Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformDateText, "Eperform Date Text is not displayed in the home page", "Eperform Date Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformUserCommunityText, "Eperform User Community Text is not displayed in the home page", "Eperform User Community Text  is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformContactAdmistratorText, "Eperform Contact Admistrator Text  is not displayed in the home page", "Eperform Contact Admistrator Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformGiveFeedbackText, "Eperform Give Feedback Text is not displayed in the home page", "Eperform Give Feedback Text is displayed in the home page");
            BaseMethods.verifyWebElement(homepage.EperformSelfHelpText, "Eperform SelfHelp Text is not displayed in the home page", "Eperform SelfHelp Text  is displayed in the home page");

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
