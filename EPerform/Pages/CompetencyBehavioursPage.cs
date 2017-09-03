﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using System.Threading;

namespace EPerform.Pages
{
    class CompetencyBehavioursPage
    {
        public IWebDriver driver;
        public CompetencyBehavioursPage(IWebDriver pDriver)
        {
            driver = pDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Behaviour List')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='close']")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add']")]
        public IWebElement AddBehaviourButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_NewBehaviourName")]
        public IWebElement NewBehaviourNameTextArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        string activeComp = string.Empty;
        string activeCompLevel = string.Empty;
        string newBehaviour = string.Empty;

        public void commonMethodToBehaviourPage()
        {
            HomePage homePage = new HomePage(driver);

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            CompetencyListPage cListPage = new CompetencyListPage(driver);
            activeComp = cListPage.CreateCompetency("Active", true);

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            CompetencyLevelPage cLevelPage = new CompetencyLevelPage(driver);
            activeCompLevel = cLevelPage.CreateCompetencyLevel("Active", true);

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyBehavioursOption.Click();
        }

        public void VerifyBehavioursListPageElements()
        {
            commonMethodToBehaviourPage();

            Assert.IsTrue(PageTitle.Displayed, "Page title 'Behaviour List' is not displayed in the Competency Behaviours List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Page title 'Behaviour List' is displaying in the Competency Behaviours List Page");

            IWebElement newCompetency = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]"));
            IWebElement newCompetencySection = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/.."));

            Assert.IsTrue(newCompetency.Displayed, "New Active Competency '" + activeComp + "' created has not been listed in Competency Behaviour List");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' created has been listed in Competency Behaviour List in seperate section");

            newCompetencySection.Click();

            IWebElement newCompSection_CompDescription = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../../div[2]/div[1]//span[1]"));

            Assert.IsTrue(newCompSection_CompDescription.Displayed, "New Active Competency '" + activeComp + "' description is not displayed in its respective section");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' description - '" + newCompSection_CompDescription.Text + "' is displayed in its respective section");


            IWebElement newCompSectionCompLevelGrid_CompLevelColumn = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//th[text()='Competency Level']"));

            Assert.IsTrue(newCompSectionCompLevelGrid_CompLevelColumn.Displayed, "New Active Competency '" + activeComp + "' Competency Level Column is not displayed in its respective section");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' Competency Level Column is displayed in its respective section");


            IWebElement newCompSectionCompLevelGrid_BehavioursColumn = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//th[text()='Behaviours']"));

            Assert.IsTrue(newCompSectionCompLevelGrid_BehavioursColumn.Displayed, "New Active Competency '" + activeComp + "' Behaviours Column is not displayed in its respective section");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' Behaviours Column is displayed in its respective section");


            IWebElement newActiveCompLevel = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]"));
            //IWebElement newActiveCompLevel_Edit = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]/following-sibling::td[2]/a"));

            Thread.Sleep(2000);
            Assert.IsTrue(newActiveCompLevel.Displayed, "Active Competency Level '" + activeCompLevel + "' is not displayed in its respective section");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency Level '" + activeCompLevel + "' is displayed in its respective section");

            List<IWebElement> CompLevelList = driver.FindElements(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//tbody/tr")).ToList();

            for (int i = 1; i <= CompLevelList.Count; i++)
            {
                IWebElement CompLevel_editButton = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//tbody/tr[" + i + "]//a[contains(text(),'Edit')]"));
                Assert.IsTrue(CompLevel_editButton.Displayed, "'Edit' button is not present against each Competency level");
            }

            ExtentReport.test.Log(LogStatus.Pass, "'Edit' button is present against each Competency level");
        }

        public void CreateBehaviour()
        {
            commonMethodToBehaviourPage();

            IWebElement newCompetency = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]"));
            IWebElement newCompetencySection = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/.."));

            Assert.IsTrue(newCompetency.Displayed, "New Active Competency '" + activeComp + "' created has not been listed in Competency Behaviour List");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' created has been listed in Competency Behaviour List in seperate section");

            newCompetencySection.Click();

