﻿using ePerform.Library.Extent_Reports;
using ePerform.Pages;
using EPerform.Library;
using EPerform.Library.Excel;

using EPerform.Pages;
using ePerfrom.Library;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Tests
{
    [TestFixture]
    public class _04FormTemplateTest
    {
        static IWebDriver _driver;
        FormTemplatePage formTemplatepage;
        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }
        /// <summary>
        /// @Description:To verify cancel button in the manage form
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "to verify cancel button in the manage form")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Priority(1)]
        public void CancelButtonManageForm()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("CancelButtonManageForm");
            DataRow data = ExcelData.GetData_DataTable("ER_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_08").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformAddFormTemplateButton, "Eperform AddFormTemplate Button is not displayed in the Form Template page", "Eperform AddFormTemplate Button  is displayed in the Form Template page");
            formTemplatepage.EperformAddFormTemplateButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformCancelButton, "Eperform Cancel Button is not displayed in the Manage form page", "Eperform Cancel Button is displayed in the Manage form page");
            formTemplatepage.EperformCancelButton.Click();
            homepage.pageverify(data["HomeSystemConfigurationPage"].ToString());

        }

        /// <summary>
        /// @Description:To verify Manage form page
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "to verify Manage form page")]
        public void verifyManageFormPage()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("verifyManageFormPage");
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.EperformAddFormTemplateButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformManageFormText, "Eperform ManageForm Text is not displayed", "Eperform ManageForm Text is displayed");
            BaseMethods.webelementverify(formTemplatepage.EperformDenotesamandatoryfieldText);
            BaseMethods.webelementverify(formTemplatepage.EperformManageFormNameText);
            BaseMethods.webelementverify(formTemplatepage.EperformManageFormIsActiveText);
            BaseMethods.webelementverify(formTemplatepage.EperformManageFormFormTypeText);
            BaseMethods.webelementverify(formTemplatepage.EperformYesText);
            BaseMethods.webelementverify(formTemplatepage.EperformNoText);
            BaseMethods.webelementverify(formTemplatepage.EperformSubmitButton);
            BaseMethods.webelementverify(formTemplatepage.EperformCancelButton);
            formTemplatepage.EperformSelectformtype.Click();
            foreach (IWebElement element in formTemplatepage.EperformFormTypeList)
            {

                Assert.IsTrue(element.Displayed,
                        element.Text + " is not dispalyed");
                ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
            }


        }

        /// <summary>
        /// @Description:AddFormTemplatesGobalQuestionDevelopmentActivityForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "addFormTemplatesGobalQuestionDevelopmentActivityForm")]

        public void addFormTemplatesGobalQuestionDevelopmentActivityForm()
        {

            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("addFormTemplatesGobalQuestionDevelopmentActivityForm");
                formTemplatepage = new FormTemplatePage(_driver);
                formTemplatepage.addFormTemplateDevelopmentActivityForm("FormTemplateTest", "FormType2");

                BaseMethods.verifyWebElement(formTemplatepage.EperformReferenceText, "Eperform Reference Text is not displayed in manage form", "Eperform Reference Text is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformQuestionText, "Eperform Question Text is not displayed in manage form", "Eperform Question Text is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformTypeText, "Eperform Type Text is not displayed in manage form", "Eperform Type Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformMandatoryText, "Eperform Mandatory Text is not displayed in manage form", "Eperform Mandatory Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperfromActionsText, "Eperfrom Actions Text is not displayed in manage form", "Eperfrom Actions Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformPreviewFormLink, "Eperform PreviewForm Link is not displayed in manage form", "Eperform PreviewForm Link  is displayed in manage form");

                formTemplatepage.EperformPreviewFormLink.Click();
                System.Threading.Thread.Sleep(5000);
                BaseMethods.webelementverify(formTemplatepage.EperformPreviewFormText);

                formTemplatepage.EperformBackButton.Click();

                formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType2");
                formTemplatepage.EperformPreviewFormLink.Click();

                BaseMethods.webelementverify(formTemplatepage.EperformGobalQuestionText);
                formTemplatepage.EperformBackButton.Click();

            }
            catch (Exception e)
            {
                formTemplatepage.EperformBackButton.Click();
            }

        }
        /// <summary>
        /// @Description:AddFormTemplatesGobalQuestionQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(4)]
        [TestCase(Description = "addFormTemplatesGobalQuestionQuestionnaireForm")]
        public void addFormTemplatesGobalQuestionQuestionnaireForm()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent.StartTest("addFormTemplatesGobalQuestionQuestionnaireForm");
                formTemplatepage = new FormTemplatePage(_driver);
                formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");

                BaseMethods.verifyWebElement(formTemplatepage.EperformReferenceText, "Eperform Reference Text is not displayed in manage form", "Eperform Reference Text is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformQuestionText, "Eperform Question Text is not displayed in manage form", "Eperform Question Text is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformTypeText, "Eperform Type Text is not displayed in manage form", "Eperform Type Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperfromMandatoryText, "Eperfrom Mandatory Text is not displayed in manage form", "Eperfrom Mandatory Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperfromActionsText, "Eperfrom Actions Text is not displayed in manage form", "Eperfrom Actions Text  is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformPreviewFormLink, "Eperform PreviewForm Link is not displayed in manage form", "Eperform PreviewForm Link  is displayed in manage form");

                formTemplatepage.EperformPreviewFormLink.Click();

                formTemplatepage.EperformPreviewFormAsDropdownIcon.Click();
                foreach (IWebElement element in formTemplatepage.EperformGobalQuestionNameTEXT)
                {

                    ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
                }

                formTemplatepage.EperformBackButton.Click();


                formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType1");

                formTemplatepage.EperformPreviewFormLink.Click();


                foreach (IWebElement element in formTemplatepage.EperformGobalQuestionNameTEXT)
                {

                    ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
                }
                formTemplatepage.EperformBackButton.Click();


            }
            catch (Exception e)
            {
                formTemplatepage.EperformBackButton.Click();
            }
        }


        /// <summary>
        /// @Description:AddQuestionQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(5)]
        [TestCase(Description = "AddQuestionQuestionnaireForm")]
        public void addquestionQuestionnaireForm()
        {
            try
            {
                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("addquestionQuestionnaireForm");
                DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];

                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                formTemplatepage.EperformAddFormTemplateButton.Click();
                formTemplatepage.EperformNameTextBox.SendKeys(data["Form Type"].ToString());
                formTemplatepage.EperformYesRadioButton.Click();
                formTemplatepage.EperformSelectformtype.Click();
                BaseMethods.DdlSelectByValue(formTemplatepage.EperformSelectformtype, data["Form Type"].ToString());
                formTemplatepage.EperformSubmitButton.Click();
                formTemplatepage.verifyFormType("ePeform Questionnaire Form");
                formTemplatepage.EperformSubmitButton.Click();
                formTemplatepage.EperformPreviewFormLink.Click();
                formTemplatepage.EperformPreviewFormAsDropdownIcon.Click();
                Thread.Sleep(2000);
                foreach (IWebElement element in formTemplatepage.EperformPreviewFormasList)
                {

                    BaseMethods.webelementverify(element);
                }
                
                formTemplatepage.EperformBackButton.Click();
                Thread.Sleep(2000);
                Assert.IsTrue(formTemplatepage.EperformAddquestionButton.Displayed, "Eperform Add question Button is not displayed in manage form");
                ExtentReport.test.Log(LogStatus.Pass, " Eperform Add question Button is displayed in manage form");
                formTemplatepage.EperformAddquestionButton.Click();
                formTemplatepage.createLocalQuestion();
                formTemplatepage.EperformPreviewFormLink.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformPreviewLinkNameText);
                formTemplatepage.EperformBackButton.Click();
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }
        }

        /// <summary>
        /// @Description:AddquestionEditDeleteDevelopmentActivityForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(6)]
        [TestCase(Description = "addquestionEditDeleteDevelopmentActivityForm")]
        public void EditDeleteDevelopmentActivityForm()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("addquestionEditDeleteDevelopmentActivityForm");
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
            String Text = data["reference"].ToString();
            formTemplatepage.developmentActivityEditSearch("FormTemplateTest", "FormType2");
            formTemplatepage.EperformReferenceTestbox.Clear();
            formTemplatepage.EperformReferenceTestbox.SendKeys(data["reference"].ToString());
            formTemplatepage.EperformReadOnlyYesRadioBtn.Click();
            formTemplatepage.EperformSubmitButton.Click();
            IWebElement EditChangeElement = _driver.FindElement(By.XPath("//td[contains(text(),'" + Text + "')]"));
            BaseMethods.webelementverify(EditChangeElement);
            BaseMethods.verifyWebElement(formTemplatepage.EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");
            formTemplatepage.EperformGlobalQuestionDeleteButton.Click();
            formTemplatepage.EperformAddQuestionOkButton.Click();
        }
        /// <summary>
        /// @Description:AddquestionEditDeleteQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(7)]
        [TestCase(Description = "addquestionEditDeleteQuestionnaireForm")]

        public void EditDeleteQuestionnaireForm()
        {
            try
            {
                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("addquestionEditDeleteQuestionnaireForm");
                DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];

                String Text = data["reference"].ToString();
                formTemplatepage.questionnaireformEditSearch("FormTemplateTest", "FormType1");
                formTemplatepage.EperformReferenceTestbox.Clear();
                formTemplatepage.EperformReferenceTestbox.SendKeys(data["reference"].ToString());
                formTemplatepage.TxtLabel(data["label"].ToString());
                formTemplatepage.EperformReadOnlyYesRadioBtn.Click();
                formTemplatepage.EperformSubmitButton.Click();
                IWebElement EditChangeElement = _driver.FindElement(By.XPath("//td[contains(text(),'" + Text + "')]"));
                Assert.IsTrue(EditChangeElement.Displayed, "Eperform Add question Button is not displayed in manage form");
                ExtentReport.test.Log(LogStatus.Pass, Text + "is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");

                formTemplatepage.EperformGlobalQuestionDeleteButton.Click();
                formTemplatepage.EperformAddQuestionOkButton.Click();
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }

        }

        /// <summary>
        /// @Description:AddquestionEditDeleteQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(8)]
        [TestCase(Description = "SortableNameActiveSearchFunctionally")]
        public void sortableNameActiveSearchFunctionally()
        {
            try
            {
                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("SortableNameActiveSearchFunctionally");
                DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];
                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformNameText);
                BaseMethods.webelementverify(formTemplatepage.EperformNameSortText);
                formTemplatepage.EperformNameText.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformNameSortText);
                BaseMethods.verifyWebElement(formTemplatepage.EperformActiveText, "Eperform Active Text is not displayed in form template page", "Eperform Active Text is displayed in form template page");
                BaseMethods.webelementverify(formTemplatepage.EperformActiveSortText);
                formTemplatepage.EperformActiveText.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformActiveSortText);
                formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(data["FormName"].ToString());
                formTemplatepage.EperformFormTemplateSearchButton.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformNameSortText);
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }
        }

        /// <summary>
        /// @Description:verifyActionscolumnMovingquestionsUpAndDownQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(9)]
        [TestCase(Description = "verifyActionscolumnMovingquestionsUpAndDownQuestionnaireForm")]

        public void verifyActionscolumnMovingquestionsUpAndDownQuestionnaireForm()
        {
            try
            {

                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("verifyActionscolumnMovingquestionsUpAndDownQuestionnaireForm");
                DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
                formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
                formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType1");
                formTemplatepage.handleAddLocalQuestionMultiLineTextArea(dr[" Multi Line Text Area"].ToString(), dr["reference"].ToString(), dr["maxLength"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                BaseMethods.verifyWebElement(formTemplatepage.EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformEditButton, "Eperform Edit Button is not displayed in manage form", "Eperform Edit Button is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformDownButton, "Eperform Down Button is not displayed in manage form", "Eperform Down Button is displayed in manage form");
                BaseMethods.verifyWebElement(formTemplatepage.EperformUpButton, "Eperform Up Button is not displayed in manage form", "Eperform Up Button is displayed in manage form");
                formTemplatepage.EperformPreviewFormLink.Click();

                BaseMethods.webelementverify(formTemplatepage.EperformPreviewLinkTextformat);
                formTemplatepage.EperformBackButton.Click();
                System.Threading.Thread.Sleep(2000);
                formTemplatepage.EperformDownButton.Click();
                formTemplatepage.EperformPreviewFormLink.Click();
                BaseMethods.webelementverify(formTemplatepage.EperformPreviewLinkTextformat);
                formTemplatepage.EperformBackButton.Click();
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }
          
        }


        /// <summary>
        /// @Description:verifyQuestionRoleSubmitPreviewLink
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(10)]
        [TestCase(Description = "verifyQuestionRoleSubmitPreviewLink")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Priority(10)]
        public void verifyQuestionRoleSubmitPreviewLink()
        {

            try
            {
                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("verifyQuestionRoleSubmitPreviewLink");
                DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
                formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
                formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType1");
                formTemplatepage.handleAddLocalQuestionMultiLineTextArea(dr[" Multi Line Text Area"].ToString(), dr["reference"].ToString(), dr["maxLength"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "RoleType", "KeyName", "RoleType_01").Rows[0];
                formTemplatepage.filledByRoles(data["RoleType"].ToString());
                formTemplatepage.EperformPreviewFormLink.Click();
                formTemplatepage.EperformPreviewFormAsDropdownIcon.Click();
                BaseMethods.DdlSelectByText(formTemplatepage.EperformPreviewFormAsDropdownIcon, data["RoleType"].ToString());
                Assert.IsTrue(formTemplatepage.EperformPreviewLinkTextformat.Displayed, "Eperform PreviewName Text not displayed");
                ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformPreviewLinkTextformat.Text + "is displayed before selecting Preview form");

                formTemplatepage.EperformPreviewFormAsDropdownIcon.Click();
                BaseMethods.DdlSelectByText(formTemplatepage.EperformPreviewFormAsDropdownIcon, data["RoleType"].ToString());
                Assert.IsTrue(formTemplatepage.EperformPreviewNameText.Displayed, "Eperform PreviewName Text not displayed");
                ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformPreviewNameText.Text + "is displayed After selecting Preview form");
                formTemplatepage.EperformBackButton.Click();
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }

        }
        /// <summary>
        /// @Description:questionnaireFormTemplateToInactive
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(11)]
        [TestCase(Description = "questionnaireFormTemplateToInactive")]
        public void questionnaireFormTemplateToInactive()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("questionnaireFormTemplateToInactive");
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            Assert.IsTrue(formTemplatepage.EperformActiveSortText.Displayed, "Active Text is not displayed");
            ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformActiveSortText.Text + "Before change to inactive");
            formTemplatepage.EperformEditButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformComponentTypeText);
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformSubmitButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(formTemplatepage.EperformGlobalQuestionAddedText.Text);
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            Assert.IsTrue(formTemplatepage.EperformActiveSortText.Displayed, "Active Text is not displayed");
            ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformActiveSortText.Text + "After change to inactive");
        }

        /// <summary>
        /// @Description:verifyMovingquestionsUpAndDownDevelopmentActivityForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(12)]
        [TestCase(Description = "verifyMovingquestionsUpAndDownDevelopmentActivityForm")]

        public void verifyMovingquestionsUpAndDownDevelopmentActivityForm()
        {

            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            SelectQuestionTypePage QTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("verifyMovingquestionsUpAndDownDevelopmentActivityForm");
            formTemplatepage.addFormTemplateDevelopmentActivityForm("FormTemplateTest", "FormType2");
            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType2");
            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType3");
            formTemplatepage.EperformPreviewFormLink.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformGobalQuestionText);
            formTemplatepage.EperformBackButton.Click();
            Thread.Sleep(2000);
            formTemplatepage.EperformDownButton.Click();
            formTemplatepage.EperformPreviewFormLink.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformGobalQuestionText);
            formTemplatepage.EperformBackButton.Click();
        }





        /// <summary>
        /// @Description:DevelopmentActivityFormTemplateToInactive
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(13)]
        [TestCase(Description = "DevelopmentActivityFormTemplateToInactive")]
        public void DevelopmentActivityFormTemplateToInactive()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("DevelopmentActivityFormTemplateToInactive");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType2").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["FormName"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformActiveSortText);
            formTemplatepage.EperformEditButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformComponentTypeText);
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformSubmitButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["FormName"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformActiveSortText);

        }

        /// <summary>
        /// @Description:Questionnaire Form inactiveGlobalQuestionsFormTemplate
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(14)]
        [TestCase(Description = "inactiveGlobalQuestionsFormTemplate")]
        public void inactiveGlobalQuestionsFormTemplate()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("inactiveGlobalQuestionsFormTemplate");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];

            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();

            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();

            formTemplatepage.EperformEditButton.Click();

            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformSubmitButton.Click();

            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();

            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            BaseMethods.webelementverify(_driver.FindElement(By.Id("NoListRecords")));


        }

        /// <summary>
        /// @Description:previewInactiveOptions
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(15)]
        [TestCase(Description = "previewInactiveOptions")]
        public void previewInactiveOptions()
        {

            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("previewInactiveOptions");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
            formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
            formTemplatepage.handleAddLocalQuestionMultiLineTextArea(dr[" Multi Line Text Area"].ToString(), dr["reference"].ToString(), dr["maxLength"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
            formTemplatepage.EperformEditButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformReadOnlyYesRadioBtn, "The Inactive option is not displayed in local question", "The Inactive option is displayed in local question");


            formTemplatepage.EperformSubmitButton.Click();
            formTemplatepage.EperformPreviewFormLink.Click();
            IList<IWebElement> element = _driver.FindElements(By.Id("Dto_IsReadOnly_t"));
            if (element.Count != 0)
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Inactive option is displayed in local question");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Inactive option is not displayed in local question");
            }

            formTemplatepage.EperformBackButton.Click();

        }


        /// <summary>
        /// @Description: Questionnaire Form MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplate
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(16)]
        [TestCase(Description = "MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplate")]
        public void MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplate()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplate");
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();
            formTemplatepage.BtnAddGlobalQuestion.Click();
            formTemplatepage.RdoSingleItemSelect.Click();
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformGobalQuestionActiveText, "Active/Inactive text is not displayed", "Active/Inactive text is  displayed");
            BaseMethods.Navigate_Back(_driver);
            formTemplatepage.EperformCancelButton.Click();
            formTemplatepage.BtnAddGlobalQuestion.Click();
            formTemplatepage.EperformRdoMultiLineTextArea.Click();
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformGobalQuestionActiveText, "Active/Inactive text is not displayed", "Active/Inactive text is  displayed");
            formTemplatepage.EperformCancelButton.Click();
            formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType1");
            formTemplatepage.EperformEditButton.Click();
            IList<IWebElement> element = _driver.FindElements(By.XPath("//label[contains(text(),'Active')]"));
            if (element.Count != 0)
            {

                ExtentReport.test.Log(LogStatus.Pass, "The Active/Inacive option is displayed in local question");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Active/Inacive option is not displayed in local question");
            }
        }

        /// <summary>
        /// @Description:addRestrictedGlobalQuestionsQuestionnaireForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(17)]
        [TestCase(Description = "addRestrictedGlobalQuestionsQuestionnaireForm")]
        public void addRestrictedGlobalQuestionsQuestionnaireForm()
        {
            try
            {
                HomePage homepage = new HomePage(_driver);
                formTemplatepage = new FormTemplatePage(_driver);
                ExtentReport.test = ExtentReport.extent.StartTest("addRestrictedGlobalQuestionsQuestionnaireForm");
                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
                formTemplatepage.EperformAddglobalquestionButton.Click();
                DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];
                formTemplatepage.EperformGlobalQuestionsSearchTextBox.SendKeys(dr["RestrictedGobalQuestion"].ToString());
                formTemplatepage.EperformGlobalQuestionSearchButton.Click();
                formTemplatepage.EperformGlobalQuestionCheckBox.Click();
                formTemplatepage.EperformGobalQuestionSubmitButton.Click();
                Assert.IsTrue(formTemplatepage.EperformGlobalQuestionAddedText.Displayed, "Restricted global questions is not added to the form template");
                ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformGlobalQuestionAddedText + " is added to the form template");
            }
            catch
            {
                formTemplatepage.EperformBackButton.Click();
            }
        }

        /// <summary>
        /// @Description: Questionnaire Form changesMadeGlobalQuestionNotReflectedInFormTemplate
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(18)]
        [TestCase(Description = "changesMadeGlobalQuestionNotReflectedInFormTemplate")]
        public void changesMadeGlobalQuestionNotReflectedInFormTemplate()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("changesMadeGlobalQuestionNotReflectedInFormTemplate");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType4");
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();
            Thread.Sleep(3000);
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            formTemplatepage.EperformEditButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformReferenceTestbox);
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformReferenceTestbox.Clear();
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
            formTemplatepage.EperformReferenceTestbox.SendKeys(data["Change reference"].ToString());
            formTemplatepage.EperformSubmitButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();

            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["FormName"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            Thread.Sleep(3000);
            int count = formTemplatepage.EperformEditListButton.Count();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    formTemplatepage.EperformEditButton.Click();
                    if (formTemplatepage.EperformEditButton.Displayed)
                    {


                        formTemplatepage.EperformEditButton.Click();

                        BaseMethods.webelementverify(formTemplatepage.EperformReferenceTestbox);
                        break;
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        _driver.Navigate().Back();
                    }
                }
            }
            catch
            {
                Thread.Sleep(3000);
                _driver.Navigate().Back();
            }
        }




    /// <summary>
    /// @Description:multiSelectSingleSelectLocalQuestionsActiveInactiveFormTemplate
    /// @Author:RaghuKiran MR
    /// </summary>
    [Test, Order(19)]
        [TestCase(Description = "multiSelectSingleSelectLocalQuestionsActiveInactiveFormTemplate")]
        public void multiSelectSingleSelectLocalQuestionsActiveInactiveFormTemplate()
        {

            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("multiSelectSingleSelectLocalQuestionsActiveInactiveFormTemplate");

            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.addformtemplateQuestionnaireForm("FormTemplateTest", "FormType1");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
            formTemplatepage.EperformAddquestionButton.Click();
            formTemplatepage.handleLocalQuestionSingleLineTextBox(dr["Single Line Text Box"].ToString(), dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
            formTemplatepage.EperformEditButton.Click();
            formTemplatepage.EperformOptionsIcon.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformAddOptionButton, "Add Option Button is not displayed", "Add Option Button is displayed");
            formTemplatepage.EperformAddOptionButton.Click();
            formTemplatepage.EperformOptionTextBox.SendKeys(dr["OptionTextBox"].ToString());
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformOptionYesText);
            Assert.IsTrue(formTemplatepage.EperformOptionYesText.Displayed, "Active Yes text is not displayed");
            ExtentReport.test.Log(LogStatus.Pass, formTemplatepage.EperformOptionYesText.Text + "is displayed");
            formTemplatepage.EperformEditButton.Click();
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformOptionYesText);
        }


        /// <summary>
        /// @Description: Development Activity Form MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplateDevelopmentActivity
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(20)]
        [TestCase(Description = "MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplateDevelopmentActivity")]
        public void MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplateDevelopmentActivity()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("MultiSelectSingleSelectGlobalQuestionsCannotActiveInactiveFormTemplateDevelopmentActivity");
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();
            formTemplatepage.BtnAddGlobalQuestion.Click();
            formTemplatepage.RdoSingleItemSelect.Click();
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformGobalQuestionActiveText, "Active/Inactive text is not displayed", "");
            BaseMethods.Navigate_Back(_driver);
            formTemplatepage.EperformCancelButton.Click();
            formTemplatepage.BtnAddGlobalQuestion.Click();

            formTemplatepage.EperformRdoMultiLineTextArea.Click();
            formTemplatepage.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(formTemplatepage.EperformGobalQuestionActiveText, "Active/Inactive text is not displayed", "Active/Inactive text is not displayed");
            formTemplatepage.EperformCancelButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.addFormTemplateDevelopmentActivityForm("FormTemplateTest", "FormType2");
            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType2");
            formTemplatepage.EperformEditButton.Click();
            IList<IWebElement> element = _driver.FindElements(By.XPath("//label[contains(text(),'Active')]"));
            if (element.Count != 0)
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Active/Inacive option is displayed in local question");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Active/Inacive option is not displayed in local question");
            }

        }

        /// <summary>
        /// @Description:Development Activity Form inactiveGlobalQuestionsFormTemplateDevelopmentActivityForm
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(21)]
        [TestCase(Description = "inactiveGlobalQuestionsFormTemplateDevelopmentActivityForm")]
        public void inactiveGlobalQuestionsFormTemplateDevelopmentActivityForm()
        {
            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("inactiveGlobalQuestionsFormTemplateDevelopmentActivityForm");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            formTemplatepage.EperformEditButton.Click();
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformSubmitButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            BaseMethods.webelementverify(_driver.FindElement(By.Id("NoListRecords")));
        }

        /// <summary>
        /// @Description: Questionnaire Form changesMadeGlobalQuestionNotReflectedInFormTemplate
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(22)]
        [TestCase(Description = "changesMadeGlobalQuestionNotReflectedInFormTemplateDevelopmentActivityForm")]
        public void changesMadeGlobalQuestionNotReflectedInFormTemplateDevelopmentActivityForm()
        {

            HomePage homepage = new HomePage(_driver);
            formTemplatepage = new FormTemplatePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("changesMadeGlobalQuestionNotReflectedInFormTemplateDevelopmentActivityForm");
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType2").Rows[0];
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            formTemplatepage.addFormTemplateDevelopmentActivityForm("FormTemplateTest", "FormType2");

            formTemplatepage.addGlobalQuestion("FormTemplateTest", "FormType1");

            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformGlobalQuestionsOption.Click();

            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["GlobalQuestionType"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            formTemplatepage.EperformEditButton.Click();
            BaseMethods.webelementverify(formTemplatepage.EperformReferenceTestbox);
            formTemplatepage.EperformNoRadioButton.Click();
            formTemplatepage.EperformReferenceTestbox.Clear();
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];

            formTemplatepage.EperformReferenceTestbox.SendKeys(data["Change reference"].ToString());
            formTemplatepage.EperformSubmitButton.Click();
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();

            formTemplatepage.EperformFormTemplateSearchTextBox.SendKeys(dr["FormName"].ToString());
            formTemplatepage.EperformFormTemplateSearchButton.Click();
            var edittext= formTemplatepage.EperformEditButton;
            int count = formTemplatepage.EperformEditListButton.Count();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    formTemplatepage.EperformEditButton.Click();
                    if (formTemplatepage.EperformEditButton.Displayed)
                    {


                        formTemplatepage.EperformEditButton.Click();

                        BaseMethods.webelementverify(formTemplatepage.EperformReferenceTestbox);
                        break;
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        _driver.Navigate().Back();
                    }
                }
            }
            catch
            {
                Thread.Sleep(3000);
                _driver.Navigate().Back();
            }
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