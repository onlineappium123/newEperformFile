using ePerform.Library;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ePerform.Pages;
using System.Threading;
using EPerform.Tests;
using EPerform.Pages;
using ePerform.Library.Extent_Reports;
using System.Collections;

using RelevantCodes.ExtentReports;
using EPerform.Library.Excel;
using System.Data;

using NUnit.Framework.Interfaces;

namespace ePerform.Tests
{
    class _05GlobalQuestionsTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        /// <summary>
        /// To Search Global Questions normally
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "To Search Global Questions Normally")]
        public void SearchGlobalQuestions_Normal()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Search Global Questions normally");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Info, "Keyword Text is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GlobalQuestionListSearch", "KeyName", "GlobalQuestionSearch_01");
            globalQuestionsListPage.SearchGlobalQuestions(dt.Rows[0]);
        }

        /// <summary>
        /// To Search Global Questions Advanced
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "To Search Global Questions Advanced")]
        public void SearchGlobalQuestions_Advanced()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Search Global Questions Advanced");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GlobalQuestionListSearch", "KeyName", "GlobalQuestionSearch_02");

            globalQuestionsListPage.SearchGlobalQuestions(dt.Rows[0]);
        }

        /// <summary>
        /// To Customise Global Questions List
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "To Customise Global Questions List")]
        public void CustomiseGlobalQuestionsList()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Customise Global Questions List");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GlobalQuestionListCustomise", "KeyName", "Default");

            globalQuestionsListPage.CustomiseGlobalQuestionsList(dt.Rows[0]);
        }

        ///// <summary>
        ///// To Sort Reference Columns in Global Questions List
        ///// </summary>
        //[Test, Order(4)]
        //[TestCase(Description = "To Sort Reference Columns in Global Questions List")]
        //public void SortingReference()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

        //    ExtentReport.test = ExtentReport.extent.StartTest("To Sort Reference Columns in Global Questions List");
        //    homePage.EperformSystemConfigurationArrowIcon.Click();
        //    homePage.EperformGlobalQuestionsOption.Click();

        //    Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
        //    ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

        //    globalQuestionsListPage.SortingReference();
        //}

        ///// <summary>
        ///// To Sort Created On Columns in Global Questions List
        ///// </summary>
        //[Test, Order(5)]
        //[TestCase(Description = "To Sort Created On Columns in Global Questions List")]
        //public void SortingCreatedOn()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

        //    ExtentReport.test = ExtentReport.extent.StartTest("To Sort Created On Columns in Global Questions List");
        //    homePage.EperformSystemConfigurationArrowIcon.Click();
        //    homePage.EperformGlobalQuestionsOption.Click();

        //    Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
        //    ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

        //    globalQuestionsListPage.SortingCreatedOn();
        //}

        /// <summary>
        /// To Sort All Columns in Global Questions List
        /// </summary>
        [Test, Order(6)]
        [TestCase(Description = "To Sort All Columns in Global Questions List")]
        public void Sorting()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Sort All Columns in Global Questions List");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

            globalQuestionsListPage.Sorting();
        }

        /// <summary>
        /// To Verify Select Question Component Type Form
        /// </summary>
        [Test, Order(10)]
        [TestCase(Description = "To Verify Question Component Type Form page")]
        public void VerifyQuestionTypeForm()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            Assert.IsTrue(selectQuestionTypePage.PageTitle.Displayed, "Select Question Type Page Title is not displayed in Question Component Type page");
            ExtentReport.test.Log(LogStatus.Pass, "'" + selectQuestionTypePage.PageTitle.Text + "' Page Title is displayed in Question Component Type page");

            Assert.IsTrue(selectQuestionTypePage.SelectQuestionTypeFormTitle.Displayed, "Select Question Component Type form Title is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "'" + selectQuestionTypePage.SelectQuestionTypeFormTitle.Text + "' Question Type form name is displayed in Question Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSingleLineTextBox.Displayed, "Single Line Text Box Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Single Line Text Box Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoMultiLineTextArea.Displayed, "Multi Line Text Area Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Multi Line Text Area Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSelectSingleItem.Displayed, "Select Single Item from a List Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Select Single Item from a List Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSelectMultipleItems.Displayed, "Select Multiple Items from a List Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Select Multiple Items from a List Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoNumeric.Displayed, "Numeric Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Numeric Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoYesorNo.Displayed, "Yes or No Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Yes or No Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoDate.Displayed, "Date Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Date Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoFileUpload.Displayed, "File Upload Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "File Upload Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.BtnSubmit.Displayed, "Submit button is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.BtnCancel.Displayed, "Cancel button is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button is displayed in Question Component Type form");
        }

        [Test, Order(11)]
        [TestCase(Description = "To Create Global Question Single Line Text Box")]
        public void CreateGQ_SingleLineTextBox()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Single Line Text Box");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");


            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSingleLineTextBox", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_SingleLineTextBox(dt.Rows[0]);
        }

        [Test, Order(12)]
        [TestCase(Description = "To Create Global Question Multi Line Text Area")]
        public void CreateGQ_MultiLineTextArea()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Multi Line Text Area");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQMultiLineTextArea", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_MultiLineTextArea(dt.Rows[0]);
        }

        [Test, Order(13)]
        [TestCase(Description = "To Create Global Question Select Single Item from a List")]
        public void CreateGQ_SelectSingleItem()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Select Single Item from a List");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectSingleItem", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_SelectSingleItem(dt.Rows[0]);
        }

        [Test, Order(14)]
        [TestCase(Description = "To Create Global Question Select Multiple Items from a List")]
        public void CreateGQ_SelectMultipleitems()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Select Multiple Items from a List");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectMultipleItems", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_SelectMultipleitems(dt.Rows[0]);
        }

        [Test, Order(15)]
        [TestCase(Description = "To Create Global Question Numeric")]
        public void CreateGQ_Numeric()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Numeric");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQNumeric", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_Numeric(dt.Rows[0]);
        }

        [Test, Order(16)]
        [TestCase(Description = "To Create Global Question Yes or No")]
        public void CreateGQ_YesorNo()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Yes or No");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQYesorNo", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_YesorNo(dt.Rows[0]);
        }

        [Test, Order(17)]
        [TestCase(Description = "To Create Global Question Date")]
        public void CreateGQ_Date()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Date");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQDate", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_Date(dt.Rows[0]);
        }

        [Test, Order(18)]
        [TestCase(Description = "To Create Global Question File Upload")]
        public void CreateGQ_FileUpload()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question File Upload");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQFileUpload", "KeyName", "Default");
            selectQuestionTypePage.CreateGQ_FileUpload(dt.Rows[0]);
        }

        [Test, Order(19)]
        [TestCase(Description = "To Edit Global Question Single Line Text Box")]
        public void EditGQ_SingleLineTextBox()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question Single Line Text Box");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSingleLineTextBox", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSingleLineTextBox", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_SingleLineTextBox(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(20)]
        [TestCase(Description = "To Edit Global Question Multi Line Text Area")]
        public void EditGQ_MultiLineTextArea()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Multi Line Text Area");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQMultiLineTextArea", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQMultiLineTextArea", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_MultiLineTextArea(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(21)]
        [TestCase(Description = "To Edit Global Question Select Single Item from a List")]
        public void EditGQ_SelectSingleItem()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Select Single Item from a List");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectSingleItem", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectSingleItem", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_SelectSingleItem(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(22)]
        [TestCase(Description = "To Edit Global Question Select Multiple Items from a List")]
        public void EditGQ_SelectMultipleitems()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Select Multiple Items from a List");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectMultipleItems", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSelectMultipleItems", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_SelectMultipleitems(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(23)]
        [TestCase(Description = "To Edit Global Question Numeric")]
        public void EditGQ_Numeric()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Numeric");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQNumeric", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQNumeric", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_Numeric(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(24)]
        [TestCase(Description = "To Edit Global Question Yes or No")]
        public void EditGQ_YesorNo()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Yes or No");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQYesorNo", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQYesorNo", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_YesorNo(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(25)]
        [TestCase(Description = "To Edit Global Question Date")]
        public void EditGQ_Date()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question Date");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQDate", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQDate", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_Date(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(26)]
        [TestCase(Description = "To Edit Global Question File Upload")]
        public void EditGQ_FileUpload()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question File Upload");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dtAdd = ExcelData.GetData_DataTable("ER_TESTDATA", "GQFileUpload", "KeyName", "Default");
            DataTable dtEdit = ExcelData.GetData_DataTable("ER_TESTDATA", "GQFileUpload", "KeyName", "Default_Edit");
            selectQuestionTypePage.EditGQ_FileUpload(dtAdd.Rows[0], dtEdit.Rows[0]);
        }

        [Test, Order(27)]
        [TestCase(Description = "To Delete Global Question that are not in use")]
        public void DeleteGQ_NotInUse()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Delete Global Question that are not in use");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("ER_TESTDATA", "GQSingleLineTextBox", "KeyName", "Default");
            string reference = selectQuestionTypePage.CreateGQ_SingleLineTextBox(dt.Rows[0]);

            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(_driver);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            gqListPage.SearchedDeleteButton.Click();
            Thread.Sleep(2000);
            gqListPage.DeletePopupConfirmButton.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(gqListPage.SuccessMessage.Displayed, reference + " - Single Line Text Box Global Question is not deleted successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + reference + " - Single Line Text Box Global Question has been deleted successfully");
        }

        [Test, Order(30)]
        public void VerifyManageGQForm_SingleLineTextBox()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            selectQuestionTypePage.RdoSingleLineTextBox.Click();
            selectQuestionTypePage.BtnSubmit.Click();

            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(_driver);
            Thread.Sleep(2000);
            Assert.IsTrue(mGQPage.PageTitle.Displayed, "Manage Global Question Page Title is not displayed in Manage Global Question page");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Global Question Page Title is displayed in Manage Global Question page");

            Assert.IsTrue(mGQPage.ManageGQFormTitle_SingleLineTextBox.Displayed, "Manage Global Question - Single Line Text Box form Title is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Global Question - Single Line Text Box form Title is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMandatoryField.Displayed, "Mandatory Message text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Mandatory Message text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblComponentType.Displayed, "Component Type text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Component Type text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblSingleLineTextBox.Displayed, "Single Line Text Box text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Single Line Text Box text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblReference.Displayed, "Reference text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Reference text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblActive.Displayed, "Active text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Active text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblLabel.Displayed, "'Label' text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "'Label' text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblRequired.Displayed, "Required text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Required text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMaximumLength.Displayed, "Maximum Length text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Maximum Length text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMaximumLengthType.Displayed, "Maximum Length Type text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Maximum Length Type text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.BtnSubmit.Displayed, "Submit button is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.BtnCancel.Displayed, "Cancel button is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button is displayed in Manage Global Question form");

        }

        [Test, Order(31)]
        public void VerifyValidation_SelectQuestionTypePage()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");
            ArrayList list = ExcelData.GetData("ER_TESTDATA", "HomePagesVerify", "KeyName", "HomeSystemConfigurationPage");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            selectQuestionTypePage.BtnSubmit.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(selectQuestionTypePage.ErrorMessage.Displayed, "Error Message is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Error Message is displayed in Question Component Type form, Validation successful");
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