            IWebElement newActiveCompLevel = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]"));
            IWebElement newActiveCompLevel_Edit = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]/following-sibling::td[2]/a"));

            Thread.Sleep(2000);

            Assert.IsTrue(newActiveCompLevel.Displayed, "Active Competency Level '" + activeCompLevel + "' is not displayed in its respective section");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency Level '" + activeCompLevel + "' is displayed in its respective section");

            newActiveCompLevel_Edit.Click();

            IWebElement compName_MngBehaviourPopup = driver.FindElement(By.XPath("//h4[contains(text(),'" + activeComp + "')]"));

            Assert.IsTrue(compName_MngBehaviourPopup.Displayed, "Competency Name '" + activeCompLevel + "' is not displayed in the Manage Behaviour popup of '" + activeCompLevel + "' Competency Level");
            ExtentReport.test.Log(LogStatus.Pass, "Competency Name '" + activeCompLevel + "' is displayed in the Manage Behaviour popup of '" + activeCompLevel + "' Competency Level");

            Assert.IsTrue(AddBehaviourButton.Displayed, "Add Button is not displayed in the Manage Behaviour popup of '" + activeCompLevel + "' Competency Level");
            ExtentReport.test.Log(LogStatus.Pass, "Add Button is displayed in the Manage Behaviour popup of '" + activeCompLevel + "' Competency Level");

            newBehaviour = "Behaviour_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            NewBehaviourNameTextArea.Clear();
            NewBehaviourNameTextArea.SendKeys(newBehaviour);

            AddBehaviourButton.Click();

            Assert.IsTrue(SuccessMessage.Displayed, "'" + newBehaviour + "' - Behaviour has not been created successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, '" + newBehaviour + "' - Behaviour has been created successfully");

            CloseButton_Popup.Click();

            driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/..")).Click();
            IWebElement newActiveCompLevel_Behaviour = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]/following-sibling::td[1]//span[contains(text(),'" + newBehaviour + "')]"));

            Thread.Sleep(2000);

            Assert.IsTrue(newActiveCompLevel_Behaviour.Displayed, "'" + newBehaviour + "' - Behaviour created has not been listed properly for Competency Level '" + activeCompLevel + "' under Competency '" + activeComp + "'");
            ExtentReport.test.Log(LogStatus.Pass, "'" + newBehaviour + "' - Behaviour created has been listed properly for Competency Level '" + activeCompLevel + "' under Competency '" + activeComp + "'");

        }

        public void EditBehaviour()
        {
            commonMethodToBehaviourPage();

            IWebElement newCompetency = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]"));
            IWebElement newCompetencySection = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/.."));

            Assert.IsTrue(newCompetency.Displayed, "New Active Competency '" + activeComp + "' created has not been listed in Competency Behaviour List");
            ExtentReport.test.Log(LogStatus.Pass, "New Active Competency '" + activeComp + "' created has been listed in Competency Behaviour List in seperate section");

            newCompetencySection.Click();

            IWebElement newActiveCompLevel = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]"));
            IWebElement newActiveCompLevel_Edit = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]/following-sibling::td[2]/a"));

            Thread.Sleep(2000);

            newActiveCompLevel_Edit.Click();

            IWebElement compName_MngBehaviourPopup = driver.FindElement(By.XPath("//h4[contains(text(),'" + activeComp + "')]"));

            newBehaviour = "Behaviour_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            NewBehaviourNameTextArea.Clear();
            NewBehaviourNameTextArea.SendKeys(newBehaviour);

            AddBehaviourButton.Click();

            Thread.Sleep(1000);

            Assert.IsTrue(SuccessMessage.Displayed, "'" + newBehaviour + "' - Behaviour has not been created successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, '" + newBehaviour + "' - Behaviour has been created successfully");

            driver.FindElement(By.XPath("//span[text()='" + newBehaviour + "']/../..//button[contains(text(),'Edit')]")).Click();

            Thread.Sleep(2000);

            IWebElement EditBehaviour_SaveButton = driver.FindElement(By.XPath("//textarea[contains(text(),'" + newBehaviour + "')]/../..//button[contains(text(),'Save')]"));

            Assert.IsTrue(EditBehaviour_SaveButton.Displayed, "'" + newBehaviour + "' - Behaviour Save button is not displaying");
            ExtentReport.test.Log(LogStatus.Pass, "'" + newBehaviour + "' - Behaviour Save button has been displayed successfully");

            IWebElement EditBehaviour_CancelButton = driver.FindElement(By.XPath("//textarea[contains(text(),'" + newBehaviour + "')]/../..//button[contains(text(),'Cancel')]"));

            Assert.IsTrue(EditBehaviour_CancelButton.Displayed, "'" + newBehaviour + "' - Behaviour Cancel button is not displaying");
            ExtentReport.test.Log(LogStatus.Pass, "'" + newBehaviour + "' - Behaviour Cancel button has been displayed successfully");

            string oldBehaviour = newBehaviour;

            IWebElement EditBehaviourNameTextArea = driver.FindElement(By.XPath("//textarea[contains(text(),'" + newBehaviour + "')]"));

            newBehaviour = "Behaviour_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            EditBehaviourNameTextArea.Clear();
            EditBehaviourNameTextArea.SendKeys(newBehaviour);

            EditBehaviour_SaveButton.Click();

            Thread.Sleep(3000);

            IWebElement EditedBehaviourListed = driver.FindElement(By.XPath("//span[contains(text(),'" + newBehaviour + "')]"));

            Assert.IsTrue(EditedBehaviourListed.Displayed, "Editing of Behaviour '" + oldBehaviour + "' to '" + newBehaviour + "' was not successful");
            ExtentReport.test.Log(LogStatus.Pass, "Editing of Behaviour '" + oldBehaviour + "' to '" + newBehaviour + "' was completed successfully");

            CloseButton_Popup.Click();

            driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/..")).Click();
            Thread.Sleep(3000);
            IWebElement newActiveCompLevel_Behaviour = driver.FindElement(By.XPath("//h3[contains(text(),'" + activeComp + "')]/../..//td[contains(text(),'" + activeCompLevel + "')]/following-sibling::td[1]//span[contains(text(),'" + newBehaviour + "')]"));

            Assert.IsTrue(newActiveCompLevel_Behaviour.Displayed, "'" + newBehaviour + "' - Behaviour created has not been listed properly for Competency Level '" + activeCompLevel + "' under Competency '" + activeComp + "'");
            ExtentReport.test.Log(LogStatus.Pass, "'" + newBehaviour + "' - Behaviour created has been listed properly for Competency Level '" + activeCompLevel + "' under Competency '" + activeComp + "'");
        }

    }
}
