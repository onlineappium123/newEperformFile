using ePerform.Library.Extent_Reports;
using EPerform.Library;

using EPerform.Pages;
using ePerfrom.Library;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPerform.Tests
{
    [TestFixture]
    class _06ReferenceMaterialTest
    {
        static IWebDriver _driver;
        FormTemplatePage formtemplate;
       // String textvaue;
       [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }


        String textvaue;
        /// <summary>
        /// @Description:verifyManageDocumentPage invalid value
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "Verify Mange Document Page")]
        public void verifyManageDocumentPageInvalidValue()
        {
            try
            {

                ExtentReport.test = ExtentReport.extent.StartTest("Verify Mange Document Page for invalid value");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                 formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDocumentsOption.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(referenceMaterialPage.EperformAddDocumentButton, "Eperform AddDocument Button is not displayed", "Eperform AddDocument Button is displayed");
                referenceMaterialPage.EperformAddDocumentButton.Click();
                System.Threading.Thread.Sleep(3000);
                login.EperformSubmitButton.Click();
                System.Threading.Thread.Sleep(3000);
                BaseMethods.verifyWebElement(referenceMaterialPage.EperformNameBlankErrorMessage, "The Name field is required. is not displayed in Mange Document Page", "The Name field is required. is displayed Mange Document Page");
                BaseMethods.verifyWebElement(referenceMaterialPage.EperformFileBlankErrorMessage, "The File field is required. is not displayed in Mange Document Page", "The File field is required. is displayed Mange Document Page");
                System.Threading.Thread.Sleep(3000);
                formtemplate.EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }
        }

        /// <summary>
        /// @Description:verifyManageDocumentPage invalid value
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "Verify Mange Document Page")]
        public void verifyManageDocumentPage()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("Verify Mange Document Page for invalid value");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDocumentsOption.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDocumentButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.webelementverify(referenceMaterialPage.EperformNameText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformFileText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformCategotyText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformDescriptionText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformIsActiveText);
                formtemplate.EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000); 
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }
        }

        /// <summary>
        /// @Description:createActiveMustReadDocument,createActiveSupportingDocumentEdit
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "createActiveMustReadDocumentSupportingDocumentEdit")]
        public void createActiveMustReadDocumentSupportingDocumentEdit()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("createActiveMustReadDocumentSupportingDocumentEdit");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferenceMaterialPage", "KeyName", "ReferenceMaterialPage_01");
               formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDocumentsOption.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDocumentButton.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.createdocument(list[4].ToString(), list[5].ToString());
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }
        }

       

        /// <summary>
        /// @Description:inactiveDocument
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(4)]
        [TestCase(Description = "inactiveDocumentMustReadSupportingDocument")]
        public void inactiveDocumentMustReadSupportingDocument()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("inactiveDocumentMustReadSupportingDocument");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                FormTemplatePage formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferenceMaterialPage", "KeyName", "ReferenceMaterialPage_01");
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDocumentsOption.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDocumentButton.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.inactiveCreateDocumnet(list[4].ToString(), list[5].ToString());
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }
        }


        /// <summary>
        /// @Description:filenameColumnDownloadableExceptActionsSortableColumn and  pagination 
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(5)]
        [TestCase(Description = "filenameColumnDownloadableExceptActionsSortableColumn")]
        public void filenameColumnDownloadableExceptActionsSortableColumn()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("createActiveSupportingDocumentEdit");
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformDocumentsOption.Click();
            System.Threading.Thread.Sleep(2000);
            referenceMaterialPage.EperformReferenceMaterialNameIcon.Click();

            foreach (IWebElement element in referenceMaterialPage.EperformDocumentName)
            {

                BaseMethods.webelementverify(element);
            }

            foreach (IWebElement element in referenceMaterialPage.EperformFileNameIcon)
            {

                BaseMethods.webelementverify(element);
            }
            referenceMaterialPage.EperformReferenceMaterialFileNameIcon.Click();

            foreach (IWebElement element in referenceMaterialPage.EperformFileNameIcon)
            {

                BaseMethods.webelementverify(element);
            }

            foreach (IWebElement element in referenceMaterialPage.EperformHomeCategoryText)
            {

                BaseMethods.webelementverify(element);
            }
            referenceMaterialPage.EperformReferenceMaterialCategoryIcon.Click();

            foreach (IWebElement element in referenceMaterialPage.EperformHomeCategoryText)
            {
                BaseMethods.webelementverify(element);
            }


            foreach (IWebElement element in referenceMaterialPage.EperformDocumentActive)
            {

                BaseMethods.webelementverify(element);
            }
            referenceMaterialPage.EperformReferenceMaterialActiveIcon.Click();

            foreach (IWebElement element in referenceMaterialPage.EperformHomeCategoryText)
            {
                BaseMethods.webelementverify(element);
            }
            referenceMaterialPage.EperformFileDownloadIcon.Click();
            ExtentReport.test.Log(LogStatus.Pass,"The file is download");
            System.Threading.Thread.Sleep(3000);
            int count = referenceMaterialPage.EperformPage.Count;
            for (int i = 1; i <= count; i++)
            {
                System.Threading.Thread.Sleep(5000);
                ExtentReport.test.Log(LogStatus.Pass, _driver.FindElement(By.Id("table1_info")) + "The file is download");
                _driver.FindElement(By.XPath("(//button[@class='btn-default  btn'])[" + i + "]")).Click();

            }
            System.Threading.Thread.Sleep(2000);

        }

        /// <summary>
        /// @Description:To verify cancel button in the manage document form
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(6)]
        [TestCase(Description = "To verify cancel button in the manage document form")]
     
        public void cancelButtonManageDocumentForm()
        {

            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("CancelButtonManageDocumentForm");
                ArrayList list = BaseClass.GetData("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDocumentsOption.Click();
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDocumentButton.Click();
                System.Threading.Thread.Sleep(2000);
                formtemplate.EperformCancelButton.Click();
                home.pageverify(list[5].ToString());
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }
        }


        /// <summary>
        /// @Description:To verify Development Activity List page
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(7)]
        [TestCase(Description = "To verify Development Activity List page")]
        public void verifyDevelopmentActivityPage()
        {

            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("verifyDevelopmentActivityPage");
                ArrayList list = BaseClass.GetData("EP_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04");
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDevelopmentActivitiesOption.Click();
                System.Threading.Thread.Sleep(3000);
                BaseMethods.verifyWebElement(formtemplate.EperformFormTemplateSearchTextBox, "Search textbox is not displayed", "Search textbox is displayed");
                BaseMethods.verifyWebElement(formtemplate.EperformFormTemplateSearchButton, "Search button is not displayed", "Search Button is displayed");
                BaseMethods.verifyWebElement(referenceMaterialPage.EperformAddDevelopmentActivityButton, "Eperform AddDevelopmentActivity Button is not displayed", "Eperform AddDevelopmentActivity Button is displayed");
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDevelopmentActivityButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(referenceMaterialPage.EperformManageDevelopmentActivityText, "Eperform ManageDevelopment Activity Text is not displayed", "Eperform Manage Development Activity Text is displayed");
                BaseMethods.webelementverify(referenceMaterialPage.EperformNameText);
                BaseMethods.webelementverify(reference.EperformDevelopmentActivitiesYesRadioBtn);
                BaseMethods.webelementverify(reference.EperformDevelopmentActivitiesNoRadioBtn);
                BaseMethods.webelementverify(referenceMaterialPage.EperformDescriptionText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformIsActiveText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformPillarText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformDateText);
                BaseMethods.webelementverify(referenceMaterialPage.EperformYesNoText);
                BaseMethods.webelementverify(formtemplate.EperformCancelButton);
                BaseMethods.webelementverify(reference.EperformSubmit);
                System.Threading.Thread.Sleep(2000);
                formtemplate.EperformCancelButton.Click();
                home.pageverify(list[4].ToString());
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }

        }

        /// <summary>
        /// @Description:To verify Development Activity List page
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(8)]
        [TestCase(Description = "To verify Development Activity List page")]
        public void verifyManageDevelopmentActivity()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("verifyDevelopmentActivityPage");
               
                LoginPage login = new LoginPage(_driver);
                HomePage home = new HomePage(_driver);
                FormTemplatePage formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDevelopmentActivitiesOption.Click();
                System.Threading.Thread.Sleep(3000);
                foreach (IWebElement element in reference.EPerformEditButtonList)
                {
                    BaseMethods.webelementverify(element);
                }
                System.Threading.Thread.Sleep(2000);
                referenceMaterialPage.EperformAddDevelopmentActivityButton.Click();
                System.Threading.Thread.Sleep(4000);
                BaseMethods.verifyWebElement(reference.EperformpillarsSelectText, "PleaseSelect text is not displayed Defaults", "PleaseSelect text is displayed Defaults");
                reference.EperformPillarDropDownIcon.Click();
                System.Threading.Thread.Sleep(2000);

                foreach (IWebElement element in reference.EperformPillarDropDownList)
                {
                    BaseMethods.webelementverify(element);
                }
                reference.EperformSubmit.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.webelementverify(reference.EperformErrorMessage);
                foreach (IWebElement element in reference.EperformRequiredErrorMessage)
                {
                    BaseMethods.webelementverify(element);
                }
                System.Threading.Thread.Sleep(2000);
                formtemplate.EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                formtemplate.EperformCancelButton.Click();
            }

        }

        /// <summary>
        /// @Description:Create a development activity which is active/inactive
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(9)]
        [TestCase(Description = "Create a development activity which is active/inactive")]
        public void createDevelopmentActiveInactive()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyDevelopmentActivityPage");
            
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            reference.addDevelopmentActivity("DevelopmentActivityForm", "DevelopmentActivityform_01");
           
        }

        /// <summary>
        /// @Description:Edit and search a development activity
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(10)]
        [TestCase(Description = "Edit and search a development activity")]
        public void editSearchDevelopmentActivity()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("editSearchDevelopmentActivity");
           
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            reference.editDevelopmentActivity("DevelopmentActivityForm", "DevelopmentActivityform_01");
        }

        /// <summary>
        /// @Description:Try to create a dev activity with the same name as another dev plan(should be able to)
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(11)]
        [TestCase(Description = "Try to create a dev activity with the same name as another dev plan(should be able to)")]
        public void sameDevelopmentActivity()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("sameDevelopmentActivity");
            
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            reference.addDevelopmentActivity("DevelopmentActivityForm", "DevelopmentActivityform_02");
            reference.addDevelopmentActivity("DevelopmentActivityForm", "DevelopmentActivityform_02");
            ArrayList list2 = BaseClass.GetData("EP_TESTDATA", "DevelopmentActivityForm", "KeyName", "DevelopmentActivityform_02"); 
            reference.search(list2[1].ToString());
            BaseMethods.webelementverify(reference.NameText);
        }

        /// <summary>
        /// @Description:Verify the Pillars page 
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(12)]
        [TestCase(Description = "Verify the Pillars page ")]
        public void verifyPillarsPage()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyPillarsPage");
            
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformPillarsOption.Click();
            BaseMethods.webelementverify(referencePillars.PillarText);
            BaseMethods.webelementverify(referencePillars.PillarNameText);
            BaseMethods.webelementverify(referencePillars.PillarDescriptionText);
            BaseMethods.webelementverify(referencePillars.PillarActiveText);
            BaseMethods.webelementverify(referencePillars.PillarActionsText);
            BaseMethods.webelementverify(reference.EperformEditButton);
            BaseMethods.verifyWebElement(referencePillars.AddPillarButton,"Add Pillar button is not displayed","Add Pillar button is  displayed");
            referencePillars.AddPillarButton.Click();
            BaseMethods.webelementverify(referenceMaterialPage.EperformNameText);
            BaseMethods.webelementverify(referenceMaterialPage.EperformDescriptionText);
            BaseMethods.webelementverify(referenceMaterialPage.EperformIsActiveText);
            BaseMethods.verifyWebElement(reference.EperformSubmit,"Pillar submit button is not displayed","Pillar submit button is  displayed");
            BaseMethods.verifyWebElement(formtemplate.EperformCancelButton, "Pillar cancel button is not displayed", "Pillar cancel button is displayed");
            BaseMethods.webelementverify(referencePillars.PillarManagePillarText);
            reference.EperformSubmit.Click();
            BaseMethods.webelementverify(referencePillars.errorMessageName);
            formtemplate.EperformCancelButton.Click();
        }

        /// <summary>
        /// @Description:Sortable the Pillars page 
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(13)]
        [TestCase(Description = "Sortable the Pillars page ")]
        public void sortablePillarsPage()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("sortablePillarsPage");
          
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformPillarsOption.Click();
            referencePillars.sortablepillarpage();
        }
        /// <summary>
        /// @Description:Verify the Pillars page and with same name invalid error should be displayed
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(14)]
        [TestCase(Description = "Verify the Pillars page ")]
        public void createEditPillars()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("createEditPillars");
            
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            referencePillars.createEditpillar("ReferencePillar", "ReferncePillar_01");
           
        }

        /// @Description:Check whether the above page contains –Pillar field which is a dropdown and Try to save a dev activity with an inactive pillar
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(15)]
        [TestCase(Description = "Verify the Pillars page ")]
        public void verifyPillarInDevelopmentActivity()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyPillarInDevelopmentActivity");
            ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferencePillar", "KeyName", "ReferncePillar_01");
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            referencePillars.createPillar("ReferencePillar", "ReferncePillar_01");
            System.Threading.Thread.Sleep(2000);
            home.EperformReferenceMaterialIcon.Click();
            home.EperformDevelopmentActivitiesOption.Click();
            referenceMaterialPage.EperformAddDevelopmentActivityButton.Click();
            reference.EperformPillarDropDownIcon.Click();
            IWebElement element = _driver.FindElement(By.XPath("//option[text()='"+list[1].ToString()+"']"));
            BaseMethods.webelementverify(element);
            formtemplate.EperformCancelButton.Click();
        }

        /// @Description:List Goals
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(16)]
        [TestCase(Description = "Verify the GoalElementpage ")]
        public void verifyGoalElementpage()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyGoalElementpage");
            ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferencePillar", "KeyName", "ReferncePillar_01");
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            ReferenceMaterialPageGoal referenceGoals = new ReferenceMaterialPageGoal(_driver);
            referenceGoals.gotoGoalPage();
            BaseMethods.webelementverify(referenceGoals.EperformGoalsText);
            BaseMethods.webelementverify(referenceGoals.EperformShowAdvancedSearchButton);
            BaseMethods.verifyWebElement(reference.EperformSearchButton, "Search Button is not displayed", "Search Button is displayed");
            BaseMethods.webelementverify(referenceGoals.EperformKeywordText);
            BaseMethods.verifyWebElement(formtemplate.EperformGlobalQuestionsSearchTextBox, "Search textbox is not displayed", "Search Textbox is displayed");
            BaseMethods.verifyWebElement(referenceGoals.EperformAddGoalButton, "Add Goal button is not displayed", "Add Goal button is displayed");
            BaseMethods.verifyWebElement(referenceGoals.EperformCustomiseText, "Customise Text is not displayed", "Customise Text is displayed");
            referenceGoals.goalHomeVerifySortableText("Name");
            referenceGoals.goalHomeVerifySortableText("Type");
            referenceGoals.goalHomeVerifySortableText("Pillar");
            referenceGoals.goalHomeVerifySortableText("Active");
            referenceGoals.goalHomeVerifySortableText("Actions");
            referenceGoals.customiseoption();
        }

        /// @Description:verify the Manage Goal page
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(17)]
        [TestCase(Description = "verify the Manage Goal page")]
        public void verifyManageGoalpage()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyGoalElementpage");
            ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferencePillar", "KeyName", "ReferncePillar_01");
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            ReferenceMaterialPageGoal referenceGoals = new ReferenceMaterialPageGoal(_driver);
            referenceGoals.gotoGoalPage();
            referenceGoals.EperformAddGoalButton.Click();
            System.Threading.Thread.Sleep(2000);
            referenceGoals.manageGoalPage();
        }

        /// @Description:Create active inactive Goal
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(18)]
        [TestCase(Description = "create active inactive Goal")]
        public void createactiveinactiveGoal()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyGoalElementpage");
            ArrayList list = BaseClass.GetData("EP_TESTDATA", "ReferencePillar", "KeyName", "ReferncePillar_01");
            LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            ReferenceMaterialPageGoal referenceGoals = new ReferenceMaterialPageGoal(_driver);
            referenceGoals.gotoGoalPage();
            referenceGoals.EperformAddGoalButton.Click();
            referenceGoals.createGoal("ReferenceGoals", "ReferenceGoals_01");
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
